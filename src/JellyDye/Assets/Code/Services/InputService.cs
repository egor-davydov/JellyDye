using UnityEngine;
using UnityEngine.EventSystems;

namespace Code.Services
{
  public class InputService
  {
    private const int InputButton = 0;

    private readonly PublishService _publishService;

    public InputService(PublishService publishService)
    {
      _publishService = publishService;
    }

    public bool IsInputButtonPressedInGameSpace =>
      IsInputButtonPressed && !IsPointerOverUIObject();

    public bool IsInputButtonPressed =>
      Input.GetMouseButtonDown(InputButton);

    public bool IsInputButtonReleased =>
      Input.GetMouseButtonUp(InputButton);

    private bool IsPointerOverUIObject()
    {
      if (!_publishService.IsPlatformMobile())
        return EventSystem.current.IsPointerOverGameObject();

      for (int i = 0; i < Input.touchCount; i++)
      {
        Touch touch = Input.GetTouch(i);
        if (touch.phase != TouchPhase.Began)
          continue;
        if (EventSystem.current.IsPointerOverGameObject(touch.fingerId))
          return true;
      }

      return false;
    }
  }
}