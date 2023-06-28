using System;
using System.Collections.Generic;
using System.IO;

namespace Sirenix.Serialization
{
	public class JsonDataReader : BaseDataReader
	{
		private JsonTextReader reader;

		private EntryType? peekedEntryType;

		private string peekedEntryName;

		private string peekedEntryContent;

		private Dictionary<int, Type> seenTypes;

		private readonly Dictionary<Type, Delegate> primitiveArrayReaders;

		public override Stream Stream
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public JsonDataReader()
			: base(null, null)
		{
		}

		public JsonDataReader(Stream stream, DeserializationContext context)
			: base(null, null)
		{
		}

		public override void Dispose()
		{
		}

		public override EntryType PeekEntry(out string name)
		{
			name = null;
			return default(EntryType);
		}

		public override bool EnterNode(out Type type)
		{
			type = null;
			return false;
		}

		public override bool ExitNode()
		{
			return false;
		}

		public override bool EnterArray(out long length)
		{
			length = default(long);
			return false;
		}

		public override bool ExitArray()
		{
			return false;
		}

		public override bool ReadPrimitiveArray<T>(out T[] array)
		{
			array = null;
			return false;
		}

		public override bool ReadBoolean(out bool value)
		{
			value = default(bool);
			return false;
		}

		public override bool ReadInternalReference(out int id)
		{
			id = default(int);
			return false;
		}

		public override bool ReadExternalReference(out int index)
		{
			index = default(int);
			return false;
		}

		public override bool ReadExternalReference(out Guid guid)
		{
			guid = default(Guid);
			return false;
		}

		public override bool ReadExternalReference(out string id)
		{
			id = null;
			return false;
		}

		public override bool ReadChar(out char value)
		{
			value = default(char);
			return false;
		}

		public override bool ReadString(out string value)
		{
			value = null;
			return false;
		}

		public override bool ReadGuid(out Guid value)
		{
			value = default(Guid);
			return false;
		}

		public override bool ReadSByte(out sbyte value)
		{
			value = default(sbyte);
			return false;
		}

		public override bool ReadInt16(out short value)
		{
			value = default(short);
			return false;
		}

		public override bool ReadInt32(out int value)
		{
			value = default(int);
			return false;
		}

		public override bool ReadInt64(out long value)
		{
			value = default(long);
			return false;
		}

		public override bool ReadByte(out byte value)
		{
			value = default(byte);
			return false;
		}

		public override bool ReadUInt16(out ushort value)
		{
			value = default(ushort);
			return false;
		}

		public override bool ReadUInt32(out uint value)
		{
			value = default(uint);
			return false;
		}

		public override bool ReadUInt64(out ulong value)
		{
			value = default(ulong);
			return false;
		}

		public override bool ReadDecimal(out decimal value)
		{
			value = default(decimal);
			return false;
		}

		public override bool ReadSingle(out float value)
		{
			value = default(float);
			return false;
		}

		public override bool ReadDouble(out double value)
		{
			value = default(double);
			return false;
		}

		public override bool ReadNull()
		{
			return false;
		}

		public override void PrepareNewSerializationSession()
		{
		}

		public override string GetDataDump()
		{
			return null;
		}

		protected override EntryType PeekEntry()
		{
			return default(EntryType);
		}

		protected override EntryType ReadToNextEntry()
		{
			return default(EntryType);
		}

		private void MarkEntryConsumed()
		{
		}

		private bool ReadAnyIntReference(out int value)
		{
			value = default(int);
			return false;
		}
	}
}
