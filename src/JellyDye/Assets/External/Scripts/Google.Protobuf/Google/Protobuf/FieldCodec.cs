using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	public static class FieldCodec
	{
		public static FieldCodec<string> ForString(uint tag)
		{
			return null;
		}

		public static FieldCodec<int> ForInt32(uint tag)
		{
			return null;
		}

		public static FieldCodec<string> ForString(uint tag, string defaultValue)
		{
			return null;
		}

		public static FieldCodec<int> ForInt32(uint tag, int defaultValue)
		{
			return null;
		}

		public static FieldCodec<T> ForMessage<T>(uint tag, MessageParser<T> parser) where T : class, IMessage<T>
		{
			return null;
		}
	}
	public sealed class FieldCodec<T>
	{
		internal delegate void InputMerger(ref ParseContext ctx, ref T value);

		internal delegate bool ValuesMerger(ref T value, T other);

		private static readonly EqualityComparer<T> EqualityComparer;

		private static readonly T DefaultDefault;

		private static readonly bool TypeSupportsPacking;

		private readonly int tagSize;

		internal bool PackedRepeatedField
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		internal ValueWriter<T> ValueWriter
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal Func<T, int> ValueSizeCalculator
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal ValueReader<T> ValueReader
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal InputMerger ValueMerger
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal ValuesMerger FieldMerger
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal int FixedSize
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		internal uint Tag
		{
			[CompilerGenerated]
			get
			{
				return 0u;
			}
		}

		internal uint EndTag
		{
			[CompilerGenerated]
			get
			{
				return 0u;
			}
		}

		internal T DefaultValue
		{
			[CompilerGenerated]
			get
			{
				return default(T);
			}
		}

		static FieldCodec()
		{
		}

		internal static bool IsPackedRepeatedField(uint tag)
		{
			return false;
		}

		internal FieldCodec(ValueReader<T> reader, ValueWriter<T> writer, Func<T, int> sizeCalculator, uint tag, T defaultValue)
		{
		}

		internal FieldCodec(ValueReader<T> reader, ValueWriter<T> writer, InputMerger inputMerger, ValuesMerger valuesMerger, Func<T, int> sizeCalculator, uint tag, uint endTag = 0u)
		{
		}

		internal FieldCodec(ValueReader<T> reader, ValueWriter<T> writer, InputMerger inputMerger, ValuesMerger valuesMerger, Func<T, int> sizeCalculator, uint tag, uint endTag, T defaultValue)
		{
		}

		public void WriteTagAndValue(ref WriteContext ctx, T value)
		{
		}

		public T Read(CodedInputStream input)
		{
			return default(T);
		}

		public T Read(ref ParseContext ctx)
		{
			return default(T);
		}

		public int CalculateSizeWithTag(T value)
		{
			return 0;
		}

		internal int CalculateUnconditionalSizeWithTag(T value)
		{
			return 0;
		}

		private bool IsDefault(T value)
		{
			return false;
		}
	}
}
