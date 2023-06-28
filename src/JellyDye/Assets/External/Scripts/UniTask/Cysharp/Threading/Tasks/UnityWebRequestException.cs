using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace Cysharp.Threading.Tasks
{
	public class UnityWebRequestException : Exception
	{
		private string msg;

		public UnityWebRequest UnityWebRequest
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public UnityWebRequest.Result Result
		{
			[CompilerGenerated]
			get
			{
				return default(UnityWebRequest.Result);
			}
		}

		public string Error
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string Text
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public long ResponseCode
		{
			[CompilerGenerated]
			get
			{
				return 0L;
			}
		}

		public Dictionary<string, string> ResponseHeaders
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public override string Message => null;

		public UnityWebRequestException(UnityWebRequest unityWebRequest)
		{
		}
	}
}
