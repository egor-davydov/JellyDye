namespace Polly.CircuitBreaker
{
	internal interface ICircuitController<TResult>
	{
		void OnActionPreExecute();

		void OnActionSuccess(Context context);

		void OnActionFailure(DelegateResult<TResult> outcome, Context context);
	}
}
