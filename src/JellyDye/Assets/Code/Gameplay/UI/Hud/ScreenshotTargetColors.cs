using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Gameplay.UI.Hud
{
  public class ScreenshotTargetColors : MonoBehaviour
  {
    [SerializeField] private TextMeshProUGUI _levelNumberText;
    [SerializeField] private RawImage _screenshotImage;
    
    public void Initialize(Texture2D screenshotImage, int levelNumber)
    {
      _screenshotImage.texture = screenshotImage;
      _levelNumberText.text = $"Level {levelNumber}";
    }
  }
}