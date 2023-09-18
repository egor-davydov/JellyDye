using UnityEngine;
using UnityEngine.Audio;
using Zenject;

namespace Code.Services
{
  public class AudioService : IInitializable
  {
    private const string MixerPath = "Audio/Mixer";
    private const string ParameterName = "MasterVolume";

    private AudioMixer _audioMixer;
    private float _startVolume;
    
    public bool IsMuted { get; private set; }

    public void Initialize()
    {
      _audioMixer = Resources.Load<AudioMixer>(MixerPath);
      _audioMixer.GetFloat(ParameterName, out _startVolume);
    }

    public void MuteGame()
    {
      IsMuted = true;
      _audioMixer.SetFloat(ParameterName, -80);
    }
    
    public void UnMuteGame()
    {
      IsMuted = false;
      _audioMixer.SetFloat(ParameterName, _startVolume);
    }
  }
}