using System.Collections.Generic;
using System.Linq;
using Code.Extensions;
using Code.Services;
using Code.Services.Factories.UI;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using Zenject;

namespace Code.UI.Hud.PaintChange
{
  public class JarsContainer : MonoBehaviour
  {
    private JarFactory _jarFactory;
    private StaticDataService _staticData;
    private SyringeService _syringeService;

    private Tween _unscaleTween;
    private Tween _scaleTween;
    private Jar _currentSelectedJar;

    [Inject]
    public void Construct(JarFactory jarFactory, StaticDataService staticData, SyringeService syringeService)
    {
      _syringeService = syringeService;
      _staticData = staticData;
      _jarFactory = jarFactory;
    }

    public List<Jar> Jars { get; private set; }
    public Color CurrentSelectedColor => _currentSelectedJar.Color;

    public async UniTaskVoid InitializeAndCreateJars(string levelId)
    {
      List<Color> allColors = _staticData.ForLevel(levelId).AllColorsCached;
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

    public void ReShuffleJars()
    {
      Jars.Shuffle();
      for (var index = 0; index < Jars.Count; index++)
        Jars[index].transform.SetSiblingIndex(index);
    }

    public void DestroyJars()
    {
      foreach (Jar jar in Jars)
        Destroy(jar.gameObject);
    }

    public void SelectFirstJar() =>
      DeselectPreviousJarAndSelectCurrent(Jars.First());

    public void DeselectPreviousJarAndSelectCurrent(Jar jarToSelect)
    {
      _syringeService.ResetPistonAndLiquid();
      _syringeService.PlayResetSound();
      if (_currentSelectedJar == jarToSelect)
        return;
      if (_currentSelectedJar != null)
        _currentSelectedJar.Deselect();

      _currentSelectedJar = jarToSelect;
      _currentSelectedJar.Select();
    }
  }
}