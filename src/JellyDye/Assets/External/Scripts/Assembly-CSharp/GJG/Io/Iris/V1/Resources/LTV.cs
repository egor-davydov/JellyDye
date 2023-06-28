using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.V1.Resources
{
	public sealed class LTV : IMessage<LTV>, IMessage, IEquatable<LTV>, IDeepCloneable<LTV>, IBufferMessage
	{
		private static readonly MessageParser<LTV> _parser;

		private UnknownFieldSet _unknownFields;

		public const int XFieldNumber = 1;

		private double x_;

		public const int ThreeDivZeroFieldNumber = 2;

		private double threeDivZero_;

		public const int OrganicSourceFieldNumber = 3;

		private double organicSource_;

		public const int OrganicCountryFieldNumber = 4;

		private double organicCountry_;

		public const int MinInstallsFieldNumber = 5;

		private long minInstalls_;

		[DebuggerNonUserCode]
		public static MessageParser<LTV> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public double X
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
		public double ThreeDivZero
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
		public double OrganicSource
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
		public double OrganicCountry
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
		public long MinInstalls
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
		public LTV()
		{
		}

		[DebuggerNonUserCode]
		public LTV(LTV other)
		{
		}

		[DebuggerNonUserCode]
		public LTV Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(LTV other)
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
		public void MergeFrom(LTV other)
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
