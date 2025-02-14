using Code.Gameplay.Language;
using Code.Services;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.UI.Hud
{
  public class ScreenshotTargetColors : MonoBehaviour
  {
    [SerializeField] private TextMeshProUGUI _levelNumberText;
    [SerializeField] private RawImage _screenshotImage;
    [SerializeField] private LanguageChangerText _languageChangerText;

    private StaticDataService _staticData;

    [Inject]
    public void Construct(StaticDataService staticData)
    {
      _staticData = staticData;
    }

    public void Initialize(string levelId)
    {
      int levelNumber = _staticData.ForLevels.GetLevelIndex(levelId) + 1;
      _screenshotImage.texture = _staticData.ForLevel(levelId).TargetTexture;
      _levelNumberText.text = $"{_languageChangerText.ResultText} {levelNumber}";
    }
  }
}