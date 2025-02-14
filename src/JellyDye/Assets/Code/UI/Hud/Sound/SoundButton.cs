using Code.Services;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.UI.Hud.Sound
{
  public class SoundButton : MonoBehaviour
  {
    [SerializeField] private UIAudio _uiAudio;
    [SerializeField] private Button _soundButton;
    [SerializeField] private Sprite _soundOnIcon;
    [SerializeField] private Sprite _soundOffIcon;
    [SerializeField] private Image _soundIconImage;

    private AudioService _audioService;

    [Inject]
    public void Construct(AudioService audioService) =>
      _audioService = audioService;

    private void Awake()
    {
      _audioService.OnAudioStateChanged += OnAudioStateChanged;
      _soundButton.onClick.AddListener(OnSoundClick);
      OnAudioStateChanged(!_audioService.IsAudioMuted);
    }

    private void OnDestroy() =>
      _audioService.OnAudioStateChanged -= OnAudioStateChanged;

    private void OnSoundClick()
    {
      bool isTurningAudioOn = _audioService.IsAudioMuted;
      _uiAudio.PlayClick();
      OnAudioStateChanged(isTurningAudioOn);
      if (isTurningAudioOn)
        _audioService.UnMuteGame();
      else
        _audioService.MuteGame();
    }

    private void OnAudioStateChanged(bool isTurningAudioOn)
    {
      _soundIconImage.sprite = isTurningAudioOn
        ? _soundOnIcon
        : _soundOffIcon;
    }
  }
}