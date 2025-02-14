using System;
using System.Linq;
using Code.Data;
using Code.Enums;

namespace Code.Services.Progress
{
  public class ProgressService
  {
    private readonly StaticDataService _staticData;

    public ProgressService(StaticDataService staticData)
    {
      _staticData = staticData;
    }

    public PlayerProgress Whole { get; set; }
    public SkinData ForSkins => Whole.SkinData;
    public LevelData ForLevels => Whole.LevelData;

    public void CreateAndSetStartProgress() =>
      Whole = CreateStartProgress();

    public PlayerProgress CreateStartProgress() =>
      new(_staticData.ForLevels.LevelConfigs.First().Id, Enum.GetValues(typeof(SkinType)).Length);
  }
}