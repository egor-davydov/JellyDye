using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gjg.Io.GameConfig.Proto.Config.V3.Resources
{
	public sealed class Data : IMessage<Data>, IMessage, IEquatable<Data>, IDeepCloneable<Data>, IBufferMessage
	{
		private static readonly MessageParser<Data> _parser;

		private UnknownFieldSet _unknownFields;

		public const int ButtonsFieldNumber = 1;

		private static readonly FieldCodec<DataButton> _repeated_buttons_codec;

		private readonly RepeatedField<DataButton> buttons_;

		public const int ExtrasFieldNumber = 2;

		private static readonly FieldCodec<DataExtra> _repeated_extras_codec;

		private readonly RepeatedField<DataExtra> extras_;

		public const int TextIdFieldNumber = 3;

		private long textId_;

		[DebuggerNonUserCode]
		public static MessageParser<Data> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public RepeatedField<DataButton> Buttons => null;

		[DebuggerNonUserCode]
		public RepeatedField<DataExtra> Extras => null;

		[DebuggerNonUserCode]
		public long TextId
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public Data()
		{
		}

		[DebuggerNonUserCode]
		public Data(Data other)
		{
		}

		[DebuggerNonUserCode]
		public Data Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Data other)
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
		public void MergeFrom(Data other)
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
