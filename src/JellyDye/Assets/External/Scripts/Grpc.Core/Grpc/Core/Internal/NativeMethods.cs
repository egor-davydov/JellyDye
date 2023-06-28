using System;
using System.Runtime.InteropServices;

namespace Grpc.Core.Internal
{
	internal class NativeMethods
	{
		public class Delegates
		{
			public delegate void grpcsharp_init_delegate();

			public delegate void grpcsharp_shutdown_delegate();

			public delegate IntPtr grpcsharp_version_string_delegate();

			public delegate BatchContextSafeHandle grpcsharp_batch_context_create_delegate();

			public delegate IntPtr grpcsharp_batch_context_recv_initial_metadata_delegate(BatchContextSafeHandle ctx);

			public delegate IntPtr grpcsharp_batch_context_recv_message_length_delegate(BatchContextSafeHandle ctx);

			public delegate int grpcsharp_batch_context_recv_message_next_slice_peek_delegate(BatchContextSafeHandle ctx, out UIntPtr sliceLen, out IntPtr sliceDataPtr);

			public delegate StatusCode grpcsharp_batch_context_recv_status_on_client_status_delegate(BatchContextSafeHandle ctx);

			public delegate IntPtr grpcsharp_batch_context_recv_status_on_client_details_delegate(BatchContextSafeHandle ctx, out UIntPtr detailsLength);

			public delegate IntPtr grpcsharp_batch_context_recv_status_on_client_error_string_delegate(BatchContextSafeHandle ctx);

			public delegate IntPtr grpcsharp_batch_context_recv_status_on_client_trailing_metadata_delegate(BatchContextSafeHandle ctx);

			public delegate int grpcsharp_batch_context_recv_close_on_server_cancelled_delegate(BatchContextSafeHandle ctx);

			public delegate void grpcsharp_batch_context_reset_delegate(BatchContextSafeHandle ctx);

			public delegate void grpcsharp_batch_context_destroy_delegate(IntPtr ctx);

			public delegate RequestCallContextSafeHandle grpcsharp_request_call_context_create_delegate();

			public delegate CallSafeHandle grpcsharp_request_call_context_call_delegate(RequestCallContextSafeHandle ctx);

			public delegate IntPtr grpcsharp_request_call_context_method_delegate(RequestCallContextSafeHandle ctx, out UIntPtr methodLength);

			public delegate IntPtr grpcsharp_request_call_context_host_delegate(RequestCallContextSafeHandle ctx, out UIntPtr hostLength);

			public delegate Timespec grpcsharp_request_call_context_deadline_delegate(RequestCallContextSafeHandle ctx);

			public delegate IntPtr grpcsharp_request_call_context_request_metadata_delegate(RequestCallContextSafeHandle ctx);

			public delegate void grpcsharp_request_call_context_reset_delegate(RequestCallContextSafeHandle ctx);

			public delegate void grpcsharp_request_call_context_destroy_delegate(IntPtr ctx);

			public delegate CallCredentialsSafeHandle grpcsharp_composite_call_credentials_create_delegate(CallCredentialsSafeHandle creds1, CallCredentialsSafeHandle creds2);

			public delegate void grpcsharp_call_credentials_release_delegate(IntPtr credentials);

			public delegate CallError grpcsharp_call_cancel_delegate(CallSafeHandle call);

			public delegate CallError grpcsharp_call_cancel_with_status_delegate(CallSafeHandle call, StatusCode status, string description);

