using System;
using System.Threading;
using System.Threading.Tasks;
using Gjg.Io.Zen.Proto.Game.V1.Resources;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Gjg.Io.Zen.Proto.Game.V1.Services
{
	public static class DocumentStoreService
	{
		public abstract class DocumentStoreServiceBase
		{
			public virtual Task<GetDocumentResponse> GetDocument(GetDocumentRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<SetDocumentResponse> SetDocument(SetDocumentRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<DeleteDocumentResponse> DeleteDocument(DeleteDocumentRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<SetFacebookIDResponse> SetFacebookID(SetFacebookIDRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<GetByFacebookIDResponse> GetByFacebookID(GetByFacebookIDRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<SetAppleIDResponse> SetAppleID(SetAppleIDRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<GetByAppleIDResponse> GetByAppleID(GetByAppleIDRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<GetAllIDsResponse> GetAllIDs(GetAllIDsRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<SetAllIDsResponse> SetAllIDs(SetAllIDsRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<DeleteAllIDsResponse> DeleteAllIDs(DeleteAllIDsRequest request, ServerCallContext context)
			{
				return null;
			}
		}

		public class DocumentStoreServiceClient : ClientBase<DocumentStoreServiceClient>
		{
			public DocumentStoreServiceClient(ChannelBase channel)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public DocumentStoreServiceClient(CallInvoker callInvoker)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected DocumentStoreServiceClient()
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected DocumentStoreServiceClient(ClientBaseConfiguration configuration)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public virtual GetDocumentResponse GetDocument(GetDocumentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual GetDocumentResponse GetDocument(GetDocumentRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetDocumentResponse> GetDocumentAsync(GetDocumentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetDocumentResponse> GetDocumentAsync(GetDocumentRequest request, CallOptions options)
			{
				return null;
			}

			public virtual SetDocumentResponse SetDocument(SetDocumentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual SetDocumentResponse SetDocument(SetDocumentRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<SetDocumentResponse> SetDocumentAsync(SetDocumentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<SetDocumentResponse> SetDocumentAsync(SetDocumentRequest request, CallOptions options)
			{
				return null;
			}

			public virtual DeleteDocumentResponse DeleteDocument(DeleteDocumentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual DeleteDocumentResponse DeleteDocument(DeleteDocumentRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<DeleteDocumentResponse> DeleteDocumentAsync(DeleteDocumentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<DeleteDocumentResponse> DeleteDocumentAsync(DeleteDocumentRequest request, CallOptions options)
			{
				return null;
			}

			public virtual SetFacebookIDResponse SetFacebookID(SetFacebookIDRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual SetFacebookIDResponse SetFacebookID(SetFacebookIDRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<SetFacebookIDResponse> SetFacebookIDAsync(SetFacebookIDRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<SetFacebookIDResponse> SetFacebookIDAsync(SetFacebookIDRequest request, CallOptions options)
			{
				return null;
			}

			public virtual GetByFacebookIDResponse GetByFacebookID(GetByFacebookIDRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual GetByFacebookIDResponse GetByFacebookID(GetByFacebookIDRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetByFacebookIDResponse> GetByFacebookIDAsync(GetByFacebookIDRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetByFacebookIDResponse> GetByFacebookIDAsync(GetByFacebookIDRequest request, CallOptions options)
			{
				return null;
			}

			public virtual SetAppleIDResponse SetAppleID(SetAppleIDRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual SetAppleIDResponse SetAppleID(SetAppleIDRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<SetAppleIDResponse> SetAppleIDAsync(SetAppleIDRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<SetAppleIDResponse> SetAppleIDAsync(SetAppleIDRequest request, CallOptions options)
			{
				return null;
			}

			public virtual GetByAppleIDResponse GetByAppleID(GetByAppleIDRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual GetByAppleIDResponse GetByAppleID(GetByAppleIDRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetByAppleIDResponse> GetByAppleIDAsync(GetByAppleIDRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetByAppleIDResponse> GetByAppleIDAsync(GetByAppleIDRequest request, CallOptions options)
			{
				return null;
			}

			public virtual GetAllIDsResponse GetAllIDs(GetAllIDsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual GetAllIDsResponse GetAllIDs(GetAllIDsRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetAllIDsResponse> GetAllIDsAsync(GetAllIDsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetAllIDsResponse> GetAllIDsAsync(GetAllIDsRequest request, CallOptions options)
			{
				return null;
			}

			public virtual SetAllIDsResponse SetAllIDs(SetAllIDsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual SetAllIDsResponse SetAllIDs(SetAllIDsRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<SetAllIDsResponse> SetAllIDsAsync(SetAllIDsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<SetAllIDsResponse> SetAllIDsAsync(SetAllIDsRequest request, CallOptions options)
			{
				return null;
			}

			public virtual DeleteAllIDsResponse DeleteAllIDs(DeleteAllIDsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual DeleteAllIDsResponse DeleteAllIDs(DeleteAllIDsRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<DeleteAllIDsResponse> DeleteAllIDsAsync(DeleteAllIDsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<DeleteAllIDsResponse> DeleteAllIDsAsync(DeleteAllIDsRequest request, CallOptions options)
			{
				return null;
			}

			protected override DocumentStoreServiceClient NewInstance(ClientBaseConfiguration configuration)
			{
				return null;
			}
		}

		private static readonly string __ServiceName;

		private static readonly Marshaller<GetDocumentRequest> __Marshaller_zen_game_v1_store_resources_GetDocumentRequest;

		private static readonly Marshaller<GetDocumentResponse> __Marshaller_zen_game_v1_store_resources_GetDocumentResponse;

		private static readonly Marshaller<SetDocumentRequest> __Marshaller_zen_game_v1_store_resources_SetDocumentRequest;

		private static readonly Marshaller<SetDocumentResponse> __Marshaller_zen_game_v1_store_resources_SetDocumentResponse;

		private static readonly Marshaller<DeleteDocumentRequest> __Marshaller_zen_game_v1_store_resources_DeleteDocumentRequest;

		private static readonly Marshaller<DeleteDocumentResponse> __Marshaller_zen_game_v1_store_resources_DeleteDocumentResponse;

		private static readonly Marshaller<SetFacebookIDRequest> __Marshaller_zen_game_v1_store_resources_SetFacebookIDRequest;

		private static readonly Marshaller<SetFacebookIDResponse> __Marshaller_zen_game_v1_store_resources_SetFacebookIDResponse;

		private static readonly Marshaller<GetByFacebookIDRequest> __Marshaller_zen_game_v1_store_resources_GetByFacebookIDRequest;

		private static readonly Marshaller<GetByFacebookIDResponse> __Marshaller_zen_game_v1_store_resources_GetByFacebookIDResponse;

		private static readonly Marshaller<SetAppleIDRequest> __Marshaller_zen_game_v1_store_resources_SetAppleIDRequest;

		private static readonly Marshaller<SetAppleIDResponse> __Marshaller_zen_game_v1_store_resources_SetAppleIDResponse;

		private static readonly Marshaller<GetByAppleIDRequest> __Marshaller_zen_game_v1_store_resources_GetByAppleIDRequest;

		private static readonly Marshaller<GetByAppleIDResponse> __Marshaller_zen_game_v1_store_resources_GetByAppleIDResponse;

		private static readonly Marshaller<GetAllIDsRequest> __Marshaller_zen_game_v1_store_resources_GetAllIDsRequest;

		private static readonly Marshaller<GetAllIDsResponse> __Marshaller_zen_game_v1_store_resources_GetAllIDsResponse;

		private static readonly Marshaller<SetAllIDsRequest> __Marshaller_zen_game_v1_store_resources_SetAllIDsRequest;

		private static readonly Marshaller<SetAllIDsResponse> __Marshaller_zen_game_v1_store_resources_SetAllIDsResponse;

		private static readonly Marshaller<DeleteAllIDsRequest> __Marshaller_zen_game_v1_store_resources_DeleteAllIDsRequest;

		private static readonly Marshaller<DeleteAllIDsResponse> __Marshaller_zen_game_v1_store_resources_DeleteAllIDsResponse;

		private static readonly Method<GetDocumentRequest, GetDocumentResponse> __Method_GetDocument;

		private static readonly Method<SetDocumentRequest, SetDocumentResponse> __Method_SetDocument;

		private static readonly Method<DeleteDocumentRequest, DeleteDocumentResponse> __Method_DeleteDocument;

		private static readonly Method<SetFacebookIDRequest, SetFacebookIDResponse> __Method_SetFacebookID;

		private static readonly Method<GetByFacebookIDRequest, GetByFacebookIDResponse> __Method_GetByFacebookID;

		private static readonly Method<SetAppleIDRequest, SetAppleIDResponse> __Method_SetAppleID;

		private static readonly Method<GetByAppleIDRequest, GetByAppleIDResponse> __Method_GetByAppleID;

		private static readonly Method<GetAllIDsRequest, GetAllIDsResponse> __Method_GetAllIDs;

		private static readonly Method<SetAllIDsRequest, SetAllIDsResponse> __Method_SetAllIDs;

		private static readonly Method<DeleteAllIDsRequest, DeleteAllIDsResponse> __Method_DeleteAllIDs;

		public static ServiceDescriptor Descriptor => null;

		public static ServerServiceDefinition BindService(DocumentStoreServiceBase serviceImpl)
		{
			return null;
		}

		public static void BindService(ServiceBinderBase serviceBinder, DocumentStoreServiceBase serviceImpl)
		{
		}
	}
}
