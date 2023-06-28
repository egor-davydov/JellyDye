using System;
using System.Diagnostics;
using Gjg.Io.GameConfig.Proto.Stepback.V2.Resources;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.GameConfig.Proto.Stepback.V2.Services
{
	public sealed class CreateStepbackConfigRequest : IMessage<CreateStepbackConfigRequest>, IMessage, IEquatable<CreateStepbackConfigRequest>, IDeepCloneable<CreateStepbackConfigRequest>, IBufferMessage
	{
		private static readonly MessageParser<CreateStepbackConfigRequest> _parser;

		private UnknownFieldSet _unknownFields;

		public const int AppBundleIdFieldNumber = 1;

		private string appBundleId_;

		public const int OsFieldNumber = 2;

		private string os_;

		public const int CountryCodeFieldNumber = 3;

		private string countryCode_;

		public const int ConfigFieldNumber = 4;

		private Gjg.Io.GameConfig.Proto.Stepback.V2.Resources.Config config_;

		[DebuggerNonUserCode]
		public static MessageParser<CreateStepbackConfigRequest> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string AppBundleId
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
		public string Os
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
		public string CountryCode
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
		public CreateStepbackConfigRequest()
		{
		}

		[DebuggerNonUserCode]
		public CreateStepbackConfigRequest(CreateStepbackConfigRequest other)
		{
		}

		[DebuggerNonUserCode]
		public CreateStepbackConfigRequest Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(CreateStepbackConfigRequest other)
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
		public void MergeFrom(CreateStepbackConfigRequest other)
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
