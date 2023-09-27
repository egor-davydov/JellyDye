mergeInto(LibraryManager.library, {

  SaveToYandex: function (data) {
    var dataString = UTF8ToString(data);
    var jsonObject = JSON.parse(dataString);
    player.setData(jsonObject);
  },
  LoadFromYandex: function (callback) {
    player.getData().then(_data =>{
        const jsonObject = JSON.stringify(_data);
        console.log('LoadFromYandex jsonObject ' + jsonObject);
        var bufferSize = lengthBytesUTF8(jsonObject) + 1;
        var buffer = _malloc(bufferSize);
        stringToUTF8(jsonObject, buffer, bufferSize);
        console.log('LoadFromYandex buffer ' + buffer);
        dynCall('vi', callback, [buffer]);
    });
  },
  SetToLeaderboard: function (score) {
    ysdk.getLeaderboards().then(lb =>{
        lb.setLeaderboardScore('Paint', score)
    });
  },
  IsYandexGames: function () {
     return isYandexGames;
  },
  GameReadyToPLay: function () {
     ysdk.features.LoadingAPI.ready();
  },
  ShowFullscreenAdv: function (onOpen, onClose) {
     ysdk.adv.showFullscreenAdv({
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
    })
  },
  ShowRewardedVideo: function (onRewarded) {
     ysdk.adv.showRewardedVideo({
        callbacks: {
          onRewarded: () => {
            dynCall('v', onRewarded, []);
          },
          onError: (e) => {
            console.log('Error while open video ad:', e);
          }
        }
    })
  },
});