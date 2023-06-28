namespace Grpc.Core.Internal
{
	internal interface IReceivedMessageCallback
	{
		void OnReceivedMessage(bool success, IBufferReader receivedMessageReader);
	}
}
