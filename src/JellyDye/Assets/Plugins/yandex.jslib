mergeInto(LibraryManager.library, {

  SaveToYandex: function (data) {
    var dataString = UTF8ToString(data);
    var jsonObject = JSON.parse(dataString);
    player.setData(jsonObject);
  },
  LoadFromYandex: function (callback) {
    player.getData().then(_data =>{
        const jsonObject = JSON.stringify(_data);
        var bufferSize = lengthBytesUTF8(jsonObject) + 1;
        var buffer = _malloc(bufferSize);
        stringToUTF8(jsonObject, buffer, bufferSize);
        dynCall('vi', callback, [buffer]);
    });
  },
  SetToLeaderboard: function (score) {
    ysdk.getLeaderboards().then(lb =>{
        lb.setLeaderboardScore('Paint', score)
    });
  },
  IsYandexGames: function (score) {
     return isYandexGames;
  },
});