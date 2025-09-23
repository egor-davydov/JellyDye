using System;
using UnityEngine.Scripting;

namespace Code.InAppPurchases
{
  [Serializable]
  public class CatalogProduct
  {
    [field: Preserve] public string Id;
    [field: Preserve] public string PriceCurrencyImage;
    [field: Preserve] public string PriceValue;
  }
}