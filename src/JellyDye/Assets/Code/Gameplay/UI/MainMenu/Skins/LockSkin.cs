using Code.Services.Progress;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.UI.MainMenu.Skins
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
      if (_progress.ForSkins.IsPlayerHaveSkin(_equipSkinButton.SkinType))
        UnlockSkin();
    }

    public void UnlockSkin()
    {
      _iconObject.SetActive(true);
      _lockedObject.SetActive(false);
    }
  }
}