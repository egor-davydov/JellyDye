using System;
using UnityEngine.Scripting;

namespace Code.InAppPurchases
{
  [Serializable]
  public class PurchasedProduct
  {
    [field: Preserve] public string ProductId;
  }
}