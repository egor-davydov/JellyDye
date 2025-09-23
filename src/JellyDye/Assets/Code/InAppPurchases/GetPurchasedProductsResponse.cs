using System;
using UnityEngine.Scripting;

namespace Code.InAppPurchases
{
  [Serializable]
  public class GetPurchasedProductsResponse
  {
    [field: Preserve] public PurchasedProduct[] PurchasedProducts;
  }
}