using System;
using System.Collections.Generic;
using System.IO;

namespace Sirenix.Serialization
{
	public class JsonDataWriter : BaseDataWriter
	{
		private static readonly uint[] ByteToHexCharLookup;

		private static readonly string NEW_LINE;

		private bool justStarted;

		private bool forceNoSeparatorNextLine;

		private Dictionary<Type, Delegate> primitiveTypeWriters;

		private Dictionary<Type, int> seenTypes;

		private byte[] buffer;

		private int bufferIndex;

		public bool FormatAsReadable;

		public bool EnableTypeOptimization;

		public JsonDataWriter()
			: base(null, null)
		{
		}

		public JsonDataWriter(Stream stream, SerializationContext context, bool formatAsReadable = true)
			: base(null, null)
		{
		}

		public void MarkJustStarted()
		{
		}

		public override void FlushToStream()
		{
		}

		public override void BeginReferenceNode(string name, Type type, int id)
		{
		}

		public override void BeginStructNode(string name, Type type)
		{
		}

		public override void EndNode(string name)
		{
		}

		public override void BeginArrayNode(long length)
		{
		}

		public override void EndArrayNode()
		{
		}

		public override void WritePrimitiveArray<T>(T[] array)
		{
		}

		public override void WriteBoolean(string name, bool value)
		{
		}

		public override void WriteByte(string name, byte value)
		{
		}

		public override void WriteChar(string name, char value)
		{
		}

		public override void WriteDecimal(string name, decimal value)
		{
		}

		public override void WriteDouble(string name, double value)
		{
		}

		public override void WriteInt32(string name, int value)
		{
		}

		public override void WriteInt64(string name, long value)
		{
		}

		public override void WriteNull(string name)
		{
		}

		public override void WriteInternalReference(string name, int id)
		{
		}

		public override void WriteSByte(string name, sbyte value)
		{
		}

		public override void WriteInt16(string name, short value)
		{
		}

		public override void WriteSingle(string name, float value)
		{
		}

		public override void WriteString(string name, string value)
		{
		}

		public override void WriteGuid(string name, Guid value)
		{
		}

		public override void WriteUInt32(string name, uint value)
		{
		}

		public override void WriteUInt64(string name, ulong value)
		{
		}

		public override void WriteExternalReference(string name, int index)
		{
		}

		public override void WriteExternalReference(string name, Guid guid)
		{
		}

		public override void WriteExternalReference(string name, string id)
		{
		}

		public override void WriteUInt16(string name, ushort value)
		{
		}

		public override void Dispose()
		{
		}

		public override void PrepareNewSerializationSession()
		{
		}

		public override string GetDataDump()
		{
			return null;
		}

		private void WriteEntry(string name, string contents)
		{
		}

		private void WriteEntry(string name, string contents, char surroundContentsWith)
		{
		}

		private void WriteTypeEntry(Type type)
		{
		}

		private void StartNewLine(bool noSeparator = false)
		{
		}

		private void EnsureBufferSpace(int space)
		{
		}

		private void Buffer_WriteString_WithEscape(string str)
		{
		}

		private static uint[] CreateByteToHexLookup()
		{
			return null;
		}
	}
}
