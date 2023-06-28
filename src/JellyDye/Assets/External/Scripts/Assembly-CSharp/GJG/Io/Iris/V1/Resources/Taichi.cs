using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.V1.Resources
{
	public sealed class Taichi : IMessage<Taichi>, IMessage, IEquatable<Taichi>, IDeepCloneable<Taichi>, IBufferMessage
	{
		private static readonly MessageParser<Taichi> _parser;

		private UnknownFieldSet _unknownFields;

		public const int FirebaseS2SApiSecretFieldNumber = 1;

		private string firebaseS2SApiSecret_;

		public const int LinkIdFieldNumber = 2;

		private string linkId_;

		public const int EnableTroasFieldNumber = 3;

		private bool enableTroas_;

		public const int EnableTainiFieldNumber = 4;

		private bool enableTaini_;

		public const int EnableTaisanFieldNumber = 5;

		private bool enableTaisan_;

		public const int RulesTainiFieldNumber = 6;

		private static readonly FieldCodec<Taini> _repeated_rulesTaini_codec;

		private readonly RepeatedField<Taini> rulesTaini_;

		[DebuggerNonUserCode]
		public static MessageParser<Taichi> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string FirebaseS2SApiSecret
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
		public string LinkId
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
		public bool EnableTroas
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool EnableTaini
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool EnableTaisan
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<Taini> RulesTaini => null;

		[DebuggerNonUserCode]
		public Taichi()
		{
		}

		[DebuggerNonUserCode]
		public Taichi(Taichi other)
		{
		}

		[DebuggerNonUserCode]
		public Taichi Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Taichi other)
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
		public void MergeFrom(Taichi other)
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
