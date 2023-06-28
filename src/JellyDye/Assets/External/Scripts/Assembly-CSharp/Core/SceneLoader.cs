using System.Threading.Tasks;
using UnityEngine;

namespace Core
{
	public class SceneLoader : MonoBehaviour
	{
		protected bool IsReady;

		private float _timer;

		private bool _isCompleted;

		private bool _isRemoteFetched;

		private int sb;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void AdsRequested()
		{
		}

		private void Start()
		{
		}

		private void OnFirebaseReady()
		{
		}

		private void Update()
		{
		}

		public void InitializeFirebase()
		{
		}

		public Task FetchDataAsync()
		{
			return null;
		}

		private void FetchComplete(Task fetchTask)
		{
		}

		private void ChangeScene()
		{
		}
	}
}
