using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;

[CreateAssetMenu]
public class GameConfig : SerializedScriptableObject
{
	private const string DIRECTORY = "Data/GameConfig";

	private static GameConfig _instance;

	[HideLabel]
	[OdinSerialize]
	public GameConfigModel Model;

	public AnimationCurve GravityCurve;

	public int LEVELID;

	public static GameConfig Instance => null;

	public static void LoadData()
	{
	}

	[Button]
	public static void LOADLEVEL()
	{
	}

	[Button]
	public void Reset()
	{
	}

	[Button]
	public static void SaveData()
	{
	}

	[Button]
	public void TakeScreenshot()
	{
	}
}
