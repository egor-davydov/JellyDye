using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu]
public class MarketingData : SerializedScriptableObject
{
	private const string DIRECTORY = "Data/MarketingData";

	private static MarketingData _instance;

	public static MarketingData Instance => null;
}
