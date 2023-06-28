using System;

namespace Polly.CircuitBreaker
{
	internal class ConsecutiveCountCircuitController<TResult> : CircuitStateController<TResult>
	{
		private readonly int _exceptionsAllowedBeforeBreaking;

		private int _consecutiveFailureCount;

		public ConsecutiveCountCircuitController(int exceptionsAllowedBeforeBreaking, TimeSpan durationOfBreak, Action<DelegateResult<TResult>, CircuitState, TimeSpan, Context> onBreak, Action<Context> onReset, Action onHalfOpen)
		{
			((CircuitStateController<>)(object)this)._002Ector(default(TimeSpan), (Action<DelegateResult<TResult>, CircuitState, TimeSpan, Context>)null, (Action<Context>)null, (Action)null);
		}

		public override void OnCircuitReset(Context context)
		{
		}

		public override void OnActionSuccess(Context context)
		{
		}

		public override void OnActionFailure(DelegateResult<TResult> outcome, Context context)
		{
		}
	}
}
