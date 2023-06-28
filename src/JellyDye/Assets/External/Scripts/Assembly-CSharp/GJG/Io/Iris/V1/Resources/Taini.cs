using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.V1.Resources
{
	public sealed class Taini : IMessage<Taini>, IMessage, IEquatable<Taini>, IDeepCloneable<Taini>, IBufferMessage
	{
		private static readonly MessageParser<Taini> _parser;

		private UnknownFieldSet _unknownFields;

		public const int CountryFieldNumber = 1;

		private CountryCode country_;

		public const int PercentileFieldNumber = 2;

		private double percentile_;

		public const int PeriodFieldNumber = 3;

		private long period_;

		[DebuggerNonUserCode]
		public static MessageParser<Taini> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public CountryCode Country
		{
			get
			{
				return default(CountryCode);
			}
			set
			{
			}
		}

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
		public long Period
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
		public Taini()
		{
		}

		[DebuggerNonUserCode]
		public Taini(Taini other)
		{
		}

		[DebuggerNonUserCode]
		public Taini Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Taini other)
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
		public void MergeFrom(Taini other)
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
