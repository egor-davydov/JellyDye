using Code.Enums;
using Code.Gameplay.Syringe;
using Code.Services.Factories;
using Code.Services.Progress;
using Code.Services.Providers;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Code.Services
{
  public class SyringeService
  {
    private readonly SyringeFactory _syringeFactory;
    private readonly SyringeProvider _syringeProvider;
    private readonly HudProvider _hudProvider;
    private readonly ProgressService _progress;
    private readonly StaticDataService _staticData;

    public SyringeService(SyringeFactory syringeFactory, SyringeProvider syringeProvider, HudProvider hudProvider,
      ProgressService progress, StaticDataService staticData)
    {
      _hudProvider = hudProvider;
      _progress = progress;
      _staticData = staticData;
      _syringeProvider = syringeProvider;
      _syringeFactory = syringeFactory;
    }

    public async UniTask SwapSkinIfChanged()
    {
      if (IsSkinChanged())
        await SwapSkin(_progress.ForSkins.EquippedSkin);
    }

    public void ResetSyringe()
    {
      MoveToStart();
      ResetPistonAndLiquid();
    }

    public async UniTask ReplaceSkinIfChanged()
    {
      if (IsSkinChanged() && IsSyringeActive())
      {
        Vector3 previousSyringePosition = _syringeProvider.SyringeObject.transform.position;
        Syringe swapedSkin = await SwapSkin(_progress.ForSkins.EquippedSkin);
        swapedSkin.transform.position = previousSyringePosition;
        SetCurrentJarColor();
        ResetPistonAndLiquid();
      }
    }

    public void PlayResetSound() =>
      _syringeProvider.SyringeAudio.PlayReset();

    public void ResetPistonAndLiquid() =>
      _syringeProvider.SyringePistonAndLiquid.ResetEither().Forget();

    public void SetColorAndPlaySound(Color color)
    {
      _syringeProvider.SyringeLiquidColor.ChangeLiquidColor(color);
      PlayResetSound();
    }

    private void SetCurrentJarColor()
    {
      Color currentSelectedColor = _hudProvider.JarsContainer.CurrentSelectedColor;
      SetColorAndPlaySound(currentSelectedColor);
    }

    private void MoveToStart() =>
      _syringeProvider.Syringe.transform.position = _staticData.ForLevels.SyringeStartPosition;

    private async UniTask<Syringe> SwapSkin(SkinType skinType)
    {
      Transform previousSyringeTransform = _syringeProvider.SyringeObject.transform;
      Syringe syringe = await _syringeFactory.Create(skinType, previousSyringeTransform.parent);
      Object.Destroy(_syringeProvider.SyringeObject);
      _syringeProvider.Initialize(syringe);
      _syringeProvider.Syringe.Initialize(_hudProvider.InjectionButton);
      return syringe;
    }

    private bool IsSyringeActive() =>
      _syringeProvider.SyringeObject.activeSelf;

    private bool IsSkinChanged() =>
      _progress.ForSkins.EquippedSkin != _syringeProvider.Syringe.SkinType;
  }
}