using System.Collections.Generic;
using Code.Gameplay.Syringe;
using Code.Services.Factories.UI;
using DG.Tweening;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.UI.Hud.PaintChange
{
  public class ColorChangersContainer : MonoBehaviour
  {
    private Color[] _colors;
    private ColorChangerFactory _colorChangerFactory;
    private SyringePaint _syringePaint;
    private ColorChanger _currentSelectedColor;
    private readonly List<ColorChanger> _colorChangers = new();
    private Tween _unscaleTween;
    private Tween _scaleTween;

    [Inject]
    public void Construct(ColorChangerFactory colorChangerFactory)
    {
      _colorChangerFactory = colorChangerFactory;
    }

    public void Initialize(SyringePaint syringePaint, Color[] colors)
    {
      _syringePaint = syringePaint;
      _colors = colors;
      foreach (Color color in colors)
      {
        ColorChanger colorChanger = _colorChangerFactory.Create(transform).GetComponent<ColorChanger>();
        colorChanger.Initialize(_syringePaint, color);
        colorChanger.OnColorChange += OnColorChange;
        _colorChangers.Add(colorChanger);
      }

      InitStartColor();
    }

    private void OnDestroy()
    {
      _unscaleTween.Kill();
      _scaleTween.Kill();
      foreach (ColorChanger colorChanger in _colorChangers)
        colorChanger.OnColorChange -= OnColorChange;
    }

    private void InitStartColor()
    {
      _syringePaint.ChangeLiquidColor(_colors[0]);
      OnColorChange(_colorChangers[0]);
    }

    private void OnColorChange(ColorChanger colorChanger)
    {
      if (_currentSelectedColor == colorChanger)
        return;
      if (_currentSelectedColor != null)
        _unscaleTween = _currentSelectedColor.transform.DOScale(_currentSelectedColor.StartScale, _currentSelectedColor.ScalingTime);

      _scaleTween = colorChanger.transform.DOScale(colorChanger.SelectedScale, colorChanger.ScalingTime);

      _currentSelectedColor = colorChanger;
    }
  }
}