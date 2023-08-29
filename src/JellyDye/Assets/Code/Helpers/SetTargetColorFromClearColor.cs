using Fluxy;
using UnityEngine;

namespace Code.Helpers
{
  public class SetTargetColorFromClearColor : MonoBehaviour
  {
    private void Awake()
    {
      Color clearColor = GetComponent<FluxyContainer>().clearColor;
      Color targetColor = GetComponentInChildren<FluxyTarget>().color;
      if (targetColor == Color.white)
        GetComponentInChildren<FluxyTarget>().color = clearColor;
    }
  }
}