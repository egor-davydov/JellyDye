using Code.Gameplay.Language;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Gameplay.UI.Hud
{
  public class ScreenshotTargetColors : MonoBehaviour
  {
    [SerializeField] private TextMeshProUGUI _levelNumberText;
    [SerializeField] private RawImage _screenshotImage;
    [SerializeField] private LanguageChangerText _languageChangerText;
    
    public void Initialize(Texture2D screenshotImage, int levelNumber)
    {
      _screenshotImage.texture = screenshotImage;
      _levelNumberText.text = $"{_languageChangerText.ResultText} {levelNumber}";
    }
  }
}