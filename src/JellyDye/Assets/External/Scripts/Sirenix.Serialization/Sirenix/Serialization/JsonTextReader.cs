using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class JsonTextReader : IDisposable
	{
		private static readonly Dictionary<char, EntryType?> EntryDelineators;

		private static readonly Dictionary<char, char> UnescapeDictionary;

		private StreamReader reader;

		private int bufferIndex;

		private char[] buffer;

		private char? lastReadChar;

		private char? peekedChar;

		private Queue<char> emergencyPlayback;

		public DeserializationContext Context
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public JsonTextReader(Stream stream, DeserializationContext context)
		{
		}

		public void Reset()
		{
		}

		public void Dispose()
		{
		}

		public void ReadToNextEntry(out string name, out string valueContent, out EntryType entry)
		{
			name = null;
			valueContent = null;
			entry = default(EntryType);
		}

		private void ParseEntryFromBuffer(out string name, out string valueContent, out EntryType entry, int valueSeparatorIndex, EntryType? hintEntry)
		{
			name = null;
			valueContent = null;
			entry = default(EntryType);
		}

		private bool IsHex(char c)
		{
			return false;
		}

		private uint ParseSingleChar(char c, uint multiplier)
		{
			return 0u;
		}

		private char ParseHexChar(char c1, char c2, char c3, char c4)
		{
			return '\0';
		}

		private char ReadCharIntoBuffer()
		{
			return '\0';
		}

		private EntryType? GuessPrimitiveType(string content)
		{
			return null;
		}

		private char PeekChar()
		{
			return '\0';
		}

		private void SkipChar()
		{
		}

		private char ConsumeChar()
		{
			return '\0';
		}
	}
}
