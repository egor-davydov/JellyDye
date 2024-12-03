namespace Code.UI
{
  public interface IWindow
  {
    bool IsOpen { get; }
    void OpenWindow();
    void CloseWindow();
  }
}