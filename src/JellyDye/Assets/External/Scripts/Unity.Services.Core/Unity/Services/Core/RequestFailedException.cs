using System;

namespace Unity.Services.Core
{
	public class RequestFailedException : Exception
	{
		public RequestFailedException(int errorCode, string message, Exception innerException)
		{
		}
	}
}
