using UnityEngine;
using UnityEngine.Events;

namespace CodeStage.AntiCheat.Detectors
{
	public abstract class ActDetectorBase : MonoBehaviour
	{
		protected const string CONTAINER_NAME = "Anti-Cheat Toolkit Detectors";

		protected const string MENU_PATH = "Code Stage/Anti-Cheat Toolkit/";

		protected const string GAME_OBJECT_MENU_PATH = "GameObject/Create Other/Code Stage/Anti-Cheat Toolkit/";

		protected static GameObject detectorsContainer;

		public bool autoStart;

		public bool keepAlive;

		public bool autoDispose;

		[SerializeField]
		protected UnityEvent detectionEvent;

		protected UnityAction detectionAction;

		[SerializeField]
		protected bool detectionEventHasListener;

		protected bool isRunning;

		protected bool started;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnApplicationQuit()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual bool Init(ActDetectorBase instance, string detectorName)
		{
			return false;
		}

		protected virtual void DisposeInternal()
		{
		}

		protected virtual bool DetectorHasAdditionalCallbacks()
		{
			return false;
		}

		internal virtual void OnCheatingDetected()
		{
		}

		protected abstract void StartDetectionAutomatically();

		protected abstract void StopDetectionInternal();

		protected abstract void PauseDetector();

		protected abstract void ResumeDetector();
	}
}
