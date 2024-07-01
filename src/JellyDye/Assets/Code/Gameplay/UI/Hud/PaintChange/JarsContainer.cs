using System.Collections.Generic;
using Code.Services.Factories.UI;
using Code.Services.Providers;
using DG.Tweening;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.UI.Hud.PaintChange
{
  public class JarsContainer : MonoBehaviour
  {
    private JarFactory _jarFactory;
    private readonly List<Jar> _colorChangers = new();
    private Tween _unscaleTween;
    private Tween _scaleTween;
    private Jar _currentSelectedJar;
    private SyringeProvider _syringeProvider;

    public Color CurrentSelectedColor => _currentSelectedJar.Color;

    [Inject]
    public void Construct(JarFactory jarFactory, SyringeProvider syringeProvider)
    {
      _syringeProvider = syringeProvider;
      _jarFactory = jarFactory;
    }

    public async void Initialize(List<Color> allColors)
    {
      List<Color> shuffledColors = Shuffle(allColors);
      foreach (Color color in shuffledColors)
      {
        GameObject colorChangerPrefab = await _jarFactory.Create(transform);
        Jar jar = colorChangerPrefab.GetComponent<Jar>();
        jar.Initialize(_syringeProvider, color);
        jar.OnColorChange += OnColorChange;
        _colorChangers.Add(jar);
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
      foreach (Jar colorChanger in _colorChangers)
        colorChanger.OnColorChange -= OnColorChange;
    }

    private void InitStartColor(List<Color> colors)
    {
      _syringeProvider.SyringePaintColor.ChangeLiquidColor(colors[0]);
      OnColorChange(_colorChangers[0]);
    }

    private void OnColorChange(Jar jar)
    {
      if (_currentSelectedJar == jar)
        return;
      if (_currentSelectedJar != null)
        _unscaleTween = _currentSelectedJar.transform.DOScale(_currentSelectedJar.StartScale, _currentSelectedJar.ScalingTime);

      _scaleTween = jar.transform.DOScale(jar.SelectedScale, jar.ScalingTime);

      _currentSelectedJar = jar;
    }
  }
}