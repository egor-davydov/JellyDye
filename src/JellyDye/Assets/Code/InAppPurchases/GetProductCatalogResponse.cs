using System;
using UnityEngine.Scripting;

namespace Code.InAppPurchases
{
  [Serializable]
  public class GetProductCatalogResponse
  {
    [field: Preserve]
    public CatalogProduct[] Products;
  }
}