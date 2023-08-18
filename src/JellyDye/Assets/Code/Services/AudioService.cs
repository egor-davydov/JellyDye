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
    private float _startAudio;

    public void Initialize()
    {
      _audioMixer = Resources.Load<AudioMixer>(MixerPath);
      _audioMixer.GetFloat(ParameterName, out _startAudio);
    }

    public void MuteGame()
    {
      _audioMixer.SetFloat(ParameterName, -80);
    }
    
    public void UnMuteGame()
    {
      _audioMixer.SetFloat(ParameterName, _startAudio);
    }
  }
}