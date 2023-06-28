namespace Facebook.Unity
{
	public interface IProfileResult : IResult
	{
		Profile CurrentProfile { get; }
	}
}
