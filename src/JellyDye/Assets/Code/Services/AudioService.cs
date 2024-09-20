using System;
using System.Threading.Tasks;
using Code.Services.AssetManagement;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Audio;
using Zenject;

namespace Code.Services
{
  public class AudioService : IInitializable
  {
    private const string ParameterName = "MasterVolume";

    private readonly IAssetProvider _assetProvider;
    
    private AudioMixer _audioMixer;
    private float _startVolume;

    public event Action<bool> OnAudioStateChanged;
    public bool IsAudioMuted { get; private set; }

    public AudioService(IAssetProvider assetProvider)
    {
      _assetProvider = assetProvider;
    }
    
    public void Initialize()
    {
      LoadAndInitializeAudioMixer().Forget();
    }

    private async UniTaskVoid LoadAndInitializeAudioMixer()
    {
      _audioMixer = await _assetProvider.Load<AudioMixer>(AssetKey.AudioMixer);
      _audioMixer.GetFloat(ParameterName, out _startVolume);
    }

    public void MuteGame()
    {
      IsAudioMuted = true;
      OnAudioStateChanged?.Invoke(!IsAudioMuted);
      _audioMixer.SetFloat(ParameterName, -80);
    }
    
    public void UnMuteGame()
    {
      IsAudioMuted = false;
      OnAudioStateChanged?.Invoke(!IsAudioMuted);
      _audioMixer.SetFloat(ParameterName, _startVolume);
    }
  }
}