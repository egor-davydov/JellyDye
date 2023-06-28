using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Firebase.RemoteConfig
{
	public struct ConfigValue
	{
		internal static Regex booleanTruePattern;

		internal static Regex booleanFalsePattern;

		public string StringValue => null;

		internal byte[] Data
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

		internal ValueSource Source
		{
			[CompilerGenerated]
			set
			{
			}
		}

		internal ConfigValue(byte[] data, ValueSource source)
		{
		}
	}
}
