namespace Polly.CircuitBreaker
{
	public class IsolatedCircuitException : BrokenCircuitException
	{
		public IsolatedCircuitException(string message)
			: base(null)
		{
		}
	}
}
