using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Unity.Services.Analytics.Internal
{
	internal class Dispatcher : IDispatcher
	{
		private readonly IBuffer m_DataBuffer;

		private readonly IWebRequestHelper m_WebRequestHelper;

		internal readonly Dictionary<Guid, List<Buffer.Token>> Requests;

		public string CollectUrl
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private IConsentTracker ConsentTracker
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Dispatcher(IBuffer buffer, IWebRequestHelper webRequestHelper, IConsentTracker consentTracker = null)
		{
		}

		public Task Flush()
		{
			return null;
		}

		private byte[] SerializeBuffer(List<Buffer.Token> tokens)
		{
			return null;
		}

		private Task FlushBufferToService()
		{
			return null;
		}
	}
}
