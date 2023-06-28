using System.Collections;
using UnityEngine;

namespace SRF.Service
{
	public abstract class SRSceneServiceBase<T, TImpl> : SRServiceBase<T>, IAsyncService where T : class where TImpl : Component
	{
		private TImpl _rootObject;

		protected abstract string SceneName { get; }

		protected TImpl RootObject => null;

		public bool IsLoaded => false;

		private void Log(string msg, Object target)
		{
		}

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected virtual void OnLoaded()
		{
		}

		private IEnumerator LoadCoroutine()
		{
			return null;
		}

		protected SRSceneServiceBase()
		{
			((SRServiceBase<>)(object)this)._002Ector();
		}
	}
}
