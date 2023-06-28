namespace Grpc.Core.Internal
{
	internal interface IBufferReader
	{
		int? TotalLength { get; }

		bool TryGetNextSlice(out Slice slice);
	}
}
