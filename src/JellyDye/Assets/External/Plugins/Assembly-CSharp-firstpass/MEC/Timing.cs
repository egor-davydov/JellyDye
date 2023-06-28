using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

namespace MEC
{
	public class Timing : MonoBehaviour
	{
		private struct ProcessIndex : IEquatable<ProcessIndex>
		{
			public Segment seg;

			public int i;

			public bool Equals(ProcessIndex other)
			{
				return false;
			}

			public override bool Equals(object other)
			{
				return false;
			}

			public static bool operator ==(ProcessIndex a, ProcessIndex b)
			{
				return false;
			}

			public static bool operator !=(ProcessIndex a, ProcessIndex b)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		public float TimeBetweenSlowUpdateCalls;

		public DebugInfoType ProfilerDebugAmount;

		[Space]
		public int UpdateCoroutines;

		public int FixedUpdateCoroutines;

		public int LateUpdateCoroutines;

		public int SlowUpdateCoroutines;

		[NonSerialized]
		public float localTime;

		[NonSerialized]
		public float deltaTime;

		public static Func<IEnumerator<float>, CoroutineHandle, IEnumerator<float>> ReplacementFunction;

		public const float WaitForOneFrame = 0f;

		private static object _tmpRef;

		private static bool _tmpBool;

		private static CoroutineHandle _tmpHandle;

		private int _currentUpdateFrame;

		private int _currentLateUpdateFrame;

		private int _currentSlowUpdateFrame;

		private int _nextUpdateProcessSlot;

		private int _nextLateUpdateProcessSlot;

		private int _nextFixedUpdateProcessSlot;

		private int _nextSlowUpdateProcessSlot;

		private int _lastUpdateProcessSlot;

		private int _lastLateUpdateProcessSlot;

		private int _lastFixedUpdateProcessSlot;

		private int _lastSlowUpdateProcessSlot;

		private float _lastUpdateTime;

		private float _lastLateUpdateTime;

		private float _lastFixedUpdateTime;

		private float _lastSlowUpdateTime;

		private float _lastSlowUpdateDeltaTime;

		private ushort _framesSinceUpdate;

		private ushort _expansions;

		private byte _instanceID;

		private readonly Dictionary<CoroutineHandle, HashSet<CoroutineHandle>> _waitingTriggers;

		private readonly HashSet<CoroutineHandle> _allWaiting;

		private readonly Dictionary<CoroutineHandle, ProcessIndex> _handleToIndex;

		private readonly Dictionary<ProcessIndex, CoroutineHandle> _indexToHandle;

		private readonly Dictionary<CoroutineHandle, string> _processTags;

		private readonly Dictionary<string, HashSet<CoroutineHandle>> _taggedProcesses;

		private IEnumerator<float>[] UpdateProcesses;

		private IEnumerator<float>[] LateUpdateProcesses;

		private IEnumerator<float>[] FixedUpdateProcesses;

		private IEnumerator<float>[] SlowUpdateProcesses;

		private bool[] UpdatePaused;

		private bool[] LateUpdatePaused;

		private bool[] FixedUpdatePaused;

		private bool[] SlowUpdatePaused;

		private const ushort FramesUntilMaintenance = 64;

		private const int ProcessArrayChunkSize = 64;

		private const int InitialBufferSizeLarge = 256;

		private const int InitialBufferSizeMedium = 64;

		private const int InitialBufferSizeSmall = 8;

		private static readonly Dictionary<byte, Timing> ActiveInstances;

		private static Timing _instance;

		public static float LocalTime => 0f;

		public static float DeltaTime => 0f;

