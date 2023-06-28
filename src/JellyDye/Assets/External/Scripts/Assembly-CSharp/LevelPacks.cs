using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu]
public class LevelPacks : SerializedScriptableObject
{
	private const string DIRECTORY = "Data/LevelPacks";

	private static LevelPacks _instance;

	public List<LevelPack> Packs;

	public static LevelPacks Instance => null;

	[Button]
	public void ALO()
	{
	}

	public static void LoadData()
	{
	}

	[Button]
	public static void SaveData()
	{
	}
}