			public delegate CallError grpcsharp_call_start_unary_delegate(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			public delegate CallError grpcsharp_call_start_client_streaming_delegate(CallSafeHandle call, BatchContextSafeHandle ctx, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			public delegate CallError grpcsharp_call_start_server_streaming_delegate(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			public delegate CallError grpcsharp_call_start_duplex_streaming_delegate(CallSafeHandle call, BatchContextSafeHandle ctx, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			public delegate CallError grpcsharp_call_send_message_delegate(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, int sendEmptyInitialMetadata);

			public delegate CallError grpcsharp_call_send_close_from_client_delegate(CallSafeHandle call, BatchContextSafeHandle ctx);

			public delegate CallError grpcsharp_call_send_status_from_server_delegate(CallSafeHandle call, BatchContextSafeHandle ctx, StatusCode statusCode, IntPtr statusMessage, UIntPtr statusMessageLen, MetadataArraySafeHandle metadataArray, int sendEmptyInitialMetadata, SliceBufferSafeHandle optionalSendBuffer, WriteFlags writeFlags);

			public delegate CallError grpcsharp_call_recv_message_delegate(CallSafeHandle call, BatchContextSafeHandle ctx);

			public delegate CallError grpcsharp_call_recv_initial_metadata_delegate(CallSafeHandle call, BatchContextSafeHandle ctx);

			public delegate CallError grpcsharp_call_start_serverside_delegate(CallSafeHandle call, BatchContextSafeHandle ctx);

			public delegate CallError grpcsharp_call_send_initial_metadata_delegate(CallSafeHandle call, BatchContextSafeHandle ctx, MetadataArraySafeHandle metadataArray);

			public delegate CallError grpcsharp_call_set_credentials_delegate(CallSafeHandle call, CallCredentialsSafeHandle credentials);

			public delegate CStringSafeHandle grpcsharp_call_get_peer_delegate(CallSafeHandle call);

			public delegate void grpcsharp_call_destroy_delegate(IntPtr call);

			public delegate ChannelArgsSafeHandle grpcsharp_channel_args_create_delegate(UIntPtr numArgs);

			public delegate void grpcsharp_channel_args_set_string_delegate(ChannelArgsSafeHandle args, UIntPtr index, string key, string value);

			public delegate void grpcsharp_channel_args_set_integer_delegate(ChannelArgsSafeHandle args, UIntPtr index, string key, int value);

			public delegate void grpcsharp_channel_args_destroy_delegate(IntPtr args);

			public delegate void grpcsharp_override_default_ssl_roots_delegate(string pemRootCerts);

			public delegate ChannelCredentialsSafeHandle grpcsharp_ssl_credentials_create_delegate(string pemRootCerts, string keyCertPairCertChain, string keyCertPairPrivateKey, IntPtr verifyPeerCallbackTag);

			public delegate ChannelCredentialsSafeHandle grpcsharp_composite_channel_credentials_create_delegate(ChannelCredentialsSafeHandle channelCreds, CallCredentialsSafeHandle callCreds);

			public delegate void grpcsharp_channel_credentials_release_delegate(IntPtr credentials);

			public delegate ChannelSafeHandle grpcsharp_insecure_channel_create_delegate(string target, ChannelArgsSafeHandle channelArgs);

			public delegate ChannelSafeHandle grpcsharp_secure_channel_create_delegate(ChannelCredentialsSafeHandle credentials, string target, ChannelArgsSafeHandle channelArgs);

			public delegate CallSafeHandle grpcsharp_channel_create_call_delegate(ChannelSafeHandle channel, CallSafeHandle parentCall, ContextPropagationFlags propagationMask, CompletionQueueSafeHandle cq, string method, string host, Timespec deadline);

			public delegate ChannelState grpcsharp_channel_check_connectivity_state_delegate(ChannelSafeHandle channel, int tryToConnect);

			public delegate void grpcsharp_channel_watch_connectivity_state_delegate(ChannelSafeHandle channel, ChannelState lastObservedState, Timespec deadline, CompletionQueueSafeHandle cq, BatchContextSafeHandle ctx);

			public delegate CStringSafeHandle grpcsharp_channel_get_target_delegate(ChannelSafeHandle call);

			public delegate void grpcsharp_channel_destroy_delegate(IntPtr channel);

			public delegate int grpcsharp_sizeof_grpc_event_delegate();

			public delegate CompletionQueueSafeHandle grpcsharp_completion_queue_create_async_delegate();

			public delegate CompletionQueueSafeHandle grpcsharp_completion_queue_create_sync_delegate();

			public delegate void grpcsharp_completion_queue_shutdown_delegate(CompletionQueueSafeHandle cq);

			public delegate CompletionQueueEvent grpcsharp_completion_queue_next_delegate(CompletionQueueSafeHandle cq);

			public delegate CompletionQueueEvent grpcsharp_completion_queue_pluck_delegate(CompletionQueueSafeHandle cq, IntPtr tag);

			public delegate void grpcsharp_completion_queue_destroy_delegate(IntPtr cq);

			public delegate void gprsharp_free_delegate(IntPtr ptr);

			public delegate MetadataArraySafeHandle grpcsharp_metadata_array_create_delegate(UIntPtr capacity);

			public delegate void grpcsharp_metadata_array_add_delegate(MetadataArraySafeHandle array, string key, byte[] value, UIntPtr valueLength);

			public delegate UIntPtr grpcsharp_metadata_array_count_delegate(IntPtr metadataArray);

			public delegate IntPtr grpcsharp_metadata_array_get_key_delegate(IntPtr metadataArray, UIntPtr index, out UIntPtr keyLength);

			public delegate IntPtr grpcsharp_metadata_array_get_value_delegate(IntPtr metadataArray, UIntPtr index, out UIntPtr valueLength);

			public delegate void grpcsharp_metadata_array_destroy_full_delegate(IntPtr array);

			public delegate void grpcsharp_redirect_log_delegate(GprLogDelegate callback);

			public delegate void grpcsharp_native_callback_dispatcher_init_delegate(NativeCallbackDispatcherCallback dispatcher);

			public delegate CallCredentialsSafeHandle grpcsharp_metadata_credentials_create_from_plugin_delegate(IntPtr nativeCallbackTag);

			public delegate void grpcsharp_metadata_credentials_notify_from_plugin_delegate(IntPtr callbackPtr, IntPtr userData, MetadataArraySafeHandle metadataArray, StatusCode statusCode, string errorDetails);

			public delegate ServerCredentialsSafeHandle grpcsharp_ssl_server_credentials_create_delegate(string pemRootCerts, string[] keyCertPairCertChainArray, string[] keyCertPairPrivateKeyArray, UIntPtr numKeyCertPairs, SslClientCertificateRequestType clientCertificateRequest);

			public delegate void grpcsharp_server_credentials_release_delegate(IntPtr credentials);

			public delegate ServerSafeHandle grpcsharp_server_create_delegate(ChannelArgsSafeHandle args);

			public delegate void grpcsharp_server_register_completion_queue_delegate(ServerSafeHandle server, CompletionQueueSafeHandle cq);

			public delegate int grpcsharp_server_add_insecure_http2_port_delegate(ServerSafeHandle server, string addr);

			public delegate int grpcsharp_server_add_secure_http2_port_delegate(ServerSafeHandle server, string addr, ServerCredentialsSafeHandle creds);

			public delegate void grpcsharp_server_start_delegate(ServerSafeHandle server);

			public delegate CallError grpcsharp_server_request_call_delegate(ServerSafeHandle server, CompletionQueueSafeHandle cq, RequestCallContextSafeHandle ctx);

			public delegate void grpcsharp_server_cancel_all_calls_delegate(ServerSafeHandle server);

			public delegate void grpcsharp_server_shutdown_and_notify_callback_delegate(ServerSafeHandle server, CompletionQueueSafeHandle cq, BatchContextSafeHandle ctx);

			public delegate void grpcsharp_server_destroy_delegate(IntPtr server);

			public delegate AuthContextSafeHandle grpcsharp_call_auth_context_delegate(CallSafeHandle call);

			public delegate IntPtr grpcsharp_auth_context_peer_identity_property_name_delegate(AuthContextSafeHandle authContext);

			public delegate AuthContextSafeHandle.NativeAuthPropertyIterator grpcsharp_auth_context_property_iterator_delegate(AuthContextSafeHandle authContext);

			public delegate IntPtr grpcsharp_auth_property_iterator_next_delegate(ref AuthContextSafeHandle.NativeAuthPropertyIterator iterator);

			public delegate void grpcsharp_auth_context_release_delegate(IntPtr authContext);

			public delegate SliceBufferSafeHandle grpcsharp_slice_buffer_create_delegate();

			public delegate IntPtr grpcsharp_slice_buffer_adjust_tail_space_delegate(SliceBufferSafeHandle sliceBuffer, UIntPtr availableTailSpace, UIntPtr requestedTailSpace);

			public delegate UIntPtr grpcsharp_slice_buffer_slice_count_delegate(SliceBufferSafeHandle sliceBuffer);

			public delegate void grpcsharp_slice_buffer_slice_peek_delegate(SliceBufferSafeHandle sliceBuffer, UIntPtr index, out UIntPtr sliceLen, out IntPtr sliceDataPtr);

			public delegate void grpcsharp_slice_buffer_reset_and_unref_delegate(SliceBufferSafeHandle sliceBuffer);

			public delegate void grpcsharp_slice_buffer_destroy_delegate(IntPtr sliceBuffer);

			public delegate Timespec gprsharp_now_delegate(ClockType clockType);

			public delegate Timespec gprsharp_inf_future_delegate(ClockType clockType);

			public delegate Timespec gprsharp_inf_past_delegate(ClockType clockType);

			public delegate Timespec gprsharp_convert_clock_type_delegate(Timespec t, ClockType targetClock);

			public delegate int gprsharp_sizeof_timespec_delegate();

			public delegate CallError grpcsharp_test_callback_delegate(NativeCallbackTestDelegate callback);

			public delegate IntPtr grpcsharp_test_nop_delegate(IntPtr ptr);

			public delegate void grpcsharp_test_override_method_delegate(string methodName, string variant);

			public delegate CallError grpcsharp_test_call_start_unary_echo_delegate(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
		}

		internal class DllImportsFromStaticLib
		{
			[PreserveSig]
			public static extern void grpcsharp_init();

			[PreserveSig]
			public static extern void grpcsharp_shutdown();

			[PreserveSig]
			public static extern IntPtr grpcsharp_version_string();

			[PreserveSig]
			public static extern BatchContextSafeHandle grpcsharp_batch_context_create();

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_initial_metadata(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_message_length(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern int grpcsharp_batch_context_recv_message_next_slice_peek(BatchContextSafeHandle ctx, out UIntPtr sliceLen, out IntPtr sliceDataPtr);

			[PreserveSig]
			public static extern StatusCode grpcsharp_batch_context_recv_status_on_client_status(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_status_on_client_details(BatchContextSafeHandle ctx, out UIntPtr detailsLength);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_status_on_client_error_string(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_status_on_client_trailing_metadata(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern int grpcsharp_batch_context_recv_close_on_server_cancelled(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_batch_context_reset(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_batch_context_destroy(IntPtr ctx);

			[PreserveSig]
			public static extern RequestCallContextSafeHandle grpcsharp_request_call_context_create();

			[PreserveSig]
			public static extern CallSafeHandle grpcsharp_request_call_context_call(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_request_call_context_method(RequestCallContextSafeHandle ctx, out UIntPtr methodLength);

			[PreserveSig]
			public static extern IntPtr grpcsharp_request_call_context_host(RequestCallContextSafeHandle ctx, out UIntPtr hostLength);

			[PreserveSig]
			public static extern Timespec grpcsharp_request_call_context_deadline(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_request_call_context_request_metadata(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_request_call_context_reset(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_request_call_context_destroy(IntPtr ctx);

			[PreserveSig]
			public static extern CallCredentialsSafeHandle grpcsharp_composite_call_credentials_create(CallCredentialsSafeHandle creds1, CallCredentialsSafeHandle creds2);

			[PreserveSig]
			public static extern void grpcsharp_call_credentials_release(IntPtr credentials);

			[PreserveSig]
			public static extern CallError grpcsharp_call_cancel(CallSafeHandle call);

			[PreserveSig]
			public static extern CallError grpcsharp_call_cancel_with_status(CallSafeHandle call, StatusCode status, string description);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_unary(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_client_streaming(CallSafeHandle call, BatchContextSafeHandle ctx, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_server_streaming(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_duplex_streaming(CallSafeHandle call, BatchContextSafeHandle ctx, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_message(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, int sendEmptyInitialMetadata);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_close_from_client(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_status_from_server(CallSafeHandle call, BatchContextSafeHandle ctx, StatusCode statusCode, IntPtr statusMessage, UIntPtr statusMessageLen, MetadataArraySafeHandle metadataArray, int sendEmptyInitialMetadata, SliceBufferSafeHandle optionalSendBuffer, WriteFlags writeFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_recv_message(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_recv_initial_metadata(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_serverside(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_initial_metadata(CallSafeHandle call, BatchContextSafeHandle ctx, MetadataArraySafeHandle metadataArray);

			[PreserveSig]
			public static extern CallError grpcsharp_call_set_credentials(CallSafeHandle call, CallCredentialsSafeHandle credentials);

			[PreserveSig]
			public static extern CStringSafeHandle grpcsharp_call_get_peer(CallSafeHandle call);

			[PreserveSig]
			public static extern void grpcsharp_call_destroy(IntPtr call);

			[PreserveSig]
			public static extern ChannelArgsSafeHandle grpcsharp_channel_args_create(UIntPtr numArgs);

			[PreserveSig]
			public static extern void grpcsharp_channel_args_set_string(ChannelArgsSafeHandle args, UIntPtr index, string key, string value);

			[PreserveSig]
			public static extern void grpcsharp_channel_args_set_integer(ChannelArgsSafeHandle args, UIntPtr index, string key, int value);

			[PreserveSig]
			public static extern void grpcsharp_channel_args_destroy(IntPtr args);

			[PreserveSig]
			public static extern void grpcsharp_override_default_ssl_roots(string pemRootCerts);

			[PreserveSig]
			public static extern ChannelCredentialsSafeHandle grpcsharp_ssl_credentials_create(string pemRootCerts, string keyCertPairCertChain, string keyCertPairPrivateKey, IntPtr verifyPeerCallbackTag);

			[PreserveSig]
			public static extern ChannelCredentialsSafeHandle grpcsharp_composite_channel_credentials_create(ChannelCredentialsSafeHandle channelCreds, CallCredentialsSafeHandle callCreds);

			[PreserveSig]
			public static extern void grpcsharp_channel_credentials_release(IntPtr credentials);

			[PreserveSig]
			public static extern ChannelSafeHandle grpcsharp_insecure_channel_create(string target, ChannelArgsSafeHandle channelArgs);

			[PreserveSig]
			public static extern ChannelSafeHandle grpcsharp_secure_channel_create(ChannelCredentialsSafeHandle credentials, string target, ChannelArgsSafeHandle channelArgs);

			[PreserveSig]
			public static extern CallSafeHandle grpcsharp_channel_create_call(ChannelSafeHandle channel, CallSafeHandle parentCall, ContextPropagationFlags propagationMask, CompletionQueueSafeHandle cq, string method, string host, Timespec deadline);

			[PreserveSig]
			public static extern ChannelState grpcsharp_channel_check_connectivity_state(ChannelSafeHandle channel, int tryToConnect);

			[PreserveSig]
			public static extern void grpcsharp_channel_watch_connectivity_state(ChannelSafeHandle channel, ChannelState lastObservedState, Timespec deadline, CompletionQueueSafeHandle cq, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CStringSafeHandle grpcsharp_channel_get_target(ChannelSafeHandle call);

			[PreserveSig]
			public static extern void grpcsharp_channel_destroy(IntPtr channel);

			[PreserveSig]
			public static extern int grpcsharp_sizeof_grpc_event();

			[PreserveSig]
			public static extern CompletionQueueSafeHandle grpcsharp_completion_queue_create_async();

			[PreserveSig]
			public static extern CompletionQueueSafeHandle grpcsharp_completion_queue_create_sync();

			[PreserveSig]
			public static extern void grpcsharp_completion_queue_shutdown(CompletionQueueSafeHandle cq);

			[PreserveSig]
			public static extern CompletionQueueEvent grpcsharp_completion_queue_next(CompletionQueueSafeHandle cq);

			[PreserveSig]
			public static extern CompletionQueueEvent grpcsharp_completion_queue_pluck(CompletionQueueSafeHandle cq, IntPtr tag);

			[PreserveSig]
			public static extern void grpcsharp_completion_queue_destroy(IntPtr cq);

			[PreserveSig]
			public static extern void gprsharp_free(IntPtr ptr);

			[PreserveSig]
			public static extern MetadataArraySafeHandle grpcsharp_metadata_array_create(UIntPtr capacity);

			[PreserveSig]
			public static extern void grpcsharp_metadata_array_add(MetadataArraySafeHandle array, string key, byte[] value, UIntPtr valueLength);

			[PreserveSig]
			public static extern UIntPtr grpcsharp_metadata_array_count(IntPtr metadataArray);

			[PreserveSig]
			public static extern IntPtr grpcsharp_metadata_array_get_key(IntPtr metadataArray, UIntPtr index, out UIntPtr keyLength);

			[PreserveSig]
			public static extern IntPtr grpcsharp_metadata_array_get_value(IntPtr metadataArray, UIntPtr index, out UIntPtr valueLength);

			[PreserveSig]
			public static extern void grpcsharp_metadata_array_destroy_full(IntPtr array);

			[PreserveSig]
			public static extern void grpcsharp_redirect_log(GprLogDelegate callback);

			[PreserveSig]
			public static extern void grpcsharp_native_callback_dispatcher_init(NativeCallbackDispatcherCallback dispatcher);

			[PreserveSig]
			public static extern CallCredentialsSafeHandle grpcsharp_metadata_credentials_create_from_plugin(IntPtr nativeCallbackTag);

			[PreserveSig]
			public static extern void grpcsharp_metadata_credentials_notify_from_plugin(IntPtr callbackPtr, IntPtr userData, MetadataArraySafeHandle metadataArray, StatusCode statusCode, string errorDetails);

			[PreserveSig]
			public static extern ServerCredentialsSafeHandle grpcsharp_ssl_server_credentials_create(string pemRootCerts, string[] keyCertPairCertChainArray, string[] keyCertPairPrivateKeyArray, UIntPtr numKeyCertPairs, SslClientCertificateRequestType clientCertificateRequest);

			[PreserveSig]
			public static extern void grpcsharp_server_credentials_release(IntPtr credentials);

			[PreserveSig]
			public static extern ServerSafeHandle grpcsharp_server_create(ChannelArgsSafeHandle args);

			[PreserveSig]
			public static extern void grpcsharp_server_register_completion_queue(ServerSafeHandle server, CompletionQueueSafeHandle cq);

			[PreserveSig]
			public static extern int grpcsharp_server_add_insecure_http2_port(ServerSafeHandle server, string addr);

			[PreserveSig]
			public static extern int grpcsharp_server_add_secure_http2_port(ServerSafeHandle server, string addr, ServerCredentialsSafeHandle creds);

			[PreserveSig]
			public static extern void grpcsharp_server_start(ServerSafeHandle server);

			[PreserveSig]
			public static extern CallError grpcsharp_server_request_call(ServerSafeHandle server, CompletionQueueSafeHandle cq, RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_server_cancel_all_calls(ServerSafeHandle server);

			[PreserveSig]
			public static extern void grpcsharp_server_shutdown_and_notify_callback(ServerSafeHandle server, CompletionQueueSafeHandle cq, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_server_destroy(IntPtr server);

			[PreserveSig]
			public static extern AuthContextSafeHandle grpcsharp_call_auth_context(CallSafeHandle call);

			[PreserveSig]
			public static extern IntPtr grpcsharp_auth_context_peer_identity_property_name(AuthContextSafeHandle authContext);

			[PreserveSig]
			public static extern AuthContextSafeHandle.NativeAuthPropertyIterator grpcsharp_auth_context_property_iterator(AuthContextSafeHandle authContext);

			[PreserveSig]
			public static extern IntPtr grpcsharp_auth_property_iterator_next(ref AuthContextSafeHandle.NativeAuthPropertyIterator iterator);

			[PreserveSig]
			public static extern void grpcsharp_auth_context_release(IntPtr authContext);

			[PreserveSig]
			public static extern SliceBufferSafeHandle grpcsharp_slice_buffer_create();

			[PreserveSig]
			public static extern IntPtr grpcsharp_slice_buffer_adjust_tail_space(SliceBufferSafeHandle sliceBuffer, UIntPtr availableTailSpace, UIntPtr requestedTailSpace);

			[PreserveSig]
			public static extern UIntPtr grpcsharp_slice_buffer_slice_count(SliceBufferSafeHandle sliceBuffer);

			[PreserveSig]
			public static extern void grpcsharp_slice_buffer_slice_peek(SliceBufferSafeHandle sliceBuffer, UIntPtr index, out UIntPtr sliceLen, out IntPtr sliceDataPtr);

			[PreserveSig]
			public static extern void grpcsharp_slice_buffer_reset_and_unref(SliceBufferSafeHandle sliceBuffer);

			[PreserveSig]
			public static extern void grpcsharp_slice_buffer_destroy(IntPtr sliceBuffer);

			[PreserveSig]
			public static extern Timespec gprsharp_now(ClockType clockType);

			[PreserveSig]
			public static extern Timespec gprsharp_inf_future(ClockType clockType);

			[PreserveSig]
			public static extern Timespec gprsharp_inf_past(ClockType clockType);

			[PreserveSig]
			public static extern Timespec gprsharp_convert_clock_type(Timespec t, ClockType targetClock);

			[PreserveSig]
			public static extern int gprsharp_sizeof_timespec();

			[PreserveSig]
			public static extern CallError grpcsharp_test_callback(NativeCallbackTestDelegate callback);

			[PreserveSig]
			public static extern IntPtr grpcsharp_test_nop(IntPtr ptr);

			[PreserveSig]
			public static extern void grpcsharp_test_override_method(string methodName, string variant);

			[PreserveSig]
			public static extern CallError grpcsharp_test_call_start_unary_echo(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
		}

		internal class DllImportsFromSharedLib
		{
			[PreserveSig]
			public static extern void grpcsharp_init();

			[PreserveSig]
			public static extern void grpcsharp_shutdown();

			[PreserveSig]
			public static extern IntPtr grpcsharp_version_string();

			[PreserveSig]
			public static extern BatchContextSafeHandle grpcsharp_batch_context_create();

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_initial_metadata(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_message_length(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern int grpcsharp_batch_context_recv_message_next_slice_peek(BatchContextSafeHandle ctx, out UIntPtr sliceLen, out IntPtr sliceDataPtr);

			[PreserveSig]
			public static extern StatusCode grpcsharp_batch_context_recv_status_on_client_status(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_status_on_client_details(BatchContextSafeHandle ctx, out UIntPtr detailsLength);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_status_on_client_error_string(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_status_on_client_trailing_metadata(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern int grpcsharp_batch_context_recv_close_on_server_cancelled(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_batch_context_reset(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_batch_context_destroy(IntPtr ctx);

			[PreserveSig]
			public static extern RequestCallContextSafeHandle grpcsharp_request_call_context_create();

			[PreserveSig]
			public static extern CallSafeHandle grpcsharp_request_call_context_call(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_request_call_context_method(RequestCallContextSafeHandle ctx, out UIntPtr methodLength);

			[PreserveSig]
			public static extern IntPtr grpcsharp_request_call_context_host(RequestCallContextSafeHandle ctx, out UIntPtr hostLength);

			[PreserveSig]
			public static extern Timespec grpcsharp_request_call_context_deadline(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_request_call_context_request_metadata(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_request_call_context_reset(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_request_call_context_destroy(IntPtr ctx);

			[PreserveSig]
			public static extern CallCredentialsSafeHandle grpcsharp_composite_call_credentials_create(CallCredentialsSafeHandle creds1, CallCredentialsSafeHandle creds2);

			[PreserveSig]
			public static extern void grpcsharp_call_credentials_release(IntPtr credentials);

			[PreserveSig]
			public static extern CallError grpcsharp_call_cancel(CallSafeHandle call);

			[PreserveSig]
			public static extern CallError grpcsharp_call_cancel_with_status(CallSafeHandle call, StatusCode status, string description);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_unary(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_client_streaming(CallSafeHandle call, BatchContextSafeHandle ctx, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_server_streaming(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_duplex_streaming(CallSafeHandle call, BatchContextSafeHandle ctx, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_message(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, int sendEmptyInitialMetadata);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_close_from_client(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_status_from_server(CallSafeHandle call, BatchContextSafeHandle ctx, StatusCode statusCode, IntPtr statusMessage, UIntPtr statusMessageLen, MetadataArraySafeHandle metadataArray, int sendEmptyInitialMetadata, SliceBufferSafeHandle optionalSendBuffer, WriteFlags writeFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_recv_message(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_recv_initial_metadata(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_serverside(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_initial_metadata(CallSafeHandle call, BatchContextSafeHandle ctx, MetadataArraySafeHandle metadataArray);

			[PreserveSig]
			public static extern CallError grpcsharp_call_set_credentials(CallSafeHandle call, CallCredentialsSafeHandle credentials);

			[PreserveSig]
			public static extern CStringSafeHandle grpcsharp_call_get_peer(CallSafeHandle call);

			[PreserveSig]
			public static extern void grpcsharp_call_destroy(IntPtr call);

			[PreserveSig]
			public static extern ChannelArgsSafeHandle grpcsharp_channel_args_create(UIntPtr numArgs);

			[PreserveSig]
			public static extern void grpcsharp_channel_args_set_string(ChannelArgsSafeHandle args, UIntPtr index, string key, string value);

			[PreserveSig]
			public static extern void grpcsharp_channel_args_set_integer(ChannelArgsSafeHandle args, UIntPtr index, string key, int value);

			[PreserveSig]
			public static extern void grpcsharp_channel_args_destroy(IntPtr args);

			[PreserveSig]
			public static extern void grpcsharp_override_default_ssl_roots(string pemRootCerts);

			[PreserveSig]
			public static extern ChannelCredentialsSafeHandle grpcsharp_ssl_credentials_create(string pemRootCerts, string keyCertPairCertChain, string keyCertPairPrivateKey, IntPtr verifyPeerCallbackTag);

			[PreserveSig]
			public static extern ChannelCredentialsSafeHandle grpcsharp_composite_channel_credentials_create(ChannelCredentialsSafeHandle channelCreds, CallCredentialsSafeHandle callCreds);

			[PreserveSig]
			public static extern void grpcsharp_channel_credentials_release(IntPtr credentials);

			[PreserveSig]
			public static extern ChannelSafeHandle grpcsharp_insecure_channel_create(string target, ChannelArgsSafeHandle channelArgs);

			[PreserveSig]
			public static extern ChannelSafeHandle grpcsharp_secure_channel_create(ChannelCredentialsSafeHandle credentials, string target, ChannelArgsSafeHandle channelArgs);

			[PreserveSig]
			public static extern CallSafeHandle grpcsharp_channel_create_call(ChannelSafeHandle channel, CallSafeHandle parentCall, ContextPropagationFlags propagationMask, CompletionQueueSafeHandle cq, string method, string host, Timespec deadline);

			[PreserveSig]
			public static extern ChannelState grpcsharp_channel_check_connectivity_state(ChannelSafeHandle channel, int tryToConnect);

			[PreserveSig]
			public static extern void grpcsharp_channel_watch_connectivity_state(ChannelSafeHandle channel, ChannelState lastObservedState, Timespec deadline, CompletionQueueSafeHandle cq, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CStringSafeHandle grpcsharp_channel_get_target(ChannelSafeHandle call);

			[PreserveSig]
			public static extern void grpcsharp_channel_destroy(IntPtr channel);

			[PreserveSig]
			public static extern int grpcsharp_sizeof_grpc_event();

			[PreserveSig]
			public static extern CompletionQueueSafeHandle grpcsharp_completion_queue_create_async();

			[PreserveSig]
			public static extern CompletionQueueSafeHandle grpcsharp_completion_queue_create_sync();

			[PreserveSig]
			public static extern void grpcsharp_completion_queue_shutdown(CompletionQueueSafeHandle cq);

			[PreserveSig]
			public static extern CompletionQueueEvent grpcsharp_completion_queue_next(CompletionQueueSafeHandle cq);

			[PreserveSig]
			public static extern CompletionQueueEvent grpcsharp_completion_queue_pluck(CompletionQueueSafeHandle cq, IntPtr tag);

			[PreserveSig]
			public static extern void grpcsharp_completion_queue_destroy(IntPtr cq);

			[PreserveSig]
			public static extern void gprsharp_free(IntPtr ptr);

			[PreserveSig]
			public static extern MetadataArraySafeHandle grpcsharp_metadata_array_create(UIntPtr capacity);

			[PreserveSig]
			public static extern void grpcsharp_metadata_array_add(MetadataArraySafeHandle array, string key, byte[] value, UIntPtr valueLength);

			[PreserveSig]
			public static extern UIntPtr grpcsharp_metadata_array_count(IntPtr metadataArray);

			[PreserveSig]
			public static extern IntPtr grpcsharp_metadata_array_get_key(IntPtr metadataArray, UIntPtr index, out UIntPtr keyLength);

			[PreserveSig]
			public static extern IntPtr grpcsharp_metadata_array_get_value(IntPtr metadataArray, UIntPtr index, out UIntPtr valueLength);

			[PreserveSig]
			public static extern void grpcsharp_metadata_array_destroy_full(IntPtr array);

			[PreserveSig]
			public static extern void grpcsharp_redirect_log(GprLogDelegate callback);

			[PreserveSig]
			public static extern void grpcsharp_native_callback_dispatcher_init(NativeCallbackDispatcherCallback dispatcher);

			[PreserveSig]
			public static extern CallCredentialsSafeHandle grpcsharp_metadata_credentials_create_from_plugin(IntPtr nativeCallbackTag);

			[PreserveSig]
			public static extern void grpcsharp_metadata_credentials_notify_from_plugin(IntPtr callbackPtr, IntPtr userData, MetadataArraySafeHandle metadataArray, StatusCode statusCode, string errorDetails);

			[PreserveSig]
			public static extern ServerCredentialsSafeHandle grpcsharp_ssl_server_credentials_create(string pemRootCerts, string[] keyCertPairCertChainArray, string[] keyCertPairPrivateKeyArray, UIntPtr numKeyCertPairs, SslClientCertificateRequestType clientCertificateRequest);

			[PreserveSig]
			public static extern void grpcsharp_server_credentials_release(IntPtr credentials);

			[PreserveSig]
			public static extern ServerSafeHandle grpcsharp_server_create(ChannelArgsSafeHandle args);

			[PreserveSig]
			public static extern void grpcsharp_server_register_completion_queue(ServerSafeHandle server, CompletionQueueSafeHandle cq);

			[PreserveSig]
			public static extern int grpcsharp_server_add_insecure_http2_port(ServerSafeHandle server, string addr);

			[PreserveSig]
			public static extern int grpcsharp_server_add_secure_http2_port(ServerSafeHandle server, string addr, ServerCredentialsSafeHandle creds);

			[PreserveSig]
			public static extern void grpcsharp_server_start(ServerSafeHandle server);

			[PreserveSig]
			public static extern CallError grpcsharp_server_request_call(ServerSafeHandle server, CompletionQueueSafeHandle cq, RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_server_cancel_all_calls(ServerSafeHandle server);

			[PreserveSig]
			public static extern void grpcsharp_server_shutdown_and_notify_callback(ServerSafeHandle server, CompletionQueueSafeHandle cq, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_server_destroy(IntPtr server);

			[PreserveSig]
			public static extern AuthContextSafeHandle grpcsharp_call_auth_context(CallSafeHandle call);

			[PreserveSig]
			public static extern IntPtr grpcsharp_auth_context_peer_identity_property_name(AuthContextSafeHandle authContext);

			[PreserveSig]
			public static extern AuthContextSafeHandle.NativeAuthPropertyIterator grpcsharp_auth_context_property_iterator(AuthContextSafeHandle authContext);

			[PreserveSig]
			public static extern IntPtr grpcsharp_auth_property_iterator_next(ref AuthContextSafeHandle.NativeAuthPropertyIterator iterator);

			[PreserveSig]
			public static extern void grpcsharp_auth_context_release(IntPtr authContext);

			[PreserveSig]
			public static extern SliceBufferSafeHandle grpcsharp_slice_buffer_create();

			[PreserveSig]
			public static extern IntPtr grpcsharp_slice_buffer_adjust_tail_space(SliceBufferSafeHandle sliceBuffer, UIntPtr availableTailSpace, UIntPtr requestedTailSpace);

			[PreserveSig]
			public static extern UIntPtr grpcsharp_slice_buffer_slice_count(SliceBufferSafeHandle sliceBuffer);

			[PreserveSig]
			public static extern void grpcsharp_slice_buffer_slice_peek(SliceBufferSafeHandle sliceBuffer, UIntPtr index, out UIntPtr sliceLen, out IntPtr sliceDataPtr);

			[PreserveSig]
			public static extern void grpcsharp_slice_buffer_reset_and_unref(SliceBufferSafeHandle sliceBuffer);

			[PreserveSig]
			public static extern void grpcsharp_slice_buffer_destroy(IntPtr sliceBuffer);

			[PreserveSig]
			public static extern Timespec gprsharp_now(ClockType clockType);

			[PreserveSig]
			public static extern Timespec gprsharp_inf_future(ClockType clockType);

			[PreserveSig]
			public static extern Timespec gprsharp_inf_past(ClockType clockType);

			[PreserveSig]
			public static extern Timespec gprsharp_convert_clock_type(Timespec t, ClockType targetClock);

			[PreserveSig]
			public static extern int gprsharp_sizeof_timespec();

			[PreserveSig]
			public static extern CallError grpcsharp_test_callback(NativeCallbackTestDelegate callback);

			[PreserveSig]
			public static extern IntPtr grpcsharp_test_nop(IntPtr ptr);

			[PreserveSig]
			public static extern void grpcsharp_test_override_method(string methodName, string variant);

			[PreserveSig]
			public static extern CallError grpcsharp_test_call_start_unary_echo(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
		}

		internal class DllImportsFromSharedLib_x86
		{
			[PreserveSig]
			public static extern void grpcsharp_init();

			[PreserveSig]
			public static extern void grpcsharp_shutdown();

			[PreserveSig]
			public static extern IntPtr grpcsharp_version_string();

			[PreserveSig]
			public static extern BatchContextSafeHandle grpcsharp_batch_context_create();

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_initial_metadata(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_message_length(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern int grpcsharp_batch_context_recv_message_next_slice_peek(BatchContextSafeHandle ctx, out UIntPtr sliceLen, out IntPtr sliceDataPtr);

			[PreserveSig]
			public static extern StatusCode grpcsharp_batch_context_recv_status_on_client_status(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_status_on_client_details(BatchContextSafeHandle ctx, out UIntPtr detailsLength);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_status_on_client_error_string(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_status_on_client_trailing_metadata(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern int grpcsharp_batch_context_recv_close_on_server_cancelled(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_batch_context_reset(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_batch_context_destroy(IntPtr ctx);

			[PreserveSig]
			public static extern RequestCallContextSafeHandle grpcsharp_request_call_context_create();

			[PreserveSig]
			public static extern CallSafeHandle grpcsharp_request_call_context_call(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_request_call_context_method(RequestCallContextSafeHandle ctx, out UIntPtr methodLength);

			[PreserveSig]
			public static extern IntPtr grpcsharp_request_call_context_host(RequestCallContextSafeHandle ctx, out UIntPtr hostLength);

			[PreserveSig]
			public static extern Timespec grpcsharp_request_call_context_deadline(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_request_call_context_request_metadata(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_request_call_context_reset(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_request_call_context_destroy(IntPtr ctx);

			[PreserveSig]
			public static extern CallCredentialsSafeHandle grpcsharp_composite_call_credentials_create(CallCredentialsSafeHandle creds1, CallCredentialsSafeHandle creds2);

			[PreserveSig]
			public static extern void grpcsharp_call_credentials_release(IntPtr credentials);

			[PreserveSig]
			public static extern CallError grpcsharp_call_cancel(CallSafeHandle call);

			[PreserveSig]
			public static extern CallError grpcsharp_call_cancel_with_status(CallSafeHandle call, StatusCode status, string description);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_unary(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_client_streaming(CallSafeHandle call, BatchContextSafeHandle ctx, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_server_streaming(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_duplex_streaming(CallSafeHandle call, BatchContextSafeHandle ctx, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_message(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, int sendEmptyInitialMetadata);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_close_from_client(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_status_from_server(CallSafeHandle call, BatchContextSafeHandle ctx, StatusCode statusCode, IntPtr statusMessage, UIntPtr statusMessageLen, MetadataArraySafeHandle metadataArray, int sendEmptyInitialMetadata, SliceBufferSafeHandle optionalSendBuffer, WriteFlags writeFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_recv_message(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_recv_initial_metadata(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_serverside(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_initial_metadata(CallSafeHandle call, BatchContextSafeHandle ctx, MetadataArraySafeHandle metadataArray);

			[PreserveSig]
			public static extern CallError grpcsharp_call_set_credentials(CallSafeHandle call, CallCredentialsSafeHandle credentials);

			[PreserveSig]
			public static extern CStringSafeHandle grpcsharp_call_get_peer(CallSafeHandle call);

			[PreserveSig]
			public static extern void grpcsharp_call_destroy(IntPtr call);

			[PreserveSig]
			public static extern ChannelArgsSafeHandle grpcsharp_channel_args_create(UIntPtr numArgs);

			[PreserveSig]
			public static extern void grpcsharp_channel_args_set_string(ChannelArgsSafeHandle args, UIntPtr index, string key, string value);

			[PreserveSig]
			public static extern void grpcsharp_channel_args_set_integer(ChannelArgsSafeHandle args, UIntPtr index, string key, int value);

			[PreserveSig]
			public static extern void grpcsharp_channel_args_destroy(IntPtr args);

			[PreserveSig]
			public static extern void grpcsharp_override_default_ssl_roots(string pemRootCerts);

			[PreserveSig]
			public static extern ChannelCredentialsSafeHandle grpcsharp_ssl_credentials_create(string pemRootCerts, string keyCertPairCertChain, string keyCertPairPrivateKey, IntPtr verifyPeerCallbackTag);

			[PreserveSig]
			public static extern ChannelCredentialsSafeHandle grpcsharp_composite_channel_credentials_create(ChannelCredentialsSafeHandle channelCreds, CallCredentialsSafeHandle callCreds);

			[PreserveSig]
			public static extern void grpcsharp_channel_credentials_release(IntPtr credentials);

			[PreserveSig]
			public static extern ChannelSafeHandle grpcsharp_insecure_channel_create(string target, ChannelArgsSafeHandle channelArgs);

			[PreserveSig]
			public static extern ChannelSafeHandle grpcsharp_secure_channel_create(ChannelCredentialsSafeHandle credentials, string target, ChannelArgsSafeHandle channelArgs);

			[PreserveSig]
			public static extern CallSafeHandle grpcsharp_channel_create_call(ChannelSafeHandle channel, CallSafeHandle parentCall, ContextPropagationFlags propagationMask, CompletionQueueSafeHandle cq, string method, string host, Timespec deadline);

			[PreserveSig]
			public static extern ChannelState grpcsharp_channel_check_connectivity_state(ChannelSafeHandle channel, int tryToConnect);

			[PreserveSig]
			public static extern void grpcsharp_channel_watch_connectivity_state(ChannelSafeHandle channel, ChannelState lastObservedState, Timespec deadline, CompletionQueueSafeHandle cq, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CStringSafeHandle grpcsharp_channel_get_target(ChannelSafeHandle call);

			[PreserveSig]
			public static extern void grpcsharp_channel_destroy(IntPtr channel);

			[PreserveSig]
			public static extern int grpcsharp_sizeof_grpc_event();

			[PreserveSig]
			public static extern CompletionQueueSafeHandle grpcsharp_completion_queue_create_async();

			[PreserveSig]
			public static extern CompletionQueueSafeHandle grpcsharp_completion_queue_create_sync();

			[PreserveSig]
			public static extern void grpcsharp_completion_queue_shutdown(CompletionQueueSafeHandle cq);

			[PreserveSig]
			public static extern CompletionQueueEvent grpcsharp_completion_queue_next(CompletionQueueSafeHandle cq);

			[PreserveSig]
			public static extern CompletionQueueEvent grpcsharp_completion_queue_pluck(CompletionQueueSafeHandle cq, IntPtr tag);

			[PreserveSig]
			public static extern void grpcsharp_completion_queue_destroy(IntPtr cq);

			[PreserveSig]
			public static extern void gprsharp_free(IntPtr ptr);

			[PreserveSig]
			public static extern MetadataArraySafeHandle grpcsharp_metadata_array_create(UIntPtr capacity);

			[PreserveSig]
			public static extern void grpcsharp_metadata_array_add(MetadataArraySafeHandle array, string key, byte[] value, UIntPtr valueLength);

			[PreserveSig]
			public static extern UIntPtr grpcsharp_metadata_array_count(IntPtr metadataArray);

			[PreserveSig]
			public static extern IntPtr grpcsharp_metadata_array_get_key(IntPtr metadataArray, UIntPtr index, out UIntPtr keyLength);

			[PreserveSig]
			public static extern IntPtr grpcsharp_metadata_array_get_value(IntPtr metadataArray, UIntPtr index, out UIntPtr valueLength);

			[PreserveSig]
			public static extern void grpcsharp_metadata_array_destroy_full(IntPtr array);

			[PreserveSig]
			public static extern void grpcsharp_redirect_log(GprLogDelegate callback);

			[PreserveSig]
			public static extern void grpcsharp_native_callback_dispatcher_init(NativeCallbackDispatcherCallback dispatcher);

			[PreserveSig]
			public static extern CallCredentialsSafeHandle grpcsharp_metadata_credentials_create_from_plugin(IntPtr nativeCallbackTag);

			[PreserveSig]
			public static extern void grpcsharp_metadata_credentials_notify_from_plugin(IntPtr callbackPtr, IntPtr userData, MetadataArraySafeHandle metadataArray, StatusCode statusCode, string errorDetails);

			[PreserveSig]
			public static extern ServerCredentialsSafeHandle grpcsharp_ssl_server_credentials_create(string pemRootCerts, string[] keyCertPairCertChainArray, string[] keyCertPairPrivateKeyArray, UIntPtr numKeyCertPairs, SslClientCertificateRequestType clientCertificateRequest);

			[PreserveSig]
			public static extern void grpcsharp_server_credentials_release(IntPtr credentials);

			[PreserveSig]
			public static extern ServerSafeHandle grpcsharp_server_create(ChannelArgsSafeHandle args);

			[PreserveSig]
			public static extern void grpcsharp_server_register_completion_queue(ServerSafeHandle server, CompletionQueueSafeHandle cq);

			[PreserveSig]
			public static extern int grpcsharp_server_add_insecure_http2_port(ServerSafeHandle server, string addr);

			[PreserveSig]
			public static extern int grpcsharp_server_add_secure_http2_port(ServerSafeHandle server, string addr, ServerCredentialsSafeHandle creds);

			[PreserveSig]
			public static extern void grpcsharp_server_start(ServerSafeHandle server);

			[PreserveSig]
			public static extern CallError grpcsharp_server_request_call(ServerSafeHandle server, CompletionQueueSafeHandle cq, RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_server_cancel_all_calls(ServerSafeHandle server);

			[PreserveSig]
			public static extern void grpcsharp_server_shutdown_and_notify_callback(ServerSafeHandle server, CompletionQueueSafeHandle cq, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_server_destroy(IntPtr server);

			[PreserveSig]
			public static extern AuthContextSafeHandle grpcsharp_call_auth_context(CallSafeHandle call);

			[PreserveSig]
			public static extern IntPtr grpcsharp_auth_context_peer_identity_property_name(AuthContextSafeHandle authContext);

			[PreserveSig]
			public static extern AuthContextSafeHandle.NativeAuthPropertyIterator grpcsharp_auth_context_property_iterator(AuthContextSafeHandle authContext);

			[PreserveSig]
			public static extern IntPtr grpcsharp_auth_property_iterator_next(ref AuthContextSafeHandle.NativeAuthPropertyIterator iterator);

			[PreserveSig]
			public static extern void grpcsharp_auth_context_release(IntPtr authContext);

			[PreserveSig]
			public static extern SliceBufferSafeHandle grpcsharp_slice_buffer_create();

			[PreserveSig]
			public static extern IntPtr grpcsharp_slice_buffer_adjust_tail_space(SliceBufferSafeHandle sliceBuffer, UIntPtr availableTailSpace, UIntPtr requestedTailSpace);

			[PreserveSig]
			public static extern UIntPtr grpcsharp_slice_buffer_slice_count(SliceBufferSafeHandle sliceBuffer);

			[PreserveSig]
			public static extern void grpcsharp_slice_buffer_slice_peek(SliceBufferSafeHandle sliceBuffer, UIntPtr index, out UIntPtr sliceLen, out IntPtr sliceDataPtr);

			[PreserveSig]
			public static extern void grpcsharp_slice_buffer_reset_and_unref(SliceBufferSafeHandle sliceBuffer);

			[PreserveSig]
			public static extern void grpcsharp_slice_buffer_destroy(IntPtr sliceBuffer);

			[PreserveSig]
			public static extern Timespec gprsharp_now(ClockType clockType);

			[PreserveSig]
			public static extern Timespec gprsharp_inf_future(ClockType clockType);

			[PreserveSig]
			public static extern Timespec gprsharp_inf_past(ClockType clockType);

			[PreserveSig]
			public static extern Timespec gprsharp_convert_clock_type(Timespec t, ClockType targetClock);

			[PreserveSig]
			public static extern int gprsharp_sizeof_timespec();

			[PreserveSig]
			public static extern CallError grpcsharp_test_callback(NativeCallbackTestDelegate callback);

			[PreserveSig]
			public static extern IntPtr grpcsharp_test_nop(IntPtr ptr);

			[PreserveSig]
			public static extern void grpcsharp_test_override_method(string methodName, string variant);

			[PreserveSig]
			public static extern CallError grpcsharp_test_call_start_unary_echo(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
		}

		internal class DllImportsFromSharedLib_x64
		{
			[PreserveSig]
			public static extern void grpcsharp_init();

			[PreserveSig]
			public static extern void grpcsharp_shutdown();

			[PreserveSig]
			public static extern IntPtr grpcsharp_version_string();

			[PreserveSig]
			public static extern BatchContextSafeHandle grpcsharp_batch_context_create();

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_initial_metadata(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_message_length(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern int grpcsharp_batch_context_recv_message_next_slice_peek(BatchContextSafeHandle ctx, out UIntPtr sliceLen, out IntPtr sliceDataPtr);

			[PreserveSig]
			public static extern StatusCode grpcsharp_batch_context_recv_status_on_client_status(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_status_on_client_details(BatchContextSafeHandle ctx, out UIntPtr detailsLength);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_status_on_client_error_string(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_status_on_client_trailing_metadata(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern int grpcsharp_batch_context_recv_close_on_server_cancelled(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_batch_context_reset(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_batch_context_destroy(IntPtr ctx);

			[PreserveSig]
			public static extern RequestCallContextSafeHandle grpcsharp_request_call_context_create();

			[PreserveSig]
			public static extern CallSafeHandle grpcsharp_request_call_context_call(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_request_call_context_method(RequestCallContextSafeHandle ctx, out UIntPtr methodLength);

			[PreserveSig]
			public static extern IntPtr grpcsharp_request_call_context_host(RequestCallContextSafeHandle ctx, out UIntPtr hostLength);

			[PreserveSig]
			public static extern Timespec grpcsharp_request_call_context_deadline(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_request_call_context_request_metadata(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_request_call_context_reset(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_request_call_context_destroy(IntPtr ctx);

			[PreserveSig]
			public static extern CallCredentialsSafeHandle grpcsharp_composite_call_credentials_create(CallCredentialsSafeHandle creds1, CallCredentialsSafeHandle creds2);

			[PreserveSig]
			public static extern void grpcsharp_call_credentials_release(IntPtr credentials);

			[PreserveSig]
			public static extern CallError grpcsharp_call_cancel(CallSafeHandle call);

			[PreserveSig]
			public static extern CallError grpcsharp_call_cancel_with_status(CallSafeHandle call, StatusCode status, string description);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_unary(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_client_streaming(CallSafeHandle call, BatchContextSafeHandle ctx, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_server_streaming(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_duplex_streaming(CallSafeHandle call, BatchContextSafeHandle ctx, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_message(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, int sendEmptyInitialMetadata);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_close_from_client(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_status_from_server(CallSafeHandle call, BatchContextSafeHandle ctx, StatusCode statusCode, IntPtr statusMessage, UIntPtr statusMessageLen, MetadataArraySafeHandle metadataArray, int sendEmptyInitialMetadata, SliceBufferSafeHandle optionalSendBuffer, WriteFlags writeFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_recv_message(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_recv_initial_metadata(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_serverside(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_initial_metadata(CallSafeHandle call, BatchContextSafeHandle ctx, MetadataArraySafeHandle metadataArray);

			[PreserveSig]
			public static extern CallError grpcsharp_call_set_credentials(CallSafeHandle call, CallCredentialsSafeHandle credentials);

			[PreserveSig]
			public static extern CStringSafeHandle grpcsharp_call_get_peer(CallSafeHandle call);

			[PreserveSig]
			public static extern void grpcsharp_call_destroy(IntPtr call);

			[PreserveSig]
			public static extern ChannelArgsSafeHandle grpcsharp_channel_args_create(UIntPtr numArgs);

			[PreserveSig]
			public static extern void grpcsharp_channel_args_set_string(ChannelArgsSafeHandle args, UIntPtr index, string key, string value);

			[PreserveSig]
			public static extern void grpcsharp_channel_args_set_integer(ChannelArgsSafeHandle args, UIntPtr index, string key, int value);

			[PreserveSig]
			public static extern void grpcsharp_channel_args_destroy(IntPtr args);

			[PreserveSig]
			public static extern void grpcsharp_override_default_ssl_roots(string pemRootCerts);

			[PreserveSig]
			public static extern ChannelCredentialsSafeHandle grpcsharp_ssl_credentials_create(string pemRootCerts, string keyCertPairCertChain, string keyCertPairPrivateKey, IntPtr verifyPeerCallbackTag);

			[PreserveSig]
			public static extern ChannelCredentialsSafeHandle grpcsharp_composite_channel_credentials_create(ChannelCredentialsSafeHandle channelCreds, CallCredentialsSafeHandle callCreds);

			[PreserveSig]
			public static extern void grpcsharp_channel_credentials_release(IntPtr credentials);

			[PreserveSig]
			public static extern ChannelSafeHandle grpcsharp_insecure_channel_create(string target, ChannelArgsSafeHandle channelArgs);

			[PreserveSig]
			public static extern ChannelSafeHandle grpcsharp_secure_channel_create(ChannelCredentialsSafeHandle credentials, string target, ChannelArgsSafeHandle channelArgs);

			[PreserveSig]
			public static extern CallSafeHandle grpcsharp_channel_create_call(ChannelSafeHandle channel, CallSafeHandle parentCall, ContextPropagationFlags propagationMask, CompletionQueueSafeHandle cq, string method, string host, Timespec deadline);

			[PreserveSig]
			public static extern ChannelState grpcsharp_channel_check_connectivity_state(ChannelSafeHandle channel, int tryToConnect);

			[PreserveSig]
			public static extern void grpcsharp_channel_watch_connectivity_state(ChannelSafeHandle channel, ChannelState lastObservedState, Timespec deadline, CompletionQueueSafeHandle cq, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CStringSafeHandle grpcsharp_channel_get_target(ChannelSafeHandle call);

			[PreserveSig]
			public static extern void grpcsharp_channel_destroy(IntPtr channel);

			[PreserveSig]
			public static extern int grpcsharp_sizeof_grpc_event();

			[PreserveSig]
			public static extern CompletionQueueSafeHandle grpcsharp_completion_queue_create_async();

			[PreserveSig]
			public static extern CompletionQueueSafeHandle grpcsharp_completion_queue_create_sync();

			[PreserveSig]
			public static extern void grpcsharp_completion_queue_shutdown(CompletionQueueSafeHandle cq);

			[PreserveSig]
			public static extern CompletionQueueEvent grpcsharp_completion_queue_next(CompletionQueueSafeHandle cq);

			[PreserveSig]
			public static extern CompletionQueueEvent grpcsharp_completion_queue_pluck(CompletionQueueSafeHandle cq, IntPtr tag);

			[PreserveSig]
			public static extern void grpcsharp_completion_queue_destroy(IntPtr cq);

			[PreserveSig]
			public static extern void gprsharp_free(IntPtr ptr);

			[PreserveSig]
			public static extern MetadataArraySafeHandle grpcsharp_metadata_array_create(UIntPtr capacity);

			[PreserveSig]
			public static extern void grpcsharp_metadata_array_add(MetadataArraySafeHandle array, string key, byte[] value, UIntPtr valueLength);

			[PreserveSig]
			public static extern UIntPtr grpcsharp_metadata_array_count(IntPtr metadataArray);

			[PreserveSig]
			public static extern IntPtr grpcsharp_metadata_array_get_key(IntPtr metadataArray, UIntPtr index, out UIntPtr keyLength);

			[PreserveSig]
			public static extern IntPtr grpcsharp_metadata_array_get_value(IntPtr metadataArray, UIntPtr index, out UIntPtr valueLength);

			[PreserveSig]
			public static extern void grpcsharp_metadata_array_destroy_full(IntPtr array);

			[PreserveSig]
			public static extern void grpcsharp_redirect_log(GprLogDelegate callback);

			[PreserveSig]
			public static extern void grpcsharp_native_callback_dispatcher_init(NativeCallbackDispatcherCallback dispatcher);

			[PreserveSig]
			public static extern CallCredentialsSafeHandle grpcsharp_metadata_credentials_create_from_plugin(IntPtr nativeCallbackTag);

			[PreserveSig]
			public static extern void grpcsharp_metadata_credentials_notify_from_plugin(IntPtr callbackPtr, IntPtr userData, MetadataArraySafeHandle metadataArray, StatusCode statusCode, string errorDetails);

			[PreserveSig]
			public static extern ServerCredentialsSafeHandle grpcsharp_ssl_server_credentials_create(string pemRootCerts, string[] keyCertPairCertChainArray, string[] keyCertPairPrivateKeyArray, UIntPtr numKeyCertPairs, SslClientCertificateRequestType clientCertificateRequest);

			[PreserveSig]
			public static extern void grpcsharp_server_credentials_release(IntPtr credentials);

			[PreserveSig]
			public static extern ServerSafeHandle grpcsharp_server_create(ChannelArgsSafeHandle args);

			[PreserveSig]
			public static extern void grpcsharp_server_register_completion_queue(ServerSafeHandle server, CompletionQueueSafeHandle cq);

			[PreserveSig]
			public static extern int grpcsharp_server_add_insecure_http2_port(ServerSafeHandle server, string addr);

			[PreserveSig]
			public static extern int grpcsharp_server_add_secure_http2_port(ServerSafeHandle server, string addr, ServerCredentialsSafeHandle creds);

			[PreserveSig]
			public static extern void grpcsharp_server_start(ServerSafeHandle server);

			[PreserveSig]
			public static extern CallError grpcsharp_server_request_call(ServerSafeHandle server, CompletionQueueSafeHandle cq, RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_server_cancel_all_calls(ServerSafeHandle server);

			[PreserveSig]
			public static extern void grpcsharp_server_shutdown_and_notify_callback(ServerSafeHandle server, CompletionQueueSafeHandle cq, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_server_destroy(IntPtr server);

			[PreserveSig]
			public static extern AuthContextSafeHandle grpcsharp_call_auth_context(CallSafeHandle call);

			[PreserveSig]
			public static extern IntPtr grpcsharp_auth_context_peer_identity_property_name(AuthContextSafeHandle authContext);

			[PreserveSig]
			public static extern AuthContextSafeHandle.NativeAuthPropertyIterator grpcsharp_auth_context_property_iterator(AuthContextSafeHandle authContext);

			[PreserveSig]
			public static extern IntPtr grpcsharp_auth_property_iterator_next(ref AuthContextSafeHandle.NativeAuthPropertyIterator iterator);

			[PreserveSig]
			public static extern void grpcsharp_auth_context_release(IntPtr authContext);

			[PreserveSig]
			public static extern SliceBufferSafeHandle grpcsharp_slice_buffer_create();

			[PreserveSig]
			public static extern IntPtr grpcsharp_slice_buffer_adjust_tail_space(SliceBufferSafeHandle sliceBuffer, UIntPtr availableTailSpace, UIntPtr requestedTailSpace);

			[PreserveSig]
			public static extern UIntPtr grpcsharp_slice_buffer_slice_count(SliceBufferSafeHandle sliceBuffer);

			[PreserveSig]
			public static extern void grpcsharp_slice_buffer_slice_peek(SliceBufferSafeHandle sliceBuffer, UIntPtr index, out UIntPtr sliceLen, out IntPtr sliceDataPtr);

			[PreserveSig]
			public static extern void grpcsharp_slice_buffer_reset_and_unref(SliceBufferSafeHandle sliceBuffer);

			[PreserveSig]
			public static extern void grpcsharp_slice_buffer_destroy(IntPtr sliceBuffer);

			[PreserveSig]
			public static extern Timespec gprsharp_now(ClockType clockType);

			[PreserveSig]
			public static extern Timespec gprsharp_inf_future(ClockType clockType);

			[PreserveSig]
			public static extern Timespec gprsharp_inf_past(ClockType clockType);

			[PreserveSig]
			public static extern Timespec gprsharp_convert_clock_type(Timespec t, ClockType targetClock);

			[PreserveSig]
			public static extern int gprsharp_sizeof_timespec();

			[PreserveSig]
			public static extern CallError grpcsharp_test_callback(NativeCallbackTestDelegate callback);

			[PreserveSig]
			public static extern IntPtr grpcsharp_test_nop(IntPtr ptr);

			[PreserveSig]
			public static extern void grpcsharp_test_override_method(string methodName, string variant);

			[PreserveSig]
			public static extern CallError grpcsharp_test_call_start_unary_echo(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
		}

		internal class DllImportsFromSharedLib_x86_dll
		{
			[PreserveSig]
			public static extern void grpcsharp_init();

			[PreserveSig]
			public static extern void grpcsharp_shutdown();

			[PreserveSig]
			public static extern IntPtr grpcsharp_version_string();

			[PreserveSig]
			public static extern BatchContextSafeHandle grpcsharp_batch_context_create();

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_initial_metadata(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_message_length(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern int grpcsharp_batch_context_recv_message_next_slice_peek(BatchContextSafeHandle ctx, out UIntPtr sliceLen, out IntPtr sliceDataPtr);

			[PreserveSig]
			public static extern StatusCode grpcsharp_batch_context_recv_status_on_client_status(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_status_on_client_details(BatchContextSafeHandle ctx, out UIntPtr detailsLength);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_status_on_client_error_string(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_status_on_client_trailing_metadata(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern int grpcsharp_batch_context_recv_close_on_server_cancelled(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_batch_context_reset(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_batch_context_destroy(IntPtr ctx);

			[PreserveSig]
			public static extern RequestCallContextSafeHandle grpcsharp_request_call_context_create();

			[PreserveSig]
			public static extern CallSafeHandle grpcsharp_request_call_context_call(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_request_call_context_method(RequestCallContextSafeHandle ctx, out UIntPtr methodLength);

			[PreserveSig]
			public static extern IntPtr grpcsharp_request_call_context_host(RequestCallContextSafeHandle ctx, out UIntPtr hostLength);

			[PreserveSig]
			public static extern Timespec grpcsharp_request_call_context_deadline(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_request_call_context_request_metadata(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_request_call_context_reset(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_request_call_context_destroy(IntPtr ctx);

			[PreserveSig]
			public static extern CallCredentialsSafeHandle grpcsharp_composite_call_credentials_create(CallCredentialsSafeHandle creds1, CallCredentialsSafeHandle creds2);

			[PreserveSig]
			public static extern void grpcsharp_call_credentials_release(IntPtr credentials);

			[PreserveSig]
			public static extern CallError grpcsharp_call_cancel(CallSafeHandle call);

			[PreserveSig]
			public static extern CallError grpcsharp_call_cancel_with_status(CallSafeHandle call, StatusCode status, string description);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_unary(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_client_streaming(CallSafeHandle call, BatchContextSafeHandle ctx, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_server_streaming(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_duplex_streaming(CallSafeHandle call, BatchContextSafeHandle ctx, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_message(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, int sendEmptyInitialMetadata);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_close_from_client(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_status_from_server(CallSafeHandle call, BatchContextSafeHandle ctx, StatusCode statusCode, IntPtr statusMessage, UIntPtr statusMessageLen, MetadataArraySafeHandle metadataArray, int sendEmptyInitialMetadata, SliceBufferSafeHandle optionalSendBuffer, WriteFlags writeFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_recv_message(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_recv_initial_metadata(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_serverside(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_initial_metadata(CallSafeHandle call, BatchContextSafeHandle ctx, MetadataArraySafeHandle metadataArray);

			[PreserveSig]
			public static extern CallError grpcsharp_call_set_credentials(CallSafeHandle call, CallCredentialsSafeHandle credentials);

			[PreserveSig]
			public static extern CStringSafeHandle grpcsharp_call_get_peer(CallSafeHandle call);

			[PreserveSig]
			public static extern void grpcsharp_call_destroy(IntPtr call);

			[PreserveSig]
			public static extern ChannelArgsSafeHandle grpcsharp_channel_args_create(UIntPtr numArgs);

			[PreserveSig]
			public static extern void grpcsharp_channel_args_set_string(ChannelArgsSafeHandle args, UIntPtr index, string key, string value);

			[PreserveSig]
			public static extern void grpcsharp_channel_args_set_integer(ChannelArgsSafeHandle args, UIntPtr index, string key, int value);

			[PreserveSig]
			public static extern void grpcsharp_channel_args_destroy(IntPtr args);

			[PreserveSig]
			public static extern void grpcsharp_override_default_ssl_roots(string pemRootCerts);

			[PreserveSig]
			public static extern ChannelCredentialsSafeHandle grpcsharp_ssl_credentials_create(string pemRootCerts, string keyCertPairCertChain, string keyCertPairPrivateKey, IntPtr verifyPeerCallbackTag);

			[PreserveSig]
			public static extern ChannelCredentialsSafeHandle grpcsharp_composite_channel_credentials_create(ChannelCredentialsSafeHandle channelCreds, CallCredentialsSafeHandle callCreds);

			[PreserveSig]
			public static extern void grpcsharp_channel_credentials_release(IntPtr credentials);

			[PreserveSig]
			public static extern ChannelSafeHandle grpcsharp_insecure_channel_create(string target, ChannelArgsSafeHandle channelArgs);

			[PreserveSig]
			public static extern ChannelSafeHandle grpcsharp_secure_channel_create(ChannelCredentialsSafeHandle credentials, string target, ChannelArgsSafeHandle channelArgs);

			[PreserveSig]
			public static extern CallSafeHandle grpcsharp_channel_create_call(ChannelSafeHandle channel, CallSafeHandle parentCall, ContextPropagationFlags propagationMask, CompletionQueueSafeHandle cq, string method, string host, Timespec deadline);

			[PreserveSig]
			public static extern ChannelState grpcsharp_channel_check_connectivity_state(ChannelSafeHandle channel, int tryToConnect);

			[PreserveSig]
			public static extern void grpcsharp_channel_watch_connectivity_state(ChannelSafeHandle channel, ChannelState lastObservedState, Timespec deadline, CompletionQueueSafeHandle cq, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CStringSafeHandle grpcsharp_channel_get_target(ChannelSafeHandle call);

			[PreserveSig]
			public static extern void grpcsharp_channel_destroy(IntPtr channel);

			[PreserveSig]
			public static extern int grpcsharp_sizeof_grpc_event();

			[PreserveSig]
			public static extern CompletionQueueSafeHandle grpcsharp_completion_queue_create_async();

			[PreserveSig]
			public static extern CompletionQueueSafeHandle grpcsharp_completion_queue_create_sync();

			[PreserveSig]
			public static extern void grpcsharp_completion_queue_shutdown(CompletionQueueSafeHandle cq);

			[PreserveSig]
			public static extern CompletionQueueEvent grpcsharp_completion_queue_next(CompletionQueueSafeHandle cq);

			[PreserveSig]
			public static extern CompletionQueueEvent grpcsharp_completion_queue_pluck(CompletionQueueSafeHandle cq, IntPtr tag);

			[PreserveSig]
			public static extern void grpcsharp_completion_queue_destroy(IntPtr cq);

			[PreserveSig]
			public static extern void gprsharp_free(IntPtr ptr);

			[PreserveSig]
			public static extern MetadataArraySafeHandle grpcsharp_metadata_array_create(UIntPtr capacity);

			[PreserveSig]
			public static extern void grpcsharp_metadata_array_add(MetadataArraySafeHandle array, string key, byte[] value, UIntPtr valueLength);

			[PreserveSig]
			public static extern UIntPtr grpcsharp_metadata_array_count(IntPtr metadataArray);

			[PreserveSig]
			public static extern IntPtr grpcsharp_metadata_array_get_key(IntPtr metadataArray, UIntPtr index, out UIntPtr keyLength);

			[PreserveSig]
			public static extern IntPtr grpcsharp_metadata_array_get_value(IntPtr metadataArray, UIntPtr index, out UIntPtr valueLength);

			[PreserveSig]
			public static extern void grpcsharp_metadata_array_destroy_full(IntPtr array);

			[PreserveSig]
			public static extern void grpcsharp_redirect_log(GprLogDelegate callback);

			[PreserveSig]
			public static extern void grpcsharp_native_callback_dispatcher_init(NativeCallbackDispatcherCallback dispatcher);

			[PreserveSig]
			public static extern CallCredentialsSafeHandle grpcsharp_metadata_credentials_create_from_plugin(IntPtr nativeCallbackTag);

			[PreserveSig]
			public static extern void grpcsharp_metadata_credentials_notify_from_plugin(IntPtr callbackPtr, IntPtr userData, MetadataArraySafeHandle metadataArray, StatusCode statusCode, string errorDetails);

			[PreserveSig]
			public static extern ServerCredentialsSafeHandle grpcsharp_ssl_server_credentials_create(string pemRootCerts, string[] keyCertPairCertChainArray, string[] keyCertPairPrivateKeyArray, UIntPtr numKeyCertPairs, SslClientCertificateRequestType clientCertificateRequest);

			[PreserveSig]
			public static extern void grpcsharp_server_credentials_release(IntPtr credentials);

			[PreserveSig]
			public static extern ServerSafeHandle grpcsharp_server_create(ChannelArgsSafeHandle args);

			[PreserveSig]
			public static extern void grpcsharp_server_register_completion_queue(ServerSafeHandle server, CompletionQueueSafeHandle cq);

			[PreserveSig]
			public static extern int grpcsharp_server_add_insecure_http2_port(ServerSafeHandle server, string addr);

			[PreserveSig]
			public static extern int grpcsharp_server_add_secure_http2_port(ServerSafeHandle server, string addr, ServerCredentialsSafeHandle creds);

			[PreserveSig]
			public static extern void grpcsharp_server_start(ServerSafeHandle server);

			[PreserveSig]
			public static extern CallError grpcsharp_server_request_call(ServerSafeHandle server, CompletionQueueSafeHandle cq, RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_server_cancel_all_calls(ServerSafeHandle server);

			[PreserveSig]
			public static extern void grpcsharp_server_shutdown_and_notify_callback(ServerSafeHandle server, CompletionQueueSafeHandle cq, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_server_destroy(IntPtr server);

			[PreserveSig]
			public static extern AuthContextSafeHandle grpcsharp_call_auth_context(CallSafeHandle call);

			[PreserveSig]
			public static extern IntPtr grpcsharp_auth_context_peer_identity_property_name(AuthContextSafeHandle authContext);

			[PreserveSig]
			public static extern AuthContextSafeHandle.NativeAuthPropertyIterator grpcsharp_auth_context_property_iterator(AuthContextSafeHandle authContext);

			[PreserveSig]
			public static extern IntPtr grpcsharp_auth_property_iterator_next(ref AuthContextSafeHandle.NativeAuthPropertyIterator iterator);

			[PreserveSig]
			public static extern void grpcsharp_auth_context_release(IntPtr authContext);

			[PreserveSig]
			public static extern SliceBufferSafeHandle grpcsharp_slice_buffer_create();

			[PreserveSig]
			public static extern IntPtr grpcsharp_slice_buffer_adjust_tail_space(SliceBufferSafeHandle sliceBuffer, UIntPtr availableTailSpace, UIntPtr requestedTailSpace);

			[PreserveSig]
			public static extern UIntPtr grpcsharp_slice_buffer_slice_count(SliceBufferSafeHandle sliceBuffer);

			[PreserveSig]
			public static extern void grpcsharp_slice_buffer_slice_peek(SliceBufferSafeHandle sliceBuffer, UIntPtr index, out UIntPtr sliceLen, out IntPtr sliceDataPtr);

			[PreserveSig]
			public static extern void grpcsharp_slice_buffer_reset_and_unref(SliceBufferSafeHandle sliceBuffer);

			[PreserveSig]
			public static extern void grpcsharp_slice_buffer_destroy(IntPtr sliceBuffer);

			[PreserveSig]
			public static extern Timespec gprsharp_now(ClockType clockType);

			[PreserveSig]
			public static extern Timespec gprsharp_inf_future(ClockType clockType);

			[PreserveSig]
			public static extern Timespec gprsharp_inf_past(ClockType clockType);

			[PreserveSig]
			public static extern Timespec gprsharp_convert_clock_type(Timespec t, ClockType targetClock);

			[PreserveSig]
			public static extern int gprsharp_sizeof_timespec();

			[PreserveSig]
			public static extern CallError grpcsharp_test_callback(NativeCallbackTestDelegate callback);

			[PreserveSig]
			public static extern IntPtr grpcsharp_test_nop(IntPtr ptr);

			[PreserveSig]
			public static extern void grpcsharp_test_override_method(string methodName, string variant);

			[PreserveSig]
			public static extern CallError grpcsharp_test_call_start_unary_echo(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
		}

		internal class DllImportsFromSharedLib_x64_dll
		{
			[PreserveSig]
			public static extern void grpcsharp_init();

			[PreserveSig]
			public static extern void grpcsharp_shutdown();

			[PreserveSig]
			public static extern IntPtr grpcsharp_version_string();

			[PreserveSig]
			public static extern BatchContextSafeHandle grpcsharp_batch_context_create();

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_initial_metadata(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_message_length(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern int grpcsharp_batch_context_recv_message_next_slice_peek(BatchContextSafeHandle ctx, out UIntPtr sliceLen, out IntPtr sliceDataPtr);

			[PreserveSig]
			public static extern StatusCode grpcsharp_batch_context_recv_status_on_client_status(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_status_on_client_details(BatchContextSafeHandle ctx, out UIntPtr detailsLength);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_status_on_client_error_string(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_batch_context_recv_status_on_client_trailing_metadata(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern int grpcsharp_batch_context_recv_close_on_server_cancelled(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_batch_context_reset(BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_batch_context_destroy(IntPtr ctx);

			[PreserveSig]
			public static extern RequestCallContextSafeHandle grpcsharp_request_call_context_create();

			[PreserveSig]
			public static extern CallSafeHandle grpcsharp_request_call_context_call(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_request_call_context_method(RequestCallContextSafeHandle ctx, out UIntPtr methodLength);

			[PreserveSig]
			public static extern IntPtr grpcsharp_request_call_context_host(RequestCallContextSafeHandle ctx, out UIntPtr hostLength);

			[PreserveSig]
			public static extern Timespec grpcsharp_request_call_context_deadline(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern IntPtr grpcsharp_request_call_context_request_metadata(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_request_call_context_reset(RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_request_call_context_destroy(IntPtr ctx);

			[PreserveSig]
			public static extern CallCredentialsSafeHandle grpcsharp_composite_call_credentials_create(CallCredentialsSafeHandle creds1, CallCredentialsSafeHandle creds2);

			[PreserveSig]
			public static extern void grpcsharp_call_credentials_release(IntPtr credentials);

			[PreserveSig]
			public static extern CallError grpcsharp_call_cancel(CallSafeHandle call);

			[PreserveSig]
			public static extern CallError grpcsharp_call_cancel_with_status(CallSafeHandle call, StatusCode status, string description);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_unary(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_client_streaming(CallSafeHandle call, BatchContextSafeHandle ctx, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_server_streaming(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_duplex_streaming(CallSafeHandle call, BatchContextSafeHandle ctx, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_message(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, int sendEmptyInitialMetadata);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_close_from_client(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_status_from_server(CallSafeHandle call, BatchContextSafeHandle ctx, StatusCode statusCode, IntPtr statusMessage, UIntPtr statusMessageLen, MetadataArraySafeHandle metadataArray, int sendEmptyInitialMetadata, SliceBufferSafeHandle optionalSendBuffer, WriteFlags writeFlags);

			[PreserveSig]
			public static extern CallError grpcsharp_call_recv_message(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_recv_initial_metadata(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_start_serverside(CallSafeHandle call, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CallError grpcsharp_call_send_initial_metadata(CallSafeHandle call, BatchContextSafeHandle ctx, MetadataArraySafeHandle metadataArray);

			[PreserveSig]
			public static extern CallError grpcsharp_call_set_credentials(CallSafeHandle call, CallCredentialsSafeHandle credentials);

			[PreserveSig]
			public static extern CStringSafeHandle grpcsharp_call_get_peer(CallSafeHandle call);

			[PreserveSig]
			public static extern void grpcsharp_call_destroy(IntPtr call);

			[PreserveSig]
			public static extern ChannelArgsSafeHandle grpcsharp_channel_args_create(UIntPtr numArgs);

			[PreserveSig]
			public static extern void grpcsharp_channel_args_set_string(ChannelArgsSafeHandle args, UIntPtr index, string key, string value);

			[PreserveSig]
			public static extern void grpcsharp_channel_args_set_integer(ChannelArgsSafeHandle args, UIntPtr index, string key, int value);

			[PreserveSig]
			public static extern void grpcsharp_channel_args_destroy(IntPtr args);

			[PreserveSig]
			public static extern void grpcsharp_override_default_ssl_roots(string pemRootCerts);

			[PreserveSig]
			public static extern ChannelCredentialsSafeHandle grpcsharp_ssl_credentials_create(string pemRootCerts, string keyCertPairCertChain, string keyCertPairPrivateKey, IntPtr verifyPeerCallbackTag);

			[PreserveSig]
			public static extern ChannelCredentialsSafeHandle grpcsharp_composite_channel_credentials_create(ChannelCredentialsSafeHandle channelCreds, CallCredentialsSafeHandle callCreds);

			[PreserveSig]
			public static extern void grpcsharp_channel_credentials_release(IntPtr credentials);

			[PreserveSig]
			public static extern ChannelSafeHandle grpcsharp_insecure_channel_create(string target, ChannelArgsSafeHandle channelArgs);

			[PreserveSig]
			public static extern ChannelSafeHandle grpcsharp_secure_channel_create(ChannelCredentialsSafeHandle credentials, string target, ChannelArgsSafeHandle channelArgs);

			[PreserveSig]
			public static extern CallSafeHandle grpcsharp_channel_create_call(ChannelSafeHandle channel, CallSafeHandle parentCall, ContextPropagationFlags propagationMask, CompletionQueueSafeHandle cq, string method, string host, Timespec deadline);

			[PreserveSig]
			public static extern ChannelState grpcsharp_channel_check_connectivity_state(ChannelSafeHandle channel, int tryToConnect);

			[PreserveSig]
			public static extern void grpcsharp_channel_watch_connectivity_state(ChannelSafeHandle channel, ChannelState lastObservedState, Timespec deadline, CompletionQueueSafeHandle cq, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern CStringSafeHandle grpcsharp_channel_get_target(ChannelSafeHandle call);

			[PreserveSig]
			public static extern void grpcsharp_channel_destroy(IntPtr channel);

			[PreserveSig]
			public static extern int grpcsharp_sizeof_grpc_event();

			[PreserveSig]
			public static extern CompletionQueueSafeHandle grpcsharp_completion_queue_create_async();

			[PreserveSig]
			public static extern CompletionQueueSafeHandle grpcsharp_completion_queue_create_sync();

			[PreserveSig]
			public static extern void grpcsharp_completion_queue_shutdown(CompletionQueueSafeHandle cq);

			[PreserveSig]
			public static extern CompletionQueueEvent grpcsharp_completion_queue_next(CompletionQueueSafeHandle cq);

			[PreserveSig]
			public static extern CompletionQueueEvent grpcsharp_completion_queue_pluck(CompletionQueueSafeHandle cq, IntPtr tag);

			[PreserveSig]
			public static extern void grpcsharp_completion_queue_destroy(IntPtr cq);

			[PreserveSig]
			public static extern void gprsharp_free(IntPtr ptr);

			[PreserveSig]
			public static extern MetadataArraySafeHandle grpcsharp_metadata_array_create(UIntPtr capacity);

			[PreserveSig]
			public static extern void grpcsharp_metadata_array_add(MetadataArraySafeHandle array, string key, byte[] value, UIntPtr valueLength);

			[PreserveSig]
			public static extern UIntPtr grpcsharp_metadata_array_count(IntPtr metadataArray);

			[PreserveSig]
			public static extern IntPtr grpcsharp_metadata_array_get_key(IntPtr metadataArray, UIntPtr index, out UIntPtr keyLength);

			[PreserveSig]
			public static extern IntPtr grpcsharp_metadata_array_get_value(IntPtr metadataArray, UIntPtr index, out UIntPtr valueLength);

			[PreserveSig]
			public static extern void grpcsharp_metadata_array_destroy_full(IntPtr array);

			[PreserveSig]
			public static extern void grpcsharp_redirect_log(GprLogDelegate callback);

			[PreserveSig]
			public static extern void grpcsharp_native_callback_dispatcher_init(NativeCallbackDispatcherCallback dispatcher);

			[PreserveSig]
			public static extern CallCredentialsSafeHandle grpcsharp_metadata_credentials_create_from_plugin(IntPtr nativeCallbackTag);

			[PreserveSig]
			public static extern void grpcsharp_metadata_credentials_notify_from_plugin(IntPtr callbackPtr, IntPtr userData, MetadataArraySafeHandle metadataArray, StatusCode statusCode, string errorDetails);

			[PreserveSig]
			public static extern ServerCredentialsSafeHandle grpcsharp_ssl_server_credentials_create(string pemRootCerts, string[] keyCertPairCertChainArray, string[] keyCertPairPrivateKeyArray, UIntPtr numKeyCertPairs, SslClientCertificateRequestType clientCertificateRequest);

			[PreserveSig]
			public static extern void grpcsharp_server_credentials_release(IntPtr credentials);

			[PreserveSig]
			public static extern ServerSafeHandle grpcsharp_server_create(ChannelArgsSafeHandle args);

			[PreserveSig]
			public static extern void grpcsharp_server_register_completion_queue(ServerSafeHandle server, CompletionQueueSafeHandle cq);

			[PreserveSig]
			public static extern int grpcsharp_server_add_insecure_http2_port(ServerSafeHandle server, string addr);

			[PreserveSig]
			public static extern int grpcsharp_server_add_secure_http2_port(ServerSafeHandle server, string addr, ServerCredentialsSafeHandle creds);

			[PreserveSig]
			public static extern void grpcsharp_server_start(ServerSafeHandle server);

			[PreserveSig]
			public static extern CallError grpcsharp_server_request_call(ServerSafeHandle server, CompletionQueueSafeHandle cq, RequestCallContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_server_cancel_all_calls(ServerSafeHandle server);

			[PreserveSig]
			public static extern void grpcsharp_server_shutdown_and_notify_callback(ServerSafeHandle server, CompletionQueueSafeHandle cq, BatchContextSafeHandle ctx);

			[PreserveSig]
			public static extern void grpcsharp_server_destroy(IntPtr server);

			[PreserveSig]
			public static extern AuthContextSafeHandle grpcsharp_call_auth_context(CallSafeHandle call);

			[PreserveSig]
			public static extern IntPtr grpcsharp_auth_context_peer_identity_property_name(AuthContextSafeHandle authContext);

			[PreserveSig]
			public static extern AuthContextSafeHandle.NativeAuthPropertyIterator grpcsharp_auth_context_property_iterator(AuthContextSafeHandle authContext);

			[PreserveSig]
			public static extern IntPtr grpcsharp_auth_property_iterator_next(ref AuthContextSafeHandle.NativeAuthPropertyIterator iterator);

			[PreserveSig]
			public static extern void grpcsharp_auth_context_release(IntPtr authContext);

			[PreserveSig]
			public static extern SliceBufferSafeHandle grpcsharp_slice_buffer_create();

			[PreserveSig]
			public static extern IntPtr grpcsharp_slice_buffer_adjust_tail_space(SliceBufferSafeHandle sliceBuffer, UIntPtr availableTailSpace, UIntPtr requestedTailSpace);

			[PreserveSig]
			public static extern UIntPtr grpcsharp_slice_buffer_slice_count(SliceBufferSafeHandle sliceBuffer);

			[PreserveSig]
			public static extern void grpcsharp_slice_buffer_slice_peek(SliceBufferSafeHandle sliceBuffer, UIntPtr index, out UIntPtr sliceLen, out IntPtr sliceDataPtr);

			[PreserveSig]
			public static extern void grpcsharp_slice_buffer_reset_and_unref(SliceBufferSafeHandle sliceBuffer);

			[PreserveSig]
			public static extern void grpcsharp_slice_buffer_destroy(IntPtr sliceBuffer);

			[PreserveSig]
			public static extern Timespec gprsharp_now(ClockType clockType);

			[PreserveSig]
			public static extern Timespec gprsharp_inf_future(ClockType clockType);

			[PreserveSig]
			public static extern Timespec gprsharp_inf_past(ClockType clockType);

			[PreserveSig]
			public static extern Timespec gprsharp_convert_clock_type(Timespec t, ClockType targetClock);

			[PreserveSig]
			public static extern int gprsharp_sizeof_timespec();

			[PreserveSig]
			public static extern CallError grpcsharp_test_callback(NativeCallbackTestDelegate callback);

			[PreserveSig]
			public static extern IntPtr grpcsharp_test_nop(IntPtr ptr);

			[PreserveSig]
			public static extern void grpcsharp_test_override_method(string methodName, string variant);

			[PreserveSig]
			public static extern CallError grpcsharp_test_call_start_unary_echo(CallSafeHandle call, BatchContextSafeHandle ctx, SliceBufferSafeHandle sendBuffer, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
		}

		public readonly Delegates.grpcsharp_init_delegate grpcsharp_init;

		public readonly Delegates.grpcsharp_shutdown_delegate grpcsharp_shutdown;

		public readonly Delegates.grpcsharp_version_string_delegate grpcsharp_version_string;

		public readonly Delegates.grpcsharp_batch_context_create_delegate grpcsharp_batch_context_create;

		public readonly Delegates.grpcsharp_batch_context_recv_initial_metadata_delegate grpcsharp_batch_context_recv_initial_metadata;

		public readonly Delegates.grpcsharp_batch_context_recv_message_length_delegate grpcsharp_batch_context_recv_message_length;

		public readonly Delegates.grpcsharp_batch_context_recv_message_next_slice_peek_delegate grpcsharp_batch_context_recv_message_next_slice_peek;

		public readonly Delegates.grpcsharp_batch_context_recv_status_on_client_status_delegate grpcsharp_batch_context_recv_status_on_client_status;

		public readonly Delegates.grpcsharp_batch_context_recv_status_on_client_details_delegate grpcsharp_batch_context_recv_status_on_client_details;

		public readonly Delegates.grpcsharp_batch_context_recv_status_on_client_error_string_delegate grpcsharp_batch_context_recv_status_on_client_error_string;

		public readonly Delegates.grpcsharp_batch_context_recv_status_on_client_trailing_metadata_delegate grpcsharp_batch_context_recv_status_on_client_trailing_metadata;

		public readonly Delegates.grpcsharp_batch_context_recv_close_on_server_cancelled_delegate grpcsharp_batch_context_recv_close_on_server_cancelled;

		public readonly Delegates.grpcsharp_batch_context_reset_delegate grpcsharp_batch_context_reset;

		public readonly Delegates.grpcsharp_batch_context_destroy_delegate grpcsharp_batch_context_destroy;

		public readonly Delegates.grpcsharp_request_call_context_create_delegate grpcsharp_request_call_context_create;

		public readonly Delegates.grpcsharp_request_call_context_call_delegate grpcsharp_request_call_context_call;

		public readonly Delegates.grpcsharp_request_call_context_method_delegate grpcsharp_request_call_context_method;

		public readonly Delegates.grpcsharp_request_call_context_host_delegate grpcsharp_request_call_context_host;

		public readonly Delegates.grpcsharp_request_call_context_deadline_delegate grpcsharp_request_call_context_deadline;

		public readonly Delegates.grpcsharp_request_call_context_request_metadata_delegate grpcsharp_request_call_context_request_metadata;

		public readonly Delegates.grpcsharp_request_call_context_reset_delegate grpcsharp_request_call_context_reset;

		public readonly Delegates.grpcsharp_request_call_context_destroy_delegate grpcsharp_request_call_context_destroy;

		public readonly Delegates.grpcsharp_composite_call_credentials_create_delegate grpcsharp_composite_call_credentials_create;

		public readonly Delegates.grpcsharp_call_credentials_release_delegate grpcsharp_call_credentials_release;

		public readonly Delegates.grpcsharp_call_cancel_delegate grpcsharp_call_cancel;

		public readonly Delegates.grpcsharp_call_cancel_with_status_delegate grpcsharp_call_cancel_with_status;

		public readonly Delegates.grpcsharp_call_start_unary_delegate grpcsharp_call_start_unary;

		public readonly Delegates.grpcsharp_call_start_client_streaming_delegate grpcsharp_call_start_client_streaming;

		public readonly Delegates.grpcsharp_call_start_server_streaming_delegate grpcsharp_call_start_server_streaming;

		public readonly Delegates.grpcsharp_call_start_duplex_streaming_delegate grpcsharp_call_start_duplex_streaming;

		public readonly Delegates.grpcsharp_call_send_message_delegate grpcsharp_call_send_message;

		public readonly Delegates.grpcsharp_call_send_close_from_client_delegate grpcsharp_call_send_close_from_client;

		public readonly Delegates.grpcsharp_call_send_status_from_server_delegate grpcsharp_call_send_status_from_server;

		public readonly Delegates.grpcsharp_call_recv_message_delegate grpcsharp_call_recv_message;

		public readonly Delegates.grpcsharp_call_recv_initial_metadata_delegate grpcsharp_call_recv_initial_metadata;

		public readonly Delegates.grpcsharp_call_start_serverside_delegate grpcsharp_call_start_serverside;

		public readonly Delegates.grpcsharp_call_send_initial_metadata_delegate grpcsharp_call_send_initial_metadata;

		public readonly Delegates.grpcsharp_call_set_credentials_delegate grpcsharp_call_set_credentials;

		public readonly Delegates.grpcsharp_call_get_peer_delegate grpcsharp_call_get_peer;

		public readonly Delegates.grpcsharp_call_destroy_delegate grpcsharp_call_destroy;

		public readonly Delegates.grpcsharp_channel_args_create_delegate grpcsharp_channel_args_create;

		public readonly Delegates.grpcsharp_channel_args_set_string_delegate grpcsharp_channel_args_set_string;

		public readonly Delegates.grpcsharp_channel_args_set_integer_delegate grpcsharp_channel_args_set_integer;

		public readonly Delegates.grpcsharp_channel_args_destroy_delegate grpcsharp_channel_args_destroy;

		public readonly Delegates.grpcsharp_override_default_ssl_roots_delegate grpcsharp_override_default_ssl_roots;

		public readonly Delegates.grpcsharp_ssl_credentials_create_delegate grpcsharp_ssl_credentials_create;

		public readonly Delegates.grpcsharp_composite_channel_credentials_create_delegate grpcsharp_composite_channel_credentials_create;

		public readonly Delegates.grpcsharp_channel_credentials_release_delegate grpcsharp_channel_credentials_release;

		public readonly Delegates.grpcsharp_insecure_channel_create_delegate grpcsharp_insecure_channel_create;

		public readonly Delegates.grpcsharp_secure_channel_create_delegate grpcsharp_secure_channel_create;

		public readonly Delegates.grpcsharp_channel_create_call_delegate grpcsharp_channel_create_call;

		public readonly Delegates.grpcsharp_channel_check_connectivity_state_delegate grpcsharp_channel_check_connectivity_state;

		public readonly Delegates.grpcsharp_channel_watch_connectivity_state_delegate grpcsharp_channel_watch_connectivity_state;

		public readonly Delegates.grpcsharp_channel_get_target_delegate grpcsharp_channel_get_target;

		public readonly Delegates.grpcsharp_channel_destroy_delegate grpcsharp_channel_destroy;

		public readonly Delegates.grpcsharp_sizeof_grpc_event_delegate grpcsharp_sizeof_grpc_event;

		public readonly Delegates.grpcsharp_completion_queue_create_async_delegate grpcsharp_completion_queue_create_async;

		public readonly Delegates.grpcsharp_completion_queue_create_sync_delegate grpcsharp_completion_queue_create_sync;

		public readonly Delegates.grpcsharp_completion_queue_shutdown_delegate grpcsharp_completion_queue_shutdown;

		public readonly Delegates.grpcsharp_completion_queue_next_delegate grpcsharp_completion_queue_next;

		public readonly Delegates.grpcsharp_completion_queue_pluck_delegate grpcsharp_completion_queue_pluck;

		public readonly Delegates.grpcsharp_completion_queue_destroy_delegate grpcsharp_completion_queue_destroy;

		public readonly Delegates.gprsharp_free_delegate gprsharp_free;

		public readonly Delegates.grpcsharp_metadata_array_create_delegate grpcsharp_metadata_array_create;

		public readonly Delegates.grpcsharp_metadata_array_add_delegate grpcsharp_metadata_array_add;

		public readonly Delegates.grpcsharp_metadata_array_count_delegate grpcsharp_metadata_array_count;

		public readonly Delegates.grpcsharp_metadata_array_get_key_delegate grpcsharp_metadata_array_get_key;

		public readonly Delegates.grpcsharp_metadata_array_get_value_delegate grpcsharp_metadata_array_get_value;

		public readonly Delegates.grpcsharp_metadata_array_destroy_full_delegate grpcsharp_metadata_array_destroy_full;

		public readonly Delegates.grpcsharp_redirect_log_delegate grpcsharp_redirect_log;

		public readonly Delegates.grpcsharp_native_callback_dispatcher_init_delegate grpcsharp_native_callback_dispatcher_init;

		public readonly Delegates.grpcsharp_metadata_credentials_create_from_plugin_delegate grpcsharp_metadata_credentials_create_from_plugin;

		public readonly Delegates.grpcsharp_metadata_credentials_notify_from_plugin_delegate grpcsharp_metadata_credentials_notify_from_plugin;

		public readonly Delegates.grpcsharp_ssl_server_credentials_create_delegate grpcsharp_ssl_server_credentials_create;

		public readonly Delegates.grpcsharp_server_credentials_release_delegate grpcsharp_server_credentials_release;

		public readonly Delegates.grpcsharp_server_create_delegate grpcsharp_server_create;

		public readonly Delegates.grpcsharp_server_register_completion_queue_delegate grpcsharp_server_register_completion_queue;

		public readonly Delegates.grpcsharp_server_add_insecure_http2_port_delegate grpcsharp_server_add_insecure_http2_port;

		public readonly Delegates.grpcsharp_server_add_secure_http2_port_delegate grpcsharp_server_add_secure_http2_port;

		public readonly Delegates.grpcsharp_server_start_delegate grpcsharp_server_start;

		public readonly Delegates.grpcsharp_server_request_call_delegate grpcsharp_server_request_call;

		public readonly Delegates.grpcsharp_server_cancel_all_calls_delegate grpcsharp_server_cancel_all_calls;

		public readonly Delegates.grpcsharp_server_shutdown_and_notify_callback_delegate grpcsharp_server_shutdown_and_notify_callback;

		public readonly Delegates.grpcsharp_server_destroy_delegate grpcsharp_server_destroy;

		public readonly Delegates.grpcsharp_call_auth_context_delegate grpcsharp_call_auth_context;

		public readonly Delegates.grpcsharp_auth_context_peer_identity_property_name_delegate grpcsharp_auth_context_peer_identity_property_name;

		public readonly Delegates.grpcsharp_auth_context_property_iterator_delegate grpcsharp_auth_context_property_iterator;

		public readonly Delegates.grpcsharp_auth_property_iterator_next_delegate grpcsharp_auth_property_iterator_next;

		public readonly Delegates.grpcsharp_auth_context_release_delegate grpcsharp_auth_context_release;

		public readonly Delegates.grpcsharp_slice_buffer_create_delegate grpcsharp_slice_buffer_create;

		public readonly Delegates.grpcsharp_slice_buffer_adjust_tail_space_delegate grpcsharp_slice_buffer_adjust_tail_space;

		public readonly Delegates.grpcsharp_slice_buffer_slice_count_delegate grpcsharp_slice_buffer_slice_count;

		public readonly Delegates.grpcsharp_slice_buffer_slice_peek_delegate grpcsharp_slice_buffer_slice_peek;

		public readonly Delegates.grpcsharp_slice_buffer_reset_and_unref_delegate grpcsharp_slice_buffer_reset_and_unref;

		public readonly Delegates.grpcsharp_slice_buffer_destroy_delegate grpcsharp_slice_buffer_destroy;

		public readonly Delegates.gprsharp_now_delegate gprsharp_now;

		public readonly Delegates.gprsharp_inf_future_delegate gprsharp_inf_future;

		public readonly Delegates.gprsharp_inf_past_delegate gprsharp_inf_past;

		public readonly Delegates.gprsharp_convert_clock_type_delegate gprsharp_convert_clock_type;

		public readonly Delegates.gprsharp_sizeof_timespec_delegate gprsharp_sizeof_timespec;

		public readonly Delegates.grpcsharp_test_callback_delegate grpcsharp_test_callback;

		public readonly Delegates.grpcsharp_test_nop_delegate grpcsharp_test_nop;

		public readonly Delegates.grpcsharp_test_override_method_delegate grpcsharp_test_override_method;

		public readonly Delegates.grpcsharp_test_call_start_unary_echo_delegate grpcsharp_test_call_start_unary_echo;

		public static NativeMethods Get()
		{
			return null;
		}

		private static T GetMethodDelegate<T>(UnmanagedLibrary library) where T : class
		{
			return null;
		}

		private static string RemoveStringSuffix(string str, string toRemove)
		{
			return null;
		}

		public NativeMethods(UnmanagedLibrary library)
		{
		}

		public NativeMethods(DllImportsFromStaticLib unusedInstance)
		{
		}

		public NativeMethods(DllImportsFromSharedLib unusedInstance)
		{
		}

		public NativeMethods(DllImportsFromSharedLib_x86 unusedInstance)
		{
		}

		public NativeMethods(DllImportsFromSharedLib_x64 unusedInstance)
		{
		}

		public NativeMethods(DllImportsFromSharedLib_x86_dll unusedInstance)
		{
		}

		public NativeMethods(DllImportsFromSharedLib_x64_dll unusedInstance)
		{
		}
	}
}
