using Code.Gameplay.UI.MainMenu.Skins;
using Code.Services.Progress;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.NewSkin
{
  public class EquipNewSkinButton : MonoBehaviour
  {
    [SerializeField] private UIAudio _uiAudio;
    [SerializeField] private Button _button;
    [SerializeField] private Image _skinEquippedImage;
    [SerializeField] private float _fadeDelay;
    [SerializeField] private float _fadeTime;

    private ProgressService _progress;
    private SkinType _skinType;

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
      _button.onClick.AddListener(UniTask.UnityAction(OnEquipNewSkinButtonClick));
    }

    private async UniTaskVoid OnEquipNewSkinButtonClick()
    {
      _uiAudio.PlayClick();
      _progress.ForSkins.EquipSkin(_skinType);
      _button.gameObject.SetActive(false);
      await UniTask.WaitForSeconds(_fadeDelay).AttachExternalCancellation(destroyCancellationToken);
      await _skinEquippedImage.DOFade(0, _fadeTime).Play().WithCancellation(destroyCancellationToken);
      Destroy(gameObject);
    }
  }
}