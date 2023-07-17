using UnityEngine;

namespace Code.Services.AssetManagement
{
    public class AssetProvider : IAssetProvider
    {
        public GameObject Load(string assetPath) =>
            Resources.Load<GameObject>(assetPath);
    }
}