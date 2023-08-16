using Fluxy;
using UnityEngine;

namespace Code.Gameplay.Syringe
{
  public class SyringePaint : MonoBehaviour
  {
    [SerializeField] private FluxyTarget _fluxyTarget;
    [SerializeField] private MeshRenderer _liquidRenderer;
    [SerializeField] private Shader _shader;

    private static readonly int LiquidColorId = Shader.PropertyToID("_Color");
    private static readonly int LiquidHColorId = Shader.PropertyToID("_HColor");

    private void Awake()
    {
      _liquidRenderer.sharedMaterial = new Material(_shader);
    }

    public void ChangeLiquidColor(Color newColor)
    {
      _fluxyTarget.color = newColor;
      _liquidRenderer.sharedMaterial.SetColor(LiquidColorId, newColor);
      _liquidRenderer.sharedMaterial.SetColor(LiquidHColorId, newColor);
    }
  }
}