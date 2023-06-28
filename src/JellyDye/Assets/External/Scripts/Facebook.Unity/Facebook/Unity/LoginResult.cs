using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal class LoginResult : ResultBase, ILoginResult, IResult
	{
		public static readonly string UserIdKey;

		public static readonly string ExpirationTimestampKey;

		public static readonly string PermissionsKey;

		public static readonly string AccessTokenKey;

		public static readonly string GraphDomain;

		public static readonly string AuthTokenString;

		public static readonly string AuthNonce;

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

		public AuthenticationToken AuthenticationToken
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

		internal LoginResult(ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
