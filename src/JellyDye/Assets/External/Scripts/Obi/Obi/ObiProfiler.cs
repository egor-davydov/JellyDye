using UnityEngine;

namespace Obi
{
	[DisallowMultipleComponent]
	public class ObiProfiler : MonoBehaviour
	{
		public GUISkin skin;

		public Color threadColor;

		public Color taskColor;

		public Color parallelTaskColor;

		public Color renderTaskColor;

		public Color defaultTaskColor;

		public bool showPercentages;

		public int profileThrottle;

		private Oni.ProfileInfo[] info;

		private double frameStart;

		private double frameEnd;

		private int frameCounter;

		private int yPos;

		private bool profiling;

		private float zoom;

		private Vector2 scrollPosition;

		private static ObiProfiler _instance;

		private void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public static void EnableProfiler()
		{
		}

		public static void DisableProfiler()
		{
		}

		public static void BeginSample(string name, byte type)
		{
		}

		public static void EndSample()
		{
		}

		private void UpdateProfilerInfo()
		{
		}

		public void OnGUI()
		{
		}
	}
}
