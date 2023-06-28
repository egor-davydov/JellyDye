using System.Text;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

namespace CodeStage.AntiCheat.Examples
{
	public class ActTesterGui : MonoBehaviour
	{
		private const string RED_COLOR = "#FF4040";

		private const string GREEN_COLOR = "#02C85F";

		private const string PREFS_STRING = "name";

		private const string PREFS_INT = "money";

		private const string PREFS_FLOAT = "lifeBar";

		private const string PREFS_BOOL = "gameComplete";

		private const string PREFS_UINT = "demoUint";

		private const string PREFS_LONG = "demoLong";

		private const string PREFS_DOUBLE = "demoDouble";

		private const string PREFS_VECTOR2 = "demoVector2";

		private const string PREFS_VECTOR3 = "demoVector3";

		private const string PREFS_QUATERNION = "demoQuaternion";

		private const string PREFS_RECT = "demoRect";

		private const string PREFS_COLOR = "demoColor";

		private const string PREFS_BYTE_ARRAY = "demoByteArray";

		private const string API_URL_LOCK_TO_DEVICE = "http://j.mp/1gxg1tf";

		private const string API_URL_PRESERVE_PREFS = "http://j.mp/1iBK5pz";

		private const string API_URL_EMERGENCY_MODE = "http://j.mp/1FRAL5L";

		private const string API_URL_READ_FOREIGN = "http://j.mp/1LCdpDa";

		private const string API_URL_UNOBSCURED_MODE = "http://j.mp/1KVrpxi";

		private const string API_URL_PLAYER_PREFS = "http://docs.unity3d.com/ScriptReference/PlayerPrefs.html";

		public string regularString;

		public int regularInt;

		public float regularFloat;

		public Vector3 regularVector3;

		public ObscuredString obscuredString;

		public ObscuredInt obscuredInt;

		public ObscuredFloat obscuredFloat;

		public ObscuredVector3 obscuredVector3;

		public ObscuredBool obscuredBool;

		public ObscuredLong obscuredLong;

		public ObscuredDouble obscuredDouble;

		public ObscuredVector2 obscuredVector2;

		public string prefsEncryptionKey;

		private readonly string[] tabs;

		private int currentTab;

		private string allSimpleObscuredTypes;

		private string regularPrefs;

		private string obscuredPrefs;

		private int savesLock;

		private bool savesAlterationDetected;

		private bool foreignSavesDetected;

		private bool injectionDetected;

		private bool speedHackDetected;

		private bool timeCheatingDetected;

		private bool obscuredTypeCheatDetected;

		private bool wallHackCheatDetected;

		private readonly StringBuilder logBuilder;

		public void OnSpeedHackDetected()
		{
		}

		public void OnTimeCheatingDetected()
		{
		}

		public void OnInjectionDetected()
		{
		}

		public void OnInjectionDetectedWithCause(string cause)
		{
		}

		public void OnObscuredTypeCheatingDetected()
		{
		}

		public void OnWallHackDetected()
		{
		}

		private void OnValidate()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void RandomizeObscuredVars()
		{
		}

		private void ObscuredStringExample()
		{
		}

		private void ObscuredIntExample()
		{
		}

		private void ObscuredFloatExample()
		{
		}

		private void ObscuredVector3Example()
		{
		}

		private void SavesAlterationDetected()
		{
		}

		private void ForeignSavesDetected()
		{
		}

		private void OnGUI()
		{
		}

		private string GetAllSimpleObscuredTypes()
		{
			return null;
		}

		private string GetAllObscuredPrefsDataTypes()
		{
			return null;
		}

		private void LoadRegularPrefs()
		{
		}

		private void SaveRegularPrefs()
		{
		}

		private void DeleteRegularPrefs()
		{
		}

		private void LoadObscuredPrefs()
		{
		}

		private void SaveObscuredPrefs()
		{
		}

		private void DeleteObscuredPrefs()
		{
		}

		private void PlaceUrlButton(string url)
		{
		}

		private void PlaceUrlButton(string url, int width)
		{
		}

		private void PlaceUrlButton(string url, string buttonName, int width)
		{
		}

		private void OnApplicationQuit()
		{
		}
	}
}
