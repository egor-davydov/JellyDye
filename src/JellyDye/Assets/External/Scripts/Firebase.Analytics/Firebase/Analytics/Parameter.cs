using System;
using System.Runtime.InteropServices;

namespace Firebase.Analytics
{
	public sealed class Parameter : IDisposable
	{
		private HandleRef swigCPtr;

		private bool swigCMemOwn;

		internal Parameter(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(Parameter obj)
		{
			return default(HandleRef);
		}

		~Parameter()
		{
		}

		public void Dispose()
		{
		}

		public void Dispose(bool disposing)
		{
		}

		public Parameter(string parameterName, string parameterValue)
		{
		}

		public Parameter(string parameterName, long parameterValue)
		{
		}

		public Parameter(string parameterName, double parameterValue)
		{
		}
	}
}
