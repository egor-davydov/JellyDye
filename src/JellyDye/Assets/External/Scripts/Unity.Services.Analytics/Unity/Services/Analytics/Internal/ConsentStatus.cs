namespace Unity.Services.Analytics.Internal
{
	internal enum ConsentStatus
	{
		Unknown = 0,
		Forgetting = 1,
		OptedOut = 2,
		NotRequired = 3,
		RequiredButUnchecked = 4,
		ConsentGiven = 5,
		ConsentDenied = 6
	}
}
