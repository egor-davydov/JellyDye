using System.Collections.Generic;
using System.Linq;
using Code.Extensions;
using Code.Services.Factories.UI;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.UI.Hud.PaintChange
{
  public class JarsContainer : MonoBehaviour
  {
    private JarFactory _jarFactory;
    private Tween _unscaleTween;
    private Tween _scaleTween;
    private Jar _currentSelectedJar;

    [Inject]
    public void Construct(JarFactory jarFactory)
    {
      _jarFactory = jarFactory;
    }

    public List<Jar> Jars { get; private set; }
    public Color CurrentSelectedColor => _currentSelectedJar.Color;

    public async UniTaskVoid InitializeAndCreateJars(List<Color> allColors)
    {
      Jars = new List<Jar>(allColors.Count);
      allColors.Shuffle();
      foreach (Color color in allColors)
      {
        GameObject colorChangerPrefab = await _jarFactory.Create(transform);
        Jar jar = colorChangerPrefab.GetComponent<Jar>();
        jar.Initialize(color, this);
        Jars.Add(jar);
      }

      SelectFirstJar();
    }

    public void SelectFirstJar() =>
      Jars.First().Select();

    public void DeselectPreviousJar(Jar currentJar)
    {
      Jar previousJar = _currentSelectedJar;
      if (previousJar != null && previousJar != currentJar)
        previousJar.Deselect();
      _currentSelectedJar = currentJar;
    }
  }
}