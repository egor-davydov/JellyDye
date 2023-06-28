using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.GameConfig.Proto.Config.V5.Resources
{
	public sealed class Threshold : IMessage<Threshold>, IMessage, IEquatable<Threshold>, IDeepCloneable<Threshold>, IBufferMessage
	{
		private static readonly MessageParser<Threshold> _parser;

		private UnknownFieldSet _unknownFields;

		public const int PercentileFieldNumber = 1;

		private double percentile_;

		public const int ValueFieldNumber = 2;

		private double value_;

		[DebuggerNonUserCode]
		public static MessageParser<Threshold> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public double Percentile
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public double Value
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public Threshold()
		{
		}

		[DebuggerNonUserCode]
		public Threshold(Threshold other)
		{
		}

		[DebuggerNonUserCode]
		public Threshold Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Threshold other)
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
		public void MergeFrom(Threshold other)
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
