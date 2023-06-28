using System.Linq.Expressions;

namespace Newtonsoft.Json.Utilities
{
	internal class NoThrowExpressionVisitor : ExpressionVisitor
	{
		internal static readonly object ErrorResult;

		protected override Expression VisitConditional(ConditionalExpression node)
		{
			return null;
		}
	}
}
