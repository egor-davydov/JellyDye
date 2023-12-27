using Code.Services;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.Hud.Sound
{
  public class SoundButton : MonoBehaviour
  {
    [SerializeField] private UIAudio _uiAudio;
    [SerializeField] private bool _turnSoundOn;
    [SerializeField] private Button _soundButton;
    
    private AudioService _audioService;

    [Inject]
    public void Construct(AudioService audioService) => 
      _audioService = audioService;

    private void Awake() => 
      _soundButton.onClick.AddListener(OnSoundClick);

    private void OnSoundClick()
    {
      _uiAudio.PlayClick();

      if (_turnSoundOn)
        _audioService.UnMuteGame();
      else
        _audioService.MuteGame();
    }

  }
}