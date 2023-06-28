using System.Dynamic;

namespace Newtonsoft.Json.Utilities
{
	internal class NoThrowSetBinderMember : SetMemberBinder
	{
		private readonly SetMemberBinder _innerBinder;

		public NoThrowSetBinderMember(SetMemberBinder innerBinder)
			: base(null, ignoreCase: false)
		{
		}

		public override DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion)
		{
			return null;
		}
	}
}
