using UnityEngine;

namespace Code.Gameplay.UI
{
  public class UIAudio : MonoBehaviour
  {
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _uiClick;

    public void PlayClick()
    {
      _audioSource.Stop();
      _audioSource.PlayOneShot(_uiClick);
    }
  }
}