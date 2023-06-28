namespace Unity.Services.Core.Internal
{
	internal class DependencyTreeComponentHashException : HashException
	{
		public DependencyTreeComponentHashException(int hash, string message)
			: base(0, null)
		{
		}
	}
}
