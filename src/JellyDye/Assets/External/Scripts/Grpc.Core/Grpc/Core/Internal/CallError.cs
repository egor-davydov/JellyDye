namespace Grpc.Core.Internal
{
	internal enum CallError
	{
		OK = 0,
		Error = 1,
		NotOnServer = 2,
		NotOnClient = 3,
		AlreadyAccepted = 4,
		AlreadyInvoked = 5,
		NotInvoked = 6,
		AlreadyFinished = 7,
		TooManyOperations = 8,
		InvalidFlags = 9,
		InvalidMetadata = 10,
		InvalidMessage = 11,
		NotServerCompletionQueue = 12,
		BatchTooBig = 13,
		PayloadTypeMismatch = 14,
		CompletionQueueShutdown = 15
	}
}
