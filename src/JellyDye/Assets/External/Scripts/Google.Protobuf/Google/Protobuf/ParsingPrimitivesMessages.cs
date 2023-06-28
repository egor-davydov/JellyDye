using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace Google.Protobuf
{
	internal static class ParsingPrimitivesMessages
	{
		private static readonly byte[] ZeroLengthMessageStreamData;

		public static void SkipLastField(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state)
		{
		}

		public static void SkipGroup(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, uint startGroupTag)
		{
		}

		public static void ReadMessage(ref ParseContext ctx, IMessage message)
		{
		}

		public static KeyValuePair<TKey, TValue> ReadMapEntry<TKey, TValue>(ref ParseContext ctx, MapField<TKey, TValue>.Codec codec)
		{
			return default(KeyValuePair<TKey, TValue>);
		}

		public static void ReadGroup(ref ParseContext ctx, int fieldNumber, UnknownFieldSet set)
		{
		}

		public static void ReadRawMessage(ref ParseContext ctx, IMessage message)
		{
		}

		public static void CheckReadEndOfStreamTag(ref ParserInternalState state)
		{
		}

		private static void CheckLastTagWas(ref ParserInternalState state, uint expectedTag)
		{
		}
	}
}
