using System;
using System.Diagnostics;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	public sealed class GeneratedCodeInfo : IMessage<GeneratedCodeInfo>, IMessage, IEquatable<GeneratedCodeInfo>, IDeepCloneable<GeneratedCodeInfo>, IBufferMessage
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public sealed class Annotation : IMessage<Annotation>, IMessage, IEquatable<Annotation>, IDeepCloneable<Annotation>, IBufferMessage
			{
				private static readonly MessageParser<Annotation> _parser;

				private UnknownFieldSet _unknownFields;

				private int _hasBits0;

				private static readonly FieldCodec<int> _repeated_path_codec;

				private readonly RepeatedField<int> path_;

				private static readonly string SourceFileDefaultValue;

				private string sourceFile_;

				private static readonly int BeginDefaultValue;

				private int begin_;

				private static readonly int EndDefaultValue;

				private int end_;

				[DebuggerNonUserCode]
				public static MessageParser<Annotation> Parser => null;

				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor => null;

				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

				[DebuggerNonUserCode]
				public string SourceFile
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
				public bool HasSourceFile => false;

				[DebuggerNonUserCode]
				public int Begin
				{
					get
					{
						return 0;
					}
					set
					{
					}
				}

				[DebuggerNonUserCode]
				public bool HasBegin => false;

				[DebuggerNonUserCode]
				public int End
				{
					get
					{
						return 0;
					}
					set
					{
					}
				}

				[DebuggerNonUserCode]
				public bool HasEnd => false;

				[DebuggerNonUserCode]
				public Annotation()
				{
				}

				[DebuggerNonUserCode]
				public Annotation(Annotation other)
				{
				}

				[DebuggerNonUserCode]
				public Annotation Clone()
				{
					return null;
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return false;
				}

				[DebuggerNonUserCode]
				public bool Equals(Annotation other)
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
				public void MergeFrom(Annotation other)
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

		private static readonly MessageParser<GeneratedCodeInfo> _parser;

		private UnknownFieldSet _unknownFields;

		private static readonly FieldCodec<Types.Annotation> _repeated_annotation_codec;

		private readonly RepeatedField<Types.Annotation> annotation_;

		[DebuggerNonUserCode]
		public static MessageParser<GeneratedCodeInfo> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public GeneratedCodeInfo()
		{
		}

		[DebuggerNonUserCode]
		public GeneratedCodeInfo(GeneratedCodeInfo other)
		{
		}

		[DebuggerNonUserCode]
		public GeneratedCodeInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(GeneratedCodeInfo other)
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
		public void MergeFrom(GeneratedCodeInfo other)
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
