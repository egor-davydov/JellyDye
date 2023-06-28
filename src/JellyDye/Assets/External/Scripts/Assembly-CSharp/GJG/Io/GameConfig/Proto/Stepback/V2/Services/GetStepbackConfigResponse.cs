using System;
using System.Diagnostics;
using Gjg.Io.GameConfig.Proto.Stepback.V2.Resources;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.GameConfig.Proto.Stepback.V2.Services
{
	public sealed class GetStepbackConfigResponse : IMessage<GetStepbackConfigResponse>, IMessage, IEquatable<GetStepbackConfigResponse>, IDeepCloneable<GetStepbackConfigResponse>, IBufferMessage
	{
		private static readonly MessageParser<GetStepbackConfigResponse> _parser;

		private UnknownFieldSet _unknownFields;

		public const int ConfigFieldNumber = 1;

		private Gjg.Io.GameConfig.Proto.Stepback.V2.Resources.Config config_;

		[DebuggerNonUserCode]
		public static MessageParser<GetStepbackConfigResponse> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public Gjg.Io.GameConfig.Proto.Stepback.V2.Resources.Config Config
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
		public GetStepbackConfigResponse()
		{
		}

		[DebuggerNonUserCode]
		public GetStepbackConfigResponse(GetStepbackConfigResponse other)
		{
		}

		[DebuggerNonUserCode]
		public GetStepbackConfigResponse Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(GetStepbackConfigResponse other)
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
		public void MergeFrom(GetStepbackConfigResponse other)
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
