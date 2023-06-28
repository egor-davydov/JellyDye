using System;
using System.Diagnostics;
using Gjg.Io.Scio.Core.Event;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Scio.Client.Event
{
	public sealed class UpdateSegmentRequest : IMessage<UpdateSegmentRequest>, IMessage, IEquatable<UpdateSegmentRequest>, IDeepCloneable<UpdateSegmentRequest>, IBufferMessage
	{
		public enum OperationOneofCase
		{
			None = 0,
			DisableSegment = 4,
			EnableSegment = 5,
			AddReceiverNetwork = 6,
			RemoveReceiverNetwork = 7
		}

		private static readonly MessageParser<UpdateSegmentRequest> _parser;

		private UnknownFieldSet _unknownFields;

		public const int SegmentIdFieldNumber = 1;

		private string segmentId_;

		public const int BundleIdFieldNumber = 2;

		private string bundleId_;

		public const int PlatformFieldNumber = 3;

		private Platform platform_;

		public const int DisableSegmentFieldNumber = 4;

		public const int EnableSegmentFieldNumber = 5;

		public const int AddReceiverNetworkFieldNumber = 6;

		public const int RemoveReceiverNetworkFieldNumber = 7;

		private object operation_;

		private OperationOneofCase operationCase_;

		[DebuggerNonUserCode]
		public static MessageParser<UpdateSegmentRequest> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string SegmentId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string BundleId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public Platform Platform
		{
			get
			{
				return default(Platform);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public DisableSegmentOperation DisableSegment
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public EnableSegmentOperation EnableSegment
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public AddReceiverNetworkOperation AddReceiverNetwork
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public DeleteReceiverNetworkOperation RemoveReceiverNetwork
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public OperationOneofCase OperationCase => default(OperationOneofCase);

		[DebuggerNonUserCode]
		public UpdateSegmentRequest()
		{
		}

		[DebuggerNonUserCode]
		public UpdateSegmentRequest(UpdateSegmentRequest other)
		{
		}

		[DebuggerNonUserCode]
		public UpdateSegmentRequest Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public void ClearOperation()
		{
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(UpdateSegmentRequest other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[DebuggerNonUserCode]
		private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
		{
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(UpdateSegmentRequest other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[DebuggerNonUserCode]
		private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
		{
		}
	}
}
