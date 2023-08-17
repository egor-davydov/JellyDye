using Fluxy;
using UnityEngine;

namespace Code.Helpers
{
  public class SetTargetColorFromClearColor : MonoBehaviour
  {
    public bool IsColorSetted { get; private set; }
    private void Awake()
    {
      IsColorSetted = false;
      Color clearColor = GetComponent<FluxyContainer>().clearColor;
      Color targetColor = GetComponentInChildren<FluxyTarget>().color;
      if (targetColor != clearColor && clearColor != Color.white)
        GetComponentInChildren<FluxyTarget>().color = clearColor;
      IsColorSetted = true;
    }
  }
}