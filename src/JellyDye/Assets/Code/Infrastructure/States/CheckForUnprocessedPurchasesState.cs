using System.Threading.Tasks;
using Code.Enums;
using Code.InAppPurchases;
using Code.Infrastructure.States.Interfaces;
using Code.Logging;
using Code.Services;
using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;
using Cysharp.Threading.Tasks;

namespace Code.Infrastructure.States
{
  public class CheckForUnprocessedPurchasesState : IState
  {
    private readonly GameStateMachine _stateMachine;
    private readonly PublishService _publishService;
    private readonly ProgressService _progress;
    private readonly ISaveLoadService _saveLoadService;

    public CheckForUnprocessedPurchasesState(GameStateMachine stateMachine, PublishService publishService,
      ProgressService progress, ISaveLoadService saveLoadService)
    {
      _saveLoadService = saveLoadService;
      _stateMachine = stateMachine;
      _publishService = publishService;
      _progress = progress;
    }
    public async UniTaskVoid Enter()
    {
      if(_publishService.IsOnYandexGames())
        await ValidatePurchases();
      MoveNextState();
    }

    private async UniTask ValidatePurchases()
    {
      PurchasedProduct[] purchasedProducts = await _publishService.GetPurchases();
      bool isValid = true;
      foreach (PurchasedProduct purchasedProduct in purchasedProducts)
      {
        SkinType observableSkinType = _publishService.ProductIdToSkinType(purchasedProduct.ProductId);
        if (IsPlayerDontHaveInProgressPurchasedSkin(observableSkinType))
        {
          WebDebug.Log($"Skin \"{purchasedProduct.ProductId}\" has already been purchased.");
          _progress.ForSkins.OpenSkin(observableSkinType);
          isValid = false;
        }
      }
      if(!isValid)
        _saveLoadService.SaveProgress();
    }

    private bool IsPlayerDontHaveInProgressPurchasedSkin(SkinType skinType) => 
      _progress.ForSkins.IsPlayerHaveSkin(skinType) == false;

    private void MoveNextState()
    {
      _stateMachine.Enter<WarmUpState>();
    }

    public UniTaskVoid Exit()
    {
      return default;
    }
  }
}