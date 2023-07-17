using Fluxy;
using UnityEngine;

namespace Code.Gameplay.Syringe
{
  public class SyringePaint : MonoBehaviour
  {
    [SerializeField] private FluxyTarget _fluxyTarget;
    [SerializeField] private MeshRenderer _liquidRenderer;
    
    private static readonly int LiquidColorId = Shader.PropertyToID("_Color");

    private void Awake()
    {
      _liquidRenderer.sharedMaterial = new Material(_liquidRenderer.sharedMaterial.shader);
    }
    
    public void ChangeLiquidColor(Color newColor)
    {
      _fluxyTarget.color = newColor;
      _liquidRenderer.sharedMaterial.SetColor(LiquidColorId, newColor);
    }
  }
}