using System;
using System.Diagnostics;
using Gjg.Io.GameConfig.Proto.Config.V3.Resources;
using Gjg.Io.GameConfig.Proto.Stepback.V2.Resources;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.GameConfig.Proto.Config.V4.Resources
{
	public sealed class Config : IMessage<Config>, IMessage, IEquatable<Config>, IDeepCloneable<Config>, IBufferMessage
	{
		private static readonly MessageParser<Config> _parser;

		private UnknownFieldSet _unknownFields;

		public const int GameFieldNumber = 1;

		private GameConfig game_;

		public const int StepbackFieldNumber = 2;

		private Gjg.Io.GameConfig.Proto.Stepback.V2.Resources.Config stepback_;

		public const int OptinFieldNumber = 3;

		private Optin optin_;

		public const int GdprFieldNumber = 4;

		private ConsentResponse gdpr_;

		[DebuggerNonUserCode]
		public static MessageParser<Config> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public GameConfig Game
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
		public Gjg.Io.GameConfig.Proto.Stepback.V2.Resources.Config Stepback
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
		public Optin Optin
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
		public ConsentResponse Gdpr
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
		public Config()
		{
		}

		[DebuggerNonUserCode]
		public Config(Config other)
		{
		}

		[DebuggerNonUserCode]
		public Config Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Config other)
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
		public void MergeFrom(Config other)
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
