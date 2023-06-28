using System.Dynamic;

namespace Newtonsoft.Json.Utilities
{
	internal class NoThrowGetBinderMember : GetMemberBinder
	{
		private readonly GetMemberBinder _innerBinder;

		public NoThrowGetBinderMember(GetMemberBinder innerBinder)
			: base(null, ignoreCase: false)
		{
		}

		public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion)
		{
			return null;
		}
	}
}
