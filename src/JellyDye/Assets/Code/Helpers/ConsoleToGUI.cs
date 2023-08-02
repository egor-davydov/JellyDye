using UnityEngine;

namespace Code.Helpers
{
  public class ConsoleToGUI : MonoBehaviour
  {
    private string _myLog;
    private bool _doShow = false;

    void Awake()
    {
      DontDestroyOnLoad(gameObject);
      Application.logMessageReceivedThreaded += Log;
    }

    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space)) 
        _doShow = !_doShow;
    }

    public void Log(string logString, string stackTrace, LogType type) => 
      _myLog = $"{_myLog}\n{logString}: {stackTrace}";

    void OnGUI()
    {
      if (!_doShow)
        return;

      GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity,
        new Vector3(Screen.width / 1200.0f, Screen.height / 800.0f, 1.0f));
      GUI.TextArea(new Rect(10, 10, 540, 370), _myLog);
    }
  }
}