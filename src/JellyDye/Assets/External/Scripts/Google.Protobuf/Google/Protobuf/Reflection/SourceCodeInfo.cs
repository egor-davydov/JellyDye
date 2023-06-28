using System;
using System.Diagnostics;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	public sealed class SourceCodeInfo : IMessage<SourceCodeInfo>, IMessage, IEquatable<SourceCodeInfo>, IDeepCloneable<SourceCodeInfo>, IBufferMessage
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public sealed class Location : IMessage<Location>, IMessage, IEquatable<Location>, IDeepCloneable<Location>, IBufferMessage
			{
				private static readonly MessageParser<Location> _parser;

				private UnknownFieldSet _unknownFields;

				private static readonly FieldCodec<int> _repeated_path_codec;

				private readonly RepeatedField<int> path_;

				private static readonly FieldCodec<int> _repeated_span_codec;

				private readonly RepeatedField<int> span_;

				private static readonly string LeadingCommentsDefaultValue;

				private string leadingComments_;

				private static readonly string TrailingCommentsDefaultValue;

				private string trailingComments_;

				private static readonly FieldCodec<string> _repeated_leadingDetachedComments_codec;

				private readonly RepeatedField<string> leadingDetachedComments_;

				[DebuggerNonUserCode]
				public static MessageParser<Location> Parser => null;

				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor => null;

				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

				[DebuggerNonUserCode]
				public RepeatedField<int> Path => null;

				[DebuggerNonUserCode]
				public RepeatedField<int> Span => null;

				[DebuggerNonUserCode]
				public string LeadingComments
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
				public bool HasLeadingComments => false;

				[DebuggerNonUserCode]
				public string TrailingComments
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
				public bool HasTrailingComments => false;

				[DebuggerNonUserCode]
				public RepeatedField<string> LeadingDetachedComments => null;

				[DebuggerNonUserCode]
				public Location()
				{
				}

				[DebuggerNonUserCode]
				public Location(Location other)
				{
				}

				[DebuggerNonUserCode]
				public Location Clone()
				{
					return null;
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return false;
				}

				[DebuggerNonUserCode]
				public bool Equals(Location other)
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
				public void MergeFrom(Location other)
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

		private static readonly MessageParser<SourceCodeInfo> _parser;

		private UnknownFieldSet _unknownFields;

		private static readonly FieldCodec<Types.Location> _repeated_location_codec;

		private readonly RepeatedField<Types.Location> location_;

		[DebuggerNonUserCode]
		public static MessageParser<SourceCodeInfo> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public RepeatedField<Types.Location> Location => null;

		[DebuggerNonUserCode]
		public SourceCodeInfo()
		{
		}

		[DebuggerNonUserCode]
		public SourceCodeInfo(SourceCodeInfo other)
		{
		}

		[DebuggerNonUserCode]
		public SourceCodeInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(SourceCodeInfo other)
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
		public void MergeFrom(SourceCodeInfo other)
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
