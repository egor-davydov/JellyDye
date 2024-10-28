const library = {

  // Class definition.

  $yandexGames: {
    isYandexGames: false,

    isAuthorized: false,

    sdk: undefined,

    leaderboard: undefined,

    playerAccount: undefined,
    
    billing: undefined,
  allocateUnmanagedString: function (string) {
    const stringBufferSize = lengthBytesUTF8(string) + 1;
    const stringBufferPtr = _malloc(stringBufferSize);
    stringToUTF8(string, stringBufferPtr, stringBufferSize);
    return stringBufferPtr;
  },
  appendBackgroundImage: function (lang) {
    document.head.insertAdjacentHTML("beforeend", `<style>body{background-image: url(Images/background_`+lang+`.png);background-repeat: no-repeat;background-attachment: fixed;background-size: 100% 100%; }</style>`); 
  },
},
  InitializeYandexGames: function (onSdkInitialize, onPlayerInitialize) {
    const sdkScript = document.createElement('script');
    sdkScript.src = '/sdk.js';
    document.head.appendChild(sdkScript);
    console.log('on sdkScript document.head.append');

    sdkScript.onload = function () {
      console.log('onload sdkScript');
      window['YaGames'].init().then(function (sdk) {
        console.log('on window[YaGames].init()');
        yandexGames.isYandexGames = true;
        yandexGames.sdk = sdk;
        {{{ makeDynCall('v', 'onSdkInitialize') }}}();
        yandexGames.appendBackgroundImage(sdk.environment.i18n.lang);
        if (sdk.deviceInfo.isDesktop()) {
          var container = document.querySelector("#unity-container");
          container.style.display = "flex";
          container.style.justifyContent = "center";
          container.style.alignItems = "center";
          container.style.width = "100%";
          container.style.height = "100%";
          
          var canvas = document.querySelector("#unity-canvas");
          canvas.style.width = "56.25vh";
          canvas.style.height = "100vh";
          canvas.style.maxWidth = "100%";
        }
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
          {{{ makeDynCall('v', 'onPlayerInitialize') }}}();
        });
      }).catch(function (e) {
          console.log('Error on sdk initialization: '+e);
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
        var buffer = yandexGames.allocateUnmanagedString(jsonObject);
        {{{ makeDynCall('vi', 'callback') }}}(buffer);
        _free(buffer);
    }).catch(function (e) { console.log('Error on loading player data. ', e); });
  },
  IsMobile: function () {
    return /iPhone|iPad|iPod|Android/i.test(navigator.userAgent);
  },
  SetToYandexLeaderboard: function (score) {
    yandexGames.leaderboard.setLeaderboardScore('Paint', score);
  },
  GetYandexLanguage: function () {
    return yandexGames.allocateUnmanagedString(yandexGames.sdk.environment.i18n.lang);
  },
  GameReadyToPlayYandex: function () {
    console.log('Game is ready to play');
    yandexGames.sdk.features.LoadingAPI.ready();
  },
  ShowYandexFullscreenAdv: function (onOpen, onClose) {
     yandexGames.sdk.adv.showFullscreenAdv({
        callbacks: {
            onOpen: function() {
            {{{ makeDynCall('v', 'onOpen') }}}();
            },
            onClose: function(wasShown) {
            {{{ makeDynCall('vi', 'onClose') }}}(wasShown);
            },
            onError: function(error) {
              console.log('Error while show FullscreenAdv:', error);
            }
        }
    });
  },
  ShowYandexRewardedVideo: function (onRewarded) {
     yandexGames.sdk.adv.showRewardedVideo({
        callbacks: {
          onRewarded: () => {
            {{{ makeDynCall('v', 'onRewarded') }}}();
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
            {{{ makeDynCall('vi', 'response') }}}(value);
            if (!value) {
                console.log(reason);
            }
        }); 
  },
  ShowYandexReviewGameWindow: function (onPlayerAction) {
     yandexGames.sdk.feedback.requestReview()
        .then(({ feedbackSent }) => {
            {{{ makeDynCall('vi', 'onPlayerAction') }}}(feedbackSent);
        });
  },
  WebDebugLog: function (log) {
    var dataString = UTF8ToString(log);
    console.log(dataString);
  },
}

autoAddDeps(library, '$yandexGames');
mergeInto(LibraryManager.library, library);