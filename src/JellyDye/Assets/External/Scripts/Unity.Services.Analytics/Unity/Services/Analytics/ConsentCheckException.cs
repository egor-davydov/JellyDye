using System;
using System.Runtime.CompilerServices;
using Unity.Services.Core;
using UnityEngine.Scripting;

namespace Unity.Services.Analytics
{
	public class ConsentCheckException : RequestFailedException
	{
		[Preserve]
		public ConsentCheckExceptionReason Reason
		{
			[CompilerGenerated]
			get
			{
				return default(ConsentCheckExceptionReason);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ConsentCheckException(ConsentCheckExceptionReason reason, int errorCode, string message, Exception innerException)
			: base(0, null, null)
		{
		}
	}
}
