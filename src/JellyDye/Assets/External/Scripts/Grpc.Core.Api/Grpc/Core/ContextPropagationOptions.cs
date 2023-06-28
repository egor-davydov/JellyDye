namespace Grpc.Core
{
	public class ContextPropagationOptions
	{
		public static readonly ContextPropagationOptions Default;

		private bool propagateDeadline;

		private bool propagateCancellation;

		public bool IsPropagateDeadline => false;

		public bool IsPropagateCancellation => false;

		public ContextPropagationOptions(bool propagateDeadline = true, bool propagateCancellation = true)
		{
		}
	}
}
