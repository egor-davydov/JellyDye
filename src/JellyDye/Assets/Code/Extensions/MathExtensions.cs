using UnityEngine;

namespace Code.Extensions
{
  public static class MathExtensions
  {
    private const float DefaultEpsilon = 0.01f;

    public static bool RGBSimilarTo(this Color color1, Color color2, float epsilon = DefaultEpsilon) =>
      XYZSimilar(color1, color2, epsilon);

    public static bool AlphaSimilarTo(this Color color1, Color color2, float epsilon = DefaultEpsilon)
    {
      float delta = Mathf.Abs(color1.a - color2.a);
      return delta < epsilon;
    }

    private static bool XYZSimilar(Vector4 vector1, Vector4 vector2, float epsilon)
    {
      Vector4 delta = AbsVector(vector1 - vector2);
      return delta.x < epsilon && delta.y < epsilon && delta.z < epsilon;
    }

    private static Vector4 AbsVector(Vector4 delta)
    {
      var absColor = new Vector4(Mathf.Abs(delta.x), Mathf.Abs(delta.y), Mathf.Abs(delta.z), Mathf.Abs(delta.w));
      return absColor;
    }
  }
}