using UnityEngine;

namespace Code.Gameplay.Syringe
{
  public class SyringeAudio : MonoBehaviour
  {
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _audioClipReset;
    [SerializeField] private AudioClip _audioClipFill;
    [SerializeField] private AudioClip _audioClipFillEnd;

    public void PlayReset()
    {
      _audioSource.Stop();
      _audioSource.PlayOneShot(_audioClipReset);
    }
    public void PlayFillEnd()
    {
      _audioSource.Stop();
      _audioSource.PlayOneShot(_audioClipFillEnd);
    }
    public void PlayFill()
    {
      _audioSource.Stop();
      _audioSource.PlayOneShot(_audioClipFill);
    }
  }
}