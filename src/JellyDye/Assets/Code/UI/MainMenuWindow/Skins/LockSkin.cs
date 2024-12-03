using Code.Enums;
using Code.Services.Progress;
using UnityEngine;
using Zenject;

namespace Code.UI.MainMenuWindow.Skins
{
  public class LockSkin : MonoBehaviour
  {
    [SerializeField] private EquipSkinButton _equipSkinButton;
    [SerializeField] private GameObject _iconObject;
    [SerializeField] private GameObject _lockedObject;

    private ProgressService _progress;

    [Inject]
    public void Construct(ProgressService progressService)
    {
      _progress = progressService;
    }

    private void Awake()
    {
      _progress.ForSkins.Opened += CheckIsThisOpened;
      if (_progress.ForSkins.IsPlayerHaveSkin(_equipSkinButton.SkinType))
        UnlockSkin();
    }

    private void CheckIsThisOpened(SkinType skinType)
    {
      if (_equipSkinButton.SkinType == skinType)
        UnlockSkin();
    }

    public void UnlockSkin()
    {
      _iconObject.SetActive(true);
      _lockedObject.SetActive(false);
    }
  }
}