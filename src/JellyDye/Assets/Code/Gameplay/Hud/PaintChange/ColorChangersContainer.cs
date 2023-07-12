using Code.Gameplay.Syringe;
using Code.Services.Factories;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Hud.PaintChange
{
  public class ColorChangersContainer : MonoBehaviour
  {
    private Color[] _colors;
    private ColorChangerFactory _colorChangerFactory;
    private SyringePaint _syringePaint;

    [Inject]
    public void Construct(ColorChangerFactory colorChangerFactory)
    {
      _colorChangerFactory = colorChangerFactory;
    }

    public void Initialize(SyringePaint syringePaint, Color[] colors)
    {
      _syringePaint = syringePaint;
      _colors = colors;
      InitStartColor();
      foreach (Color color in colors)
      {
        ColorChanger colorChanger = _colorChangerFactory.Create(transform).GetComponent<ColorChanger>();
        colorChanger.Initialize(_syringePaint, color);
      }
    }

    private void InitStartColor() => 
      _syringePaint.ChangeLiquidColor(_colors[0]);
  }
}