namespace Polly
{
	public delegate bool ResultPredicate<in TResult>(TResult result);
}
