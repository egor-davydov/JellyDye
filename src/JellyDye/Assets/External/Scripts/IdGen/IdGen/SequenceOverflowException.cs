using System;

namespace IdGen
{
	public class SequenceOverflowException : Exception
	{
		public SequenceOverflowException(string message)
		{
		}

		public SequenceOverflowException(string message, Exception innerException)
		{
		}
	}
}
