using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal class AccessTokenRefreshResult : ResultBase, IAccessTokenRefreshResult, IResult
	{
		public AccessToken AccessToken
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

		public AccessTokenRefreshResult(ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
