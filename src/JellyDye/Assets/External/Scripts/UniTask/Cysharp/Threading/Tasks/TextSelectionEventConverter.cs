using System;
using UnityEngine.Events;

namespace Cysharp.Threading.Tasks
{
	internal class TextSelectionEventConverter : UnityEvent<(string, int, int)>, IDisposable
	{
		private readonly UnityEvent<string, int, int> innerEvent;

		private readonly UnityAction<string, int, int> invokeDelegate;

		public TextSelectionEventConverter(UnityEvent<string, int, int> unityEvent)
		{
			((UnityEvent<T0>)(object)this)._002Ector();
		}

		private void InvokeCore(string item1, int item2, int item3)
		{
		}

		public void Dispose()
		{
		}
	}
}
