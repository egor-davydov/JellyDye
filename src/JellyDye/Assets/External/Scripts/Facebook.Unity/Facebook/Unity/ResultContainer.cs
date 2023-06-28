using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal class ResultContainer
	{
		private const string CanvasResponseKey = "response";

		public string RawResult
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public IDictionary<string, object> ResultDictionary
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

		public ResultContainer(IDictionary<string, object> dictionary)
		{
		}

		public ResultContainer(string result)
		{
		}

		private IDictionary<string, object> GetWebFormattedResponseDictionary(IDictionary<string, object> resultDictionary)
		{
			return null;
		}
	}
}