		public static Thread MainThread
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static Timing Instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static event Action OnPreExecute
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		private void RemoveUnused()
		{
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		private CoroutineHandle RunCoroutineInternal(IEnumerator<float> coroutine, Segment segment, string tag, CoroutineHandle handle, bool prewarm)
		{
			return default(CoroutineHandle);
		}

		public static int KillCoroutines()
		{
			return 0;
		}

		public int KillCoroutinesOnInstance()
		{
			return 0;
		}

		public static int KillCoroutines(CoroutineHandle handle)
		{
			return 0;
		}

		public int KillCoroutinesOnInstance(CoroutineHandle handle)
		{
			return 0;
		}

		public static int KillCoroutines(string tag)
		{
			return 0;
		}

		public int KillCoroutinesOnInstance(string tag)
		{
			return 0;
		}

		public static int PauseCoroutines()
		{
			return 0;
		}

		public int PauseCoroutinesOnInstance()
		{
			return 0;
		}

		public static int PauseCoroutines(CoroutineHandle handle)
		{
			return 0;
		}

		public int PauseCoroutinesOnInstance(CoroutineHandle handle)
		{
			return 0;
		}

		public static int PauseCoroutines(string tag)
		{
			return 0;
		}

		public int PauseCoroutinesOnInstance(string tag)
		{
			return 0;
		}

		public static int ResumeCoroutines()
		{
			return 0;
		}

		public int ResumeCoroutinesOnInstance()
		{
			return 0;
		}

		public static int ResumeCoroutines(CoroutineHandle handle)
		{
			return 0;
		}

		public int ResumeCoroutinesOnInstance(CoroutineHandle handle)
		{
			return 0;
		}

		public static int ResumeCoroutines(string tag)
		{
			return 0;
		}

		public int ResumeCoroutinesOnInstance(string tag)
		{
			return 0;
		}

		private bool UpdateTimeValues(Segment segment)
		{
			return false;
		}

		private float GetSegmentTime(Segment segment)
		{
			return 0f;
		}

		public static Timing GetInstance(byte ID)
		{
			return null;
		}

		private void AddTag(string tag, CoroutineHandle coindex)
		{
		}

		private void RemoveTag(CoroutineHandle coindex)
		{
		}

		private bool Nullify(ProcessIndex coindex)
		{
			return false;
		}

		private IEnumerator<float> CoindexExtract(ProcessIndex coindex)
		{
			return null;
		}

		private IEnumerator<float> CoindexPeek(ProcessIndex coindex)
		{
			return null;
		}

		private bool CoindexIsNull(ProcessIndex coindex)
		{
			return false;
		}

		private bool SetPause(ProcessIndex coindex, bool newPausedState = true)
		{
			return false;
		}

		private IEnumerator<float> CreatePause(ProcessIndex coindex, IEnumerator<float> coptr, bool newPausedState = true)
		{
			return null;
		}

		private IEnumerator<float> _InjectDelay(IEnumerator<float> proc, float delayTime)
		{
			return null;
		}

		private void CoindexReplace(ProcessIndex coindex, IEnumerator<float> replacement)
		{
		}

		public static float WaitForSeconds(float waitTime)
		{
			return 0f;
		}

		public float WaitForSecondsOnInstance(float waitTime)
		{
			return 0f;
		}

		public static float WaitUntilDone(CoroutineHandle otherCoroutine)
		{
			return 0f;
		}

		public static float WaitUntilDone(CoroutineHandle otherCoroutine, bool warnOnIssue)
		{
			return 0f;
		}

		private IEnumerator<float> WaitUntilDoneWrapper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		private IEnumerator<float> _StartWhenDone(CoroutineHandle handle, IEnumerator<float> proc)
		{
			return null;
		}

		private void CloseWaitingProcess(CoroutineHandle handle)
		{
		}

		private bool HandleIsInWaitingList(CoroutineHandle handle)
		{
			return false;
		}

		private static IEnumerator<float> ReturnTmpRefForRepFunc(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		public static float WaitUntilDone(WWW wwwObject)
		{
			return 0f;
		}

		private static IEnumerator<float> WaitUntilDoneWwwHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		private static IEnumerator<float> _StartWhenDone(WWW www, IEnumerator<float> pausedProc)
		{
			return null;
		}

		public static float WaitUntilDone(AsyncOperation operation)
		{
			return 0f;
		}

		private static IEnumerator<float> WaitUntilDoneAscOpHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		private static IEnumerator<float> _StartWhenDone(AsyncOperation operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		public static float WaitUntilDone(CustomYieldInstruction operation)
		{
			return 0f;
		}

		private static IEnumerator<float> WaitUntilDoneCustYieldHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		private static IEnumerator<float> _StartWhenDone(CustomYieldInstruction operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		public bool LockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return false;
		}

		public bool UnlockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return false;
		}

		public static CoroutineHandle CallDelayed(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallDelayedOnInstance(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallDelayed(float delay, Action action, GameObject cancelWith)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallDelayedOnInstance(float delay, Action action, GameObject cancelWith)
		{
			return default(CoroutineHandle);
		}

		private IEnumerator<float> _DelayedCall(float delay, Action action, GameObject cancelWith)
		{
			return null;
		}

		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment segment, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment segment, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallContinuously(float timeframe, Action action, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		private IEnumerator<float> _CallContinuously(float timeframe, float period, Action action, Action onDone)
		{
			return null;
		}

		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		private IEnumerator<float> _CallContinuously<T>(T reference, float timeframe, float period, Action<T> action, Action<T> onDone = null)
		{
			return null;
		}

		[Obsolete]
		public new Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		[Obsolete]
		public new Coroutine StartCoroutine(string methodName, object value)
		{
			return null;
		}

		[Obsolete]
		public new Coroutine StartCoroutine(string methodName)
		{
			return null;
		}

		[Obsolete]
		public new Coroutine StartCoroutine_Auto(IEnumerator routine)
		{
			return null;
		}

		[Obsolete]
		public new void StopCoroutine(string methodName)
		{
		}

		[Obsolete]
		public new void StopCoroutine(IEnumerator routine)
		{
		}

		[Obsolete]
		public new void StopCoroutine(Coroutine routine)
		{
		}

		[Obsolete]
		public new void StopAllCoroutines()
		{
		}

		[Obsolete]
		public new static void Destroy(UnityEngine.Object obj)
		{
		}

		[Obsolete]
		public new static void Destroy(UnityEngine.Object obj, float f)
		{
		}

		[Obsolete]
		public static void DestroyObject(UnityEngine.Object obj)
		{
		}

		[Obsolete]
		public static void DestroyObject(UnityEngine.Object obj, float f)
		{
		}

		[Obsolete]
		public new static void DestroyImmediate(UnityEngine.Object obj)
		{
		}

		[Obsolete]
		public new static void DestroyImmediate(UnityEngine.Object obj, bool b)
		{
		}

		[Obsolete]
		public new static void Instantiate(UnityEngine.Object obj)
		{
		}

		[Obsolete]
		public new static void Instantiate(UnityEngine.Object original, Vector3 position, Quaternion rotation)
		{
		}

		[Obsolete]
		public new static void Instantiate<T>(T original) where T : UnityEngine.Object
		{
		}

		[Obsolete]
		public new static T FindObjectOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Obsolete]
		public new static UnityEngine.Object FindObjectOfType(Type t)
		{
			return null;
		}

		[Obsolete]
		public new static T[] FindObjectsOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Obsolete]
		public new static UnityEngine.Object[] FindObjectsOfType(Type t)
		{
			return null;
		}

		[Obsolete]
		public new static void print(object message)
		{
		}
	}
}
