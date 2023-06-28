using System;

namespace Polly.CircuitBreaker
{
	internal abstract class CircuitStateController<TResult> : ICircuitController<TResult>
	{
		protected readonly TimeSpan _durationOfBreak;

		protected long _blockedTill;

		protected CircuitState _circuitState;

		protected DelegateResult<TResult> _lastOutcome;

		protected readonly Action<DelegateResult<TResult>, CircuitState, TimeSpan, Context> _onBreak;

		protected readonly Action<Context> _onReset;

		protected readonly Action _onHalfOpen;

		protected readonly object _lock;

		public CircuitState CircuitState => default(CircuitState);

		protected bool IsInAutomatedBreak_NeedsLock => false;

		protected CircuitStateController(TimeSpan durationOfBreak, Action<DelegateResult<TResult>, CircuitState, TimeSpan, Context> onBreak, Action<Context> onReset, Action onHalfOpen)
		{
		}

		protected void Break_NeedsLock(Context context)
		{
		}

		private void BreakFor_NeedsLock(TimeSpan durationOfBreak, Context context)
		{
		}

		public void Reset()
		{
		}

		protected void ResetInternal_NeedsLock(Context context)
		{
		}

		protected bool PermitHalfOpenCircuitTest()
		{
			return false;
		}

		private BrokenCircuitException GetBreakingException()
		{
			return null;
		}

		public void OnActionPreExecute()
		{
		}

		public abstract void OnActionSuccess(Context context);

		public abstract void OnActionFailure(DelegateResult<TResult> outcome, Context context);

		public abstract void OnCircuitReset(Context context);
	}
}
