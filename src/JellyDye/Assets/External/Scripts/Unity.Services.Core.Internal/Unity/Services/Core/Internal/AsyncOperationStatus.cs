namespace Unity.Services.Core.Internal
{
	internal enum AsyncOperationStatus
	{
		None = 0,
		InProgress = 1,
		Succeeded = 2,
		Failed = 3,
		Cancelled = 4
	}
}
