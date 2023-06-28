using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class BinaryDataReader : BaseDataReader
	{
		private struct Struct256Bit
		{
			public decimal d1;

			public decimal d2;
		}

		private static readonly Dictionary<Type, Delegate> PrimitiveFromByteMethods;

		private byte[] internalBufferBackup;

		private byte[] buffer;

		private int bufferIndex;

		private int bufferEnd;

		private EntryType? peekedEntryType;

		private BinaryEntryType peekedBinaryEntryType;

		private string peekedEntryName;

		private Dictionary<int, Type> types;

		public BinaryDataReader()
			: base(null, null)
		{
		}

		public BinaryDataReader(Stream stream, DeserializationContext context)
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

		public override bool EnterArray(out long length)
		{
			length = default(long);
			return false;
		}

		public override bool EnterNode(out Type type)
		{
			type = null;
			return false;
		}

		public override bool ExitArray()
		{
			return false;
		}

		public override bool ExitNode()
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

		public override bool ReadSByte(out sbyte value)
		{
			value = default(sbyte);
			return false;
		}

		public override bool ReadByte(out byte value)
		{
			value = default(byte);
			return false;
		}

		public override bool ReadInt16(out short value)
		{
			value = default(short);
			return false;
		}

		public override bool ReadUInt16(out ushort value)
		{
			value = default(ushort);
			return false;
		}

		public override bool ReadInt32(out int value)
		{
			value = default(int);
			return false;
		}

		public override bool ReadUInt32(out uint value)
		{
			value = default(uint);
			return false;
		}

		public override bool ReadInt64(out long value)
		{
			value = default(long);
			return false;
		}

		public override bool ReadUInt64(out ulong value)
		{
			value = default(ulong);
			return false;
		}

		public override bool ReadChar(out char value)
		{
			value = default(char);
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

		public override bool ReadDecimal(out decimal value)
		{
			value = default(decimal);
			return false;
		}

		public override bool ReadExternalReference(out Guid guid)
		{
			guid = default(Guid);
			return false;
		}

		public override bool ReadGuid(out Guid value)
		{
			value = default(Guid);
			return false;
		}

		public override bool ReadExternalReference(out int index)
		{
			index = default(int);
			return false;
		}

		public override bool ReadExternalReference(out string id)
		{
			id = null;
			return false;
		}

		public override bool ReadNull()
		{
			return false;
		}

		public override bool ReadInternalReference(out int id)
		{
			id = default(int);
			return false;
		}

		public override bool ReadString(out string value)
		{
			value = null;
			return false;
		}

		public override void PrepareNewSerializationSession()
		{
		}

		public override string GetDataDump()
		{
			return null;
		}

		[MethodImpl(256)]
		private string ReadStringValue()
		{
			return null;
		}

		[MethodImpl(256)]
		private void SkipStringValue()
		{
		}

		private void SkipPeekedEntryContent()
		{
		}

		[MethodImpl(256)]
		private bool SkipBuffer(int amount)
		{
			return false;
		}

		[MethodImpl(256)]
		private Type ReadTypeEntry()
		{
			return null;
		}

		[MethodImpl(256)]
		private void MarkEntryContentConsumed()
		{
		}

		protected override EntryType PeekEntry()
		{
			return default(EntryType);
		}

		protected override EntryType ReadToNextEntry()
		{
			return default(EntryType);
		}

		[MethodImpl(256)]
		private bool UNSAFE_Read_1_Byte(out byte value)
		{
			value = default(byte);
			return false;
		}

		[MethodImpl(256)]
		private bool UNSAFE_Read_1_SByte(out sbyte value)
		{
			value = default(sbyte);
			return false;
		}

		[MethodImpl(256)]
		private bool UNSAFE_Read_2_Int16(out short value)
		{
			value = default(short);
			return false;
		}

		[MethodImpl(256)]
		private bool UNSAFE_Read_2_UInt16(out ushort value)
		{
			value = default(ushort);
			return false;
		}

		[MethodImpl(256)]
		private bool UNSAFE_Read_2_Char(out char value)
		{
			value = default(char);
			return false;
		}

		[MethodImpl(256)]
		private bool UNSAFE_Read_4_Int32(out int value)
		{
			value = default(int);
			return false;
		}

		[MethodImpl(256)]
		private bool UNSAFE_Read_4_UInt32(out uint value)
		{
			value = default(uint);
			return false;
		}

		[MethodImpl(256)]
		private bool UNSAFE_Read_4_Float32(out float value)
		{
			value = default(float);
			return false;
		}

		[MethodImpl(256)]
		private bool UNSAFE_Read_8_Int64(out long value)
		{
			value = default(long);
			return false;
		}

		[MethodImpl(256)]
		private bool UNSAFE_Read_8_UInt64(out ulong value)
		{
			value = default(ulong);
			return false;
		}

		[MethodImpl(256)]
		private bool UNSAFE_Read_8_Float64(out double value)
		{
			value = default(double);
			return false;
		}

		[MethodImpl(256)]
		private bool UNSAFE_Read_16_Decimal(out decimal value)
		{
			value = default(decimal);
			return false;
		}

		[MethodImpl(256)]
		private bool UNSAFE_Read_16_Guid(out Guid value)
		{
			value = default(Guid);
			return false;
		}

		[MethodImpl(256)]
		private bool HasBufferData(int amount)
		{
			return false;
		}

		private void ReadEntireStreamToBuffer()
		{
		}
	}
}
