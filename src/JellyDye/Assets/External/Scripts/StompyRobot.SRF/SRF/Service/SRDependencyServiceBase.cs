using System;
using System.Collections;
using UnityEngine;

namespace SRF.Service
{
	public abstract class SRDependencyServiceBase<T> : SRServiceBase<T>, IAsyncService where T : class
	{
		private bool _isLoaded;

		protected abstract Type[] Dependencies { get; }

		public bool IsLoaded => false;

		private void Log(string msg, UnityEngine.Object target)
		{
		}

		protected override void Start()
		{
		}

		protected virtual void OnLoaded()
		{
		}

		private IEnumerator LoadDependencies()
		{
			return null;
		}

		protected SRDependencyServiceBase()
		{
			((SRServiceBase<>)(object)this)._002Ector();
		}
	}
}
