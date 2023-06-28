using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Firebase
{
	internal class FutureBool : FutureBase
	{
		public delegate void Action();

		internal delegate void SWIG_CompletionDelegate(int index);

		private HandleRef swigCPtr;

		private static Dictionary<int, Action> Callbacks;

		private static int CallbackIndex;

		private static object CallbackLock;

		private IntPtr callbackData;

		private SWIG_CompletionDelegate SWIG_CompletionCB;

		internal FutureBool(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public override void Dispose(bool disposing)
		{
		}

		public static Task<bool> GetTask(FutureBool fu)
		{
			return null;
		}

		private void ThrowIfDisposed()
		{
		}

		public void SetOnCompletionCallback(Action userCompletionCallback)
		{
		}

		private void SetCompletionData(IntPtr data)
		{
		}

		private static void SWIG_CompletionDispatcher(int key)
		{
		}

		internal IntPtr SWIG_OnCompletion(SWIG_CompletionDelegate cs_callback, int cs_key)
		{
			return (IntPtr)0;
		}

		public void SWIG_FreeCompletionData(IntPtr data)
		{
		}

		public bool GetResult()
		{
			return false;
		}
	}
}
