using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	public class AccessToken
	{
		public static AccessToken CurrentAccessToken
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public string TokenString
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

		public DateTime ExpirationTime
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public IEnumerable<string> Permissions
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

		public string UserId
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

		public DateTime? LastRefresh
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

		public string GraphDomain
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

		internal AccessToken(string tokenString, string userId, DateTime expirationTime, IEnumerable<string> permissions, DateTime? lastRefresh, string graphDomain)
		{
		}

		public override string ToString()
		{
			return null;
		}

		internal string ToJson()
		{
			return null;
		}
	}
}
