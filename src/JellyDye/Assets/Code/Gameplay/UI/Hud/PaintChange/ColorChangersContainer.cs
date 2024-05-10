using System.Collections.Generic;
using System.Linq;
using Code.Gameplay.Syringe;
using Code.Services.Factories.UI;
using DG.Tweening;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.UI.Hud.PaintChange
{
  public class ColorChangersContainer : MonoBehaviour
  {
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

    public async void Initialize(SyringePaintColor syringePaintColor, List<Color> allColors)
    {
      _syringePaintColor = syringePaintColor;
      List<Color> shuffledColors = Shuffle(allColors);
      foreach (Color color in shuffledColors)
      {
        GameObject colorChangerPrefab = await _colorChangerFactory.Create(transform);
        ColorChanger colorChanger = colorChangerPrefab.GetComponent<ColorChanger>();
        colorChanger.Initialize(_syringePaintColor, color);
        colorChanger.OnColorChange += OnColorChange;
        _colorChangers.Add(colorChanger);
      }

      InitStartColor(shuffledColors);
    }

    private List<Color> Shuffle(List<Color> colors)
    {
      for (int i = colors.Count - 1; i >= 1; i--)
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

    private void InitStartColor(List<Color> colors)
    {
      _syringePaintColor.ChangeLiquidColor(colors[0]);
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