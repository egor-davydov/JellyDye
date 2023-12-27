using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Code.Gameplay.UI.Hud
{
  public class InjectionButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
  {
    [SerializeField] private Image _injectionImage;
    [SerializeField] private Sprite _injectingSprite;
    [SerializeField] private Sprite _cantInjectSprite;
    
    private Sprite _notInjectingSprite;

    public bool IsInjecting { get; private set; }
    public event Action OnStartInjection;
    public event Action OnStopInjection;
    private void Awake()
    {
      _notInjectingSprite = _injectionImage.sprite;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
      IsInjecting = true;
      _injectionImage.sprite = _injectingSprite;
      OnStartInjection?.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
      IsInjecting = false;
      _injectionImage.sprite = _notInjectingSprite;
      OnStopInjection?.Invoke();
    }
  }
}