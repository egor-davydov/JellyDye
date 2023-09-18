using Code.Services;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.UI.Hud.Sound
{
    public class SoundContainer : MonoBehaviour
    {
        [SerializeField] private GameObject _soundOnObject;
        [SerializeField] private GameObject _soundOffObject;
        
        [Inject]
        public void Construct(AudioService audioService) => 
            SetSoundIcon(!audioService.IsMuted);

        public void SetSoundIcon(bool condition)
        {
            _soundOnObject.SetActive(condition);
            _soundOffObject.SetActive(!condition);
        }

    }
}