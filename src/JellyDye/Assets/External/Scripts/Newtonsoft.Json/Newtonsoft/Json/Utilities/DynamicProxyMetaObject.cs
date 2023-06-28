using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;

namespace Newtonsoft.Json.Utilities
{
	internal sealed class DynamicProxyMetaObject<T> : DynamicMetaObject
	{
		private delegate DynamicMetaObject Fallback(DynamicMetaObject errorSuggestion);

		private readonly DynamicProxy<T> _proxy;

		private static Expression[] NoArgs => null;

		internal DynamicProxyMetaObject(Expression expression, T value, DynamicProxy<T> proxy)
			: base(null, null)
		{
		}

		private bool IsOverridden(string method)
		{
			return false;
		}

		public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
		{
			return null;
		}

		public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
		{
			return null;
		}

		private static IEnumerable<Expression> GetArgs(params DynamicMetaObject[] args)
		{
			return null;
		}

		private static ConstantExpression Constant(DynamicMetaObjectBinder binder)
		{
			return null;
		}

		private DynamicMetaObject CallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, Fallback fallback, Fallback fallbackInvoke = null)
		{
			return null;
		}

		private DynamicMetaObject BuildCallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicMetaObject fallbackResult, Fallback fallbackInvoke)
		{
			return null;
		}

		private DynamicMetaObject CallMethodReturnLast(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, Fallback fallback)
		{
			return null;
		}

		private BindingRestrictions GetRestrictions()
		{
			return null;
		}

		public override IEnumerable<string> GetDynamicMemberNames()
		{
			return null;
		}
	}
}
