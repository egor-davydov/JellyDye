using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal class LoginStatusResult : LoginResult, ILoginStatusResult, ILoginResult, IResult
	{
		public static readonly string FailedKey;

		public bool Failed
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal LoginStatusResult(ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
