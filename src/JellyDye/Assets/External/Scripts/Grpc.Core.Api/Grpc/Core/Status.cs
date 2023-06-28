using System;
using System.Runtime.CompilerServices;

namespace Grpc.Core
{
	public struct Status
	{
		public static readonly Status DefaultSuccess;

		public static readonly Status DefaultCancelled;

		public StatusCode StatusCode
		{
			[CompilerGenerated]
			get
			{
				return default(StatusCode);
			}
		}

		public string Detail
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Exception DebugException
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Status(StatusCode statusCode, string detail)
		{
		}

		public Status(StatusCode statusCode, string detail, Exception debugException)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
