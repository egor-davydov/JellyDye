using System;

namespace Grpc.Core.Internal
{
	internal interface INativeCall : IDisposable
	{
		void Cancel();

		void CancelWithStatus(Status status);

		void StartUnary(IUnaryResponseClientCallback callback, SliceBufferSafeHandle payload, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags callFlags);

		void StartUnary(BatchContextSafeHandle ctx, SliceBufferSafeHandle payload, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags callFlags);
	}
}
