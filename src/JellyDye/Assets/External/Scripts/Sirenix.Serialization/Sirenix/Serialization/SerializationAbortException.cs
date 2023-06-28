using System;

namespace Sirenix.Serialization
{
	public class SerializationAbortException : Exception
	{
		public SerializationAbortException(string message)
		{
		}

		public SerializationAbortException(string message, Exception innerException)
		{
		}
	}
}
