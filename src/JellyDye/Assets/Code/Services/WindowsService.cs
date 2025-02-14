using Code.Services.Factories.UI;
using Code.Services.Providers;
using Code.UI;
using Code.UI.FinishWindow;
using Code.UI.MainMenuWindow;
using Cysharp.Threading.Tasks;

namespace Code.Services
{
  public class WindowsService
  {
    private readonly WindowsProvider _windowsProvider;
    private readonly WindowFactory _windowFactory;

    public WindowsService(WindowsProvider windowsProvider, WindowFactory windowFactory)
    {
      _windowsProvider = windowsProvider;
      _windowFactory = windowFactory;
    }

    public async UniTask CreateAndInitializeWindowsAsync()
    {
      FinishWindow finishWindow = await _windowFactory.CreateFinishWindow();
      finishWindow.CloseWindow();
      _windowsProvider.FinishWindow = finishWindow;

      MainMenuWindow mainMenuWindow = await _windowFactory.CreateMainMenu();
      mainMenuWindow.CloseWindow();
      _windowsProvider.MainMenuWindow = mainMenuWindow;
    }

    public void CloseWindowsIfOpened()
    {
      IWindow mainMenuWindow = _windowsProvider.MainMenuWindow;
      if (mainMenuWindow.IsOpen)
        mainMenuWindow.CloseWindow();

      IWindow finishWindow = _windowsProvider.FinishWindow;
      if (finishWindow.IsOpen)
        finishWindow.CloseWindow();
    }
  }
}