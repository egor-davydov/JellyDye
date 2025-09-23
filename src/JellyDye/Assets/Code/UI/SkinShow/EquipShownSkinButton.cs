using Code.Enums;
using Code.Extensions;
using Code.Services.Progress;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.UI.SkinShow
{
  public class EquipShownSkinButton : MonoBehaviour
  {
    [SerializeField] private UIAudio _uiAudio;
    [SerializeField] private Button _button;
    [SerializeField] private Image _skinEquippedImage;
    [SerializeField] private float _fadeDelay;
    [SerializeField] private float _fadeTime;

    private ProgressService _progress;
    private SkinType _skinType;
    private Tween _fadeTween;

    [Inject]
    public void Construct(ProgressService progressService)
    {
      _progress = progressService;
    }

    public void Initialize(SkinType skinType)
    {
      _skinType = skinType;
    }

    private void Awake()
    {
      _button.onClick.AddListener(UniTask.UnityAction(OnEquipShownSkinButtonClick));
      _fadeTween = _skinEquippedImage.DOFade(0, _fadeTime).SetLink(gameObject).SetAutoKill(false);
    }

    private async UniTaskVoid OnEquipShownSkinButtonClick()
    {
      _uiAudio.PlayClick();
      _progress.ForSkins.EquipSkin(_skinType);
      _button.gameObject.SetActive(false);
      await UniTask.WaitForSeconds(_fadeDelay).AttachExternalCancellation(destroyCancellationToken);
      await _fadeTween.RestartAndAwaitComplete(TweenCancelBehaviour.Kill, destroyCancellationToken);
      Destroy(gameObject);
    }
  }
}