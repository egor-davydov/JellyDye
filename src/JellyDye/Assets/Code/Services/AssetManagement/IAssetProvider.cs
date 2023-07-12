using UnityEngine;

namespace Code.Services.AssetManagement
{
    public interface IAssetProvider
    {
        GameObject Load(string assetPath);
    }
}