using Code.Services.Factories;
using Fluxy;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Injection
{
  public class PaintColorChange : MonoBehaviour
  {
    private Color[] _colors;
    private FluxyTarget _fluxyTarget;
    private ColorChangerFactory _colorChangerFactory;

    [Inject]
    public void Construct(ColorChangerFactory colorChangerFactory)
    {
      _colorChangerFactory = colorChangerFactory;
    }

    public void Initialize(FluxyTarget fluxyTarget, Color[] colors)
    {
      _fluxyTarget = fluxyTarget;
      _colors = colors;
      InitStartColor();
      foreach (Color color in colors)
      {
        ColorChanger colorChanger = _colorChangerFactory.Create(transform).GetComponent<ColorChanger>();
        colorChanger.Initialize(fluxyTarget, color);
      }
    }

    private void InitStartColor() => 
      _fluxyTarget.transform.parent.GetComponent<PaintInjection>().ChangeLiquidColor(_colors[0]);
  }
}