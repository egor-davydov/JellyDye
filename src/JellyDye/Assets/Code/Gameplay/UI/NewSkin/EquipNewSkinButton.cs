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
    [SerializeField] private Button _button;
    [SerializeField] private Image _skinEquippedImage;
    [SerializeField] private float _fadeDelay;
    [SerializeField] private float _fadeTime;

    private ProgressService _progressService;
    private SkinType _skinType;

    [Inject]
    public void Construct(ProgressService progressService)
    {
      _progressService = progressService;
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
      _progressService.Progress.SkinData.EquipSkin(_skinType);
      _button.gameObject.SetActive(false);
      UniTask.WaitForSeconds(_fadeDelay);
      await _skinEquippedImage.DOFade(0, _fadeTime);
      Destroy(gameObject);
    }
  }
}