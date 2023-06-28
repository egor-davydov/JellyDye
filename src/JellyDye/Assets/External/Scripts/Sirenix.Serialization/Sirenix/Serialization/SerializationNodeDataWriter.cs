using System;
using System.Collections.Generic;
using System.IO;

namespace Sirenix.Serialization
{
	public class SerializationNodeDataWriter : BaseDataWriter
	{
		private List<SerializationNode> nodes;

		private Dictionary<Type, Delegate> primitiveTypeWriters;

		public List<SerializationNode> Nodes
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public SerializationNodeDataWriter(SerializationContext context)
			: base(null, null)
		{
		}

		public override void BeginArrayNode(long length)
		{
		}

		public override void BeginReferenceNode(string name, Type type, int id)
		{
		}

		public override void BeginStructNode(string name, Type type)
		{
		}

		public override void Dispose()
		{
		}

		public override void EndArrayNode()
		{
		}

		public override void EndNode(string name)
		{
		}

		public override void PrepareNewSerializationSession()
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

		public override void WriteSingle(string name, float value)
		{
		}

		public override void WriteDouble(string name, double value)
		{
		}

		public override void WriteExternalReference(string name, Guid guid)
		{
		}

		public override void WriteExternalReference(string name, string id)
		{
		}

		public override void WriteExternalReference(string name, int index)
		{
		}

		public override void WriteGuid(string name, Guid value)
		{
		}

		public override void WriteInt16(string name, short value)
		{
		}

		public override void WriteInt32(string name, int value)
		{
		}

		public override void WriteInt64(string name, long value)
		{
		}

		public override void WriteInternalReference(string name, int id)
		{
		}

		public override void WriteNull(string name)
		{
		}

		public override void WritePrimitiveArray<T>(T[] array)
		{
		}

		public override void WriteSByte(string name, sbyte value)
		{
		}

		public override void WriteString(string name, string value)
		{
		}

		public override void WriteUInt16(string name, ushort value)
		{
		}

		public override void WriteUInt32(string name, uint value)
		{
		}

		public override void WriteUInt64(string name, ulong value)
		{
		}

		public override void FlushToStream()
		{
		}

		public override string GetDataDump()
		{
			return null;
		}
	}
}
