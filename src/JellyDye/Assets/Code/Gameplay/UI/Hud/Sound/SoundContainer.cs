using System;
using Code.Services;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.UI.Hud.Sound
{
    public class SoundContainer : MonoBehaviour
    {
        [SerializeField] private GameObject _soundOnObject;
        [SerializeField] private GameObject _soundOffObject;
        
        private AudioService _audioService;

        [Inject]
        public void Construct(AudioService audioService)
        {
            _audioService = audioService;
            SetSoundIcon(!_audioService.IsAudioMuted);
        }

        private void Awake() => 
            _audioService.OnAudioStateChanged += SetSoundIcon;

        private void OnDestroy() => 
            _audioService.OnAudioStateChanged -= SetSoundIcon;

        public void SetSoundIcon(bool isOn)
        {
            _soundOnObject.SetActive(isOn);
            _soundOffObject.SetActive(!isOn);
        }

    }
}