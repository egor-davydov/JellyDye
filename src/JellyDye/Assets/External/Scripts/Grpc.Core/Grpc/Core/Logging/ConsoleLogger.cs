using System;

namespace Grpc.Core.Logging
{
	public class ConsoleLogger : TextWriterLogger
	{
		public ConsoleLogger()
			: base(null, null)
		{
		}

		private ConsoleLogger(Type forType)
			: base(null, null)
		{
		}

		public override ILogger ForType<T>()
		{
			return null;
		}
	}
}
