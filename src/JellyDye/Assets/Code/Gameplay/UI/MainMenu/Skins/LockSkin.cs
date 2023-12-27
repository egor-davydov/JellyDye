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
    
    private ProgressService _progressService;
    
    public bool SkinLocked { get; private set; } = true;

    [Inject]
    public void Construct(ProgressService progressService)
    {
      _progressService = progressService;
    }
    private void Awake()
    {
      if (_progressService.Progress.SkinData.OpenedSkins.Contains(_equipSkinButton.SkinType)) 
        UnlockSkin();
    }

    public void UnlockSkin()
    {
      _iconObject.SetActive(true);
      _lockedObject.SetActive(false);
      SkinLocked = false;
    }
  }
}