using Code.Services;
using Code.Services.Progress;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.UI.FinishWindow
{
  public class FinishWindow : MonoBehaviour, IWindow
  {
    [field: SerializeField] public SkinProgressBar SkinProgressBar { get; private set; }
    [SerializeField] private RawImage _yourResultImage;
    [SerializeField] private RawImage _shouldBeImage;
    [SerializeField] private TextMeshProUGUI _percentageText;
    [SerializeField] private Transform _textTransform;
    [SerializeField] private Transform _windowTransform;
    [SerializeField] private AnimatedButton _nextLevelButton;
    [SerializeField] private float _appearanceAnimationDuration;
    [SerializeField] private float _percentageIncreaseTime;
    [SerializeField] private float _textIncreaseScale;
    [SerializeField] private float _scalingTime;

    private Tween _scaleTween;

    private StringsService _stringsService;
    private ProgressService _progress;
    private StaticDataService _staticData;
    private TweenerCore<Vector3, Vector3, VectorOptions> _appearanceTween;

    [Inject]
    public void Construct(ProgressService progressService, StaticDataService staticDataService,
      StringsService stringsService)
    {
      _stringsService = stringsService;
      _staticData = staticDataService;
      _progress = progressService;
    }

    public bool IsOpen { get; private set; } = true;

    private void Awake()
    {
      _scaleTween = _textTransform.DOScale(Vector3.one * _textIncreaseScale, _scalingTime)
        .SetAutoKill(false);
      _appearanceTween = _windowTransform.DOScale(Vector3.one, _appearanceAnimationDuration)
        .From(Vector3.zero).SetLink(gameObject).SetAutoKill(false);
    }

    private void OnDestroy() =>
      _scaleTween.Kill();

    public void Initialize(Texture2D screenshot)
    {
      _shouldBeImage.texture = _staticData.ForLevel(_progress.ForLevels.CurrentLevelId).TargetTextureWithGround;
      _yourResultImage.texture = screenshot;
      _nextLevelButton.ResetAnimation();
      SetPercentage(0);
    }

    public void OpenWindow() =>
      SetActiveWindow(true);

    public void CloseWindow() =>
      SetActiveWindow(false);

    private void SetActiveWindow(bool isActive)
    {
      IsOpen = isActive;
      gameObject.SetActive(isActive);
    }

    public async UniTask AnimateWindowAppearanceAsync()
    {
      _appearanceTween.Restart();
      await _appearanceTween.AwaitForComplete();
    }

    public async UniTask AnimatePercentageTextAsync(int percentage)
    {
      _scaleTween.Restart();
      await PercentageIncrease(percentage);
      _scaleTween.PlayBackwards();
    }

    public void AnimateNextLevelButton()
    {
      _nextLevelButton.Animate();
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