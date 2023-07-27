using System;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Gameplay.Hud
{
  public class SoundButton : MonoBehaviour
  {
    [SerializeField] private bool turnSoundOn;
    [SerializeField] private GameObject _soundOnObject;
    [SerializeField] private GameObject _soundOffObject;
    [SerializeField] private Button _soundButton;
    
    private Camera _camera;

    private void Awake()
    {
      _camera = Camera.main;
      _soundButton.onClick.AddListener(OnSoundClick);
    }

    private void OnSoundClick()
    {
      _soundOnObject.SetActive(turnSoundOn);
      _soundOffObject.SetActive(!turnSoundOn);
      
      _camera.GetComponent<AudioListener>().enabled = turnSoundOn;
    }
  }
}