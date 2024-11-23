using Code.Data;
using Code.Services;
using Code.Services.Progress;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.FinishWindow
{
  public class FinishWindow : MonoBehaviour
  {
    [field: SerializeField] public SkinProgressBar SkinProgressBar { get; private set; }
    [SerializeField] private RawImage _yourResultImage;
    [SerializeField] private RawImage _shouldBeImage;
    [SerializeField] private TextMeshProUGUI _percentageText;
    [SerializeField] private Transform _textTransform;
    [SerializeField] private Transform _resultsTransform;
    [SerializeField] private float _appearanceAnimationDuration;
    [SerializeField] private float _percentageIncreaseTime;
    [SerializeField] private float _textIncreaseScale;
    [SerializeField] private float _scalingTime;


    private LevelData _progressLevelData;
    private Tween _scaleTween;

    private StringsService _stringsService;
    private ProgressService _progressService;
    private StaticDataService _staticDataService;

    [Inject]
    public void Construct(ProgressService progressService, StaticDataService staticDataService,
      StringsService stringsService)
    {
      _stringsService = stringsService;
      _staticDataService = staticDataService;
      _progressService = progressService;
      _progressLevelData = _progressService.Progress.LevelData;
    }

    public void Initialize(Texture2D screenshot)
    {
      _shouldBeImage.texture = _staticDataService.ForLevel(_progressLevelData.CurrentLevelId).TargetTextureWithGround;
      _yourResultImage.texture = screenshot;
    }

    private void OnDestroy() =>
      _scaleTween.Kill();

    public async UniTask AnimateWindowAppearanceAsync()
    {
      _resultsTransform.localScale = Vector3.zero;
      await _resultsTransform.DOScale(Vector3.one, _appearanceAnimationDuration);
    }

    public async UniTask AnimatePercentageTextAsync(int percentage)
    {
      _scaleTween = _textTransform.DOScale(Vector3.one * _textIncreaseScale, _scalingTime);
      await PercentageIncrease(percentage);
      _scaleTween = _textTransform.DOScale(Vector3.one, _scalingTime);
    }

    private async UniTask PercentageIncrease(float percentage)
    {
      float currentTime = 0;
      while (currentTime < _percentageIncreaseTime)
      {
        currentTime += Time.deltaTime;
        float currentPercentage = Mathf.Lerp(0, percentage, currentTime / _percentageIncreaseTime);
        SetPercentage(currentPercentage);
        await UniTask.Yield(destroyCancellationToken);
      }

      SetPercentage(percentage);
    }

    private void SetPercentage(float currentPercentage)
    {
      currentPercentage = RoundAndClampPercentage(currentPercentage);
      _percentageText.text = _stringsService.Percentages[(int)currentPercentage];
    }

    private float RoundAndClampPercentage(float currentPercentage)
    {
      currentPercentage = Mathf.RoundToInt(currentPercentage);
      currentPercentage = Mathf.Clamp(currentPercentage, 0, 100);
      return currentPercentage;
    }
  }
}