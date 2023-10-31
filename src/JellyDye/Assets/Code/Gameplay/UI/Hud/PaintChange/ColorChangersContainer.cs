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
    private SyringePaintColor _syringePaintColor;
    private ColorChanger _currentSelectedColor;
    private readonly List<ColorChanger> _colorChangers = new();
    private Tween _unscaleTween;
    private Tween _scaleTween;

    [Inject]
    public void Construct(ColorChangerFactory colorChangerFactory)
    {
      _colorChangerFactory = colorChangerFactory;
    }

    public void Initialize(SyringePaintColor syringePaintColor, Color[] colors)
    {
      _syringePaintColor = syringePaintColor;
      _colors = Shuffle(colors);
      foreach (Color color in colors)
      {
        ColorChanger colorChanger = _colorChangerFactory.Create(transform).GetComponent<ColorChanger>();
        colorChanger.Initialize(_syringePaintColor, color);
        colorChanger.OnColorChange += OnColorChange;
        _colorChangers.Add(colorChanger);
      }

      InitStartColor();
    }

    private Color[] Shuffle(Color[] colors)
    {
      for (int i = colors.Length - 1; i >= 1; i--)
      {
        int j = Random.Range(0, i + 1);
        (colors[j], colors[i]) = (colors[i], colors[j]);
      }

      return colors;
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
      _syringePaintColor.ChangeLiquidColor(_colors[0]);
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