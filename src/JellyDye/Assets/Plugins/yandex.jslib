const library = {

  // Class definition.

  $yandexGames: {
    isYandexGames: false,

    isAuthorized: false,

    sdk: undefined,

    leaderboard: undefined,

    playerAccount: undefined,
    
    billing: undefined,
  },

  TryInitializeYandexGames: function (onInitialize) {
    const sdkScript = document.createElement('script');
    sdkScript.src = 'https://yandex.ru/games/sdk/v2';
    document.head.appendChild(sdkScript);
  
    sdkScript.onload = function () {
      window['YaGames'].init().then(function (sdk) {
        yandexGames.isYandexGames = true;
        yandexGames.sdk = sdk;
  
        const playerAccountInitializationPromise = sdk.getPlayer().then(function (playerAccount) {
          if (playerAccount.getMode() !== 'lite') {
            yandexGames.isAuthorized = true;
          }
  
          yandexGames.playerAccount = playerAccount;
        }).catch(function () { throw new Error('Player failed to initialize.'); });
  
        const leaderboardInitializationPromise = sdk.getLeaderboards().then(function (leaderboard) {
          yandexGames.leaderboard = leaderboard;
        }).catch(function () { throw new Error('Leaderboard failed to initialize.'); });
      
        const billingInitializationPromise = sdk.getPayments({ signed: true }).then(function (billing) {
          yandexGames.billing = billing;
        }).catch(function () { throw new Error('Billing failed to initialize.'); });


        Promise.allSettled([leaderboardInitializationPromise, playerAccountInitializationPromise, billingInitializationPromise]).then(function () {
          console.log('Yandex SDK initialized');
          dynCall('v', onInitialize, []);
          yandexGames.sdk.features.LoadingAPI.ready();
        });
      });
    }
  },
  SaveToYandex: function (data) {
    var dataString = UTF8ToString(data);
    var jsonObject = JSON.parse(dataString);
    yandexGames.playerAccount.setData(jsonObject).catch(function (e) { console.log('Error on saving player data.', e); });
  },
  LoadFromYandex: function (callback) {
    yandexGames.playerAccount.getData().then(_data =>{
        const jsonObject = JSON.stringify(_data);
        console.log('LoadFromYandex jsonObject ' + jsonObject);
        var bufferSize = lengthBytesUTF8(jsonObject) + 1;
        var buffer = _malloc(bufferSize);
        stringToUTF8(jsonObject, buffer, bufferSize);
        dynCall('vi', callback, [buffer]);
    }).catch(function (e) { console.log('Error on loading player data. ', e); });
  },
  SetToYandexLeaderboard: function (score) {
    yandexGames.leaderboard.setLeaderboardScore('Paint', score);
  },
  IsYandexGames: function () {
    return yandexGames.isYandexGames;
  },
  GameReadyToPLayYandex: function () {
    yandexGames.sdk.features.LoadingAPI.ready();
  },
  ShowYandexFullscreenAdv: function (onOpen, onClose) {
     yandexGames.sdk.adv.showFullscreenAdv({
        callbacks: {
            onOpen: function() {
              dynCall('v', onOpen, []);
            },
            onClose: function(wasShown) {
              dynCall('v', onClose, []);
            },
            onError: function(error) {
              console.log('Error while show FullscreenAdv:', error);
            }
        }
    });
  },
  ShowRewardedVideo: function (onRewarded) {
     yandexGames.sdk.adv.showRewardedVideo({
        callbacks: {
          onRewarded: () => {
            dynCall('v', onRewarded, []);
          },
          onError: (e) => {
            console.log('Error while open video ad:', e);
          }
        }
    });
  },
  RequestYandexIsPlayerCanReview: function (response) {
     yandexGames.sdk.feedback.canReview()
        .then(({ value, reason }) => {
            dynCall('vi', response, [value]);
            if (!value) {
                console.log(reason)
            }
        }); 
  },
  ShowYandexReviewGameWindow: function (onPlayerAction) {
     yandexGames.sdk.feedback.requestReview()
        .then(({ feedbackSent }) => {
            dynCall('vi', onPlayerAction, [feedbackSent]);
        });
  },
}

autoAddDeps(library, '$yandexGames');
mergeInto(LibraryManager.library, library);