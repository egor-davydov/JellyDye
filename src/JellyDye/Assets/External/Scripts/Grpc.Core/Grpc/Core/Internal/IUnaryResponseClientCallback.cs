namespace Grpc.Core.Internal
{
	internal interface IUnaryResponseClientCallback
	{
		void OnUnaryResponseClient(bool success, ClientSideStatus receivedStatus, IBufferReader receivedMessageReader, Metadata responseHeaders);
	}
}
