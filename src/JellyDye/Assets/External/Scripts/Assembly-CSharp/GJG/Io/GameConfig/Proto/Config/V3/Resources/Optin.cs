using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gjg.Io.GameConfig.Proto.Config.V3.Resources
{
	public sealed class Optin : IMessage<Optin>, IMessage, IEquatable<Optin>, IDeepCloneable<Optin>, IBufferMessage
	{
		private static readonly MessageParser<Optin> _parser;

		private UnknownFieldSet _unknownFields;

		public const int IdFieldNumber = 1;

		private string id_;

		public const int ConfigsFieldNumber = 2;

		private static readonly FieldCodec<OptinConfig> _repeated_configs_codec;

		private readonly RepeatedField<OptinConfig> configs_;

		public const int TextsFieldNumber = 3;

		private static readonly FieldCodec<OptinText> _repeated_texts_codec;

		private readonly RepeatedField<OptinText> texts_;

		[DebuggerNonUserCode]
		public static MessageParser<Optin> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string Id
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
		public RepeatedField<OptinConfig> Configs => null;

		[DebuggerNonUserCode]
		public RepeatedField<OptinText> Texts => null;

		[DebuggerNonUserCode]
		public Optin()
		{
		}

		[DebuggerNonUserCode]
		public Optin(Optin other)
		{
		}

		[DebuggerNonUserCode]
		public Optin Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Optin other)
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
		public void MergeFrom(Optin other)
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
