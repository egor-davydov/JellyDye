using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.Services.Core
{
	public class InitializationOptions
	{
		internal IDictionary<string, object> Values
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public InitializationOptions()
		{
		}

		internal InitializationOptions(IDictionary<string, object> values)
		{
		}

		internal InitializationOptions(InitializationOptions source)
		{
		}

		public InitializationOptions SetOption(string key, string value)
		{
			return null;
		}
	}
}
