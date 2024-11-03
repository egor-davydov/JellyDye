using Fluxy;
using UnityEngine;

namespace Code.Gameplay.Syringe
{
  public class SyringeLiquidColor : MonoBehaviour
  {
    [SerializeField] private SyringeAudio _syringeAudio;
    [SerializeField] private FluxyTarget _fluxyTarget;
    [SerializeField] private Shader _shader;

    private MeshRenderer _liquidRenderer;

    private static readonly int LiquidColorId = Shader.PropertyToID("_Color");
    private static readonly int LiquidHColorId = Shader.PropertyToID("_HColor");

    public void WireUp(MeshRenderer liquidRenderer)
    {
      _liquidRenderer = liquidRenderer;
      _liquidRenderer.sharedMaterial = new Material(_shader);
    }

    public void ChangeLiquidColor(Color newColor)
    {
      _syringeAudio.PlayReset();
      _fluxyTarget.color = newColor;
      _liquidRenderer.sharedMaterial.SetColor(LiquidColorId, newColor);
      _liquidRenderer.sharedMaterial.SetColor(LiquidHColorId, newColor);
    }
  }
}