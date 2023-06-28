using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : SerializedScriptableObject
{
	private const string DIRECTORY = "Data/PlayerData";

	private static PlayerData _instance;

	[HideLabel]
	public PlayerDataModel Model;

	public static PlayerData Instance => null;

	public static void LoadData()
	{
	}

	[Button]
	public static void SaveData()
	{
	}

	[Button]
	public void Reset()
	{
	}
}
