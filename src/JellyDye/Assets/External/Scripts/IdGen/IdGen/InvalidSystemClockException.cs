using System;

namespace IdGen
{
	public class InvalidSystemClockException : Exception
	{
		public InvalidSystemClockException(string message)
		{
		}

		public InvalidSystemClockException(string message, Exception innerException)
		{
		}
	}
}
