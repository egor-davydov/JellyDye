using UnityEngine;

namespace Code.Helpers
{
  public class MathHelp
  {
    public static bool VectorsSimilar(Vector4 vector1, Vector4 vector2, float epsilon)
    {
      Vector4 absDelta = Abs(vector1 - vector2);
      return absDelta.x < epsilon && absDelta.y < epsilon && absDelta.z < epsilon && absDelta.w < epsilon;
    }

    private static Vector4 Abs(Vector4 delta)
    {
      var absColor = new Vector4(Mathf.Abs(delta.x), Mathf.Abs(delta.y), Mathf.Abs(delta.z), Mathf.Abs(delta.w));
      return absColor;
    }

  }
}