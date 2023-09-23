mergeInto(LibraryManager.library, {

  SaveToYandex: function (data) {
    var dataString = UTF8ToString(data);
    var jsonObject = JSON.parse(dataString);
    player.setData(jsonObject);
  },
  LoadFromYandex: function () {
    player.getData().then(_data =>{
        const jsonObject = JSON.stringify(_data);
        var bufferSize = lengthBytesUTF8(jsonObject) + 1;
        var buffer = _malloc(bufferSize);
        stringToUTF8(returnStr, buffer, bufferSize);
        return buffer;
    });
  },
  SetToLeaderboard: function (score) {
    ysdk.getLeaderboards().then(lb =>{
        lb.setLeaderboardScore('Paint', score)
    });
  },
});