using UnityEngine;

namespace Code.Services.AssetManagement
{
  public class AddressablesAssetProvider : IAssetProvider
  {
    public T Load<T>(string assetPath) where T : Object
    {
      throw new System.NotImplementedException();
    }
  }
}