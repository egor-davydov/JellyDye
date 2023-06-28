using System;
using System.IO;

namespace Sirenix.Serialization
{
	public abstract class BaseDataReader : BaseDataReaderWriter, IDataReader, IDisposable
	{
		private DeserializationContext context;

		private Stream stream;

		public int CurrentNodeId => 0;

		public int CurrentNodeDepth => 0;

		public string CurrentNodeName => null;

		public virtual Stream Stream
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DeserializationContext Context
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected BaseDataReader(Stream stream, DeserializationContext context)
		{
		}

		public abstract bool EnterNode(out Type type);

		public abstract bool ExitNode();

		public abstract bool EnterArray(out long length);

		public abstract bool ExitArray();

		public abstract bool ReadPrimitiveArray<T>(out T[] array) where T : struct;

		public abstract EntryType PeekEntry(out string name);

		public abstract bool ReadInternalReference(out int id);

		public abstract bool ReadExternalReference(out int index);

		public abstract bool ReadExternalReference(out Guid guid);

		public abstract bool ReadExternalReference(out string id);

		public abstract bool ReadChar(out char value);

		public abstract bool ReadString(out string value);

		public abstract bool ReadGuid(out Guid value);

		public abstract bool ReadSByte(out sbyte value);

		public abstract bool ReadInt16(out short value);

		public abstract bool ReadInt32(out int value);

		public abstract bool ReadInt64(out long value);

		public abstract bool ReadByte(out byte value);

		public abstract bool ReadUInt16(out ushort value);

		public abstract bool ReadUInt32(out uint value);

		public abstract bool ReadUInt64(out ulong value);

		public abstract bool ReadDecimal(out decimal value);

		public abstract bool ReadSingle(out float value);

		public abstract bool ReadDouble(out double value);

		public abstract bool ReadBoolean(out bool value);

		public abstract bool ReadNull();

		public virtual void SkipEntry()
		{
		}

		public abstract void Dispose();

		public virtual void PrepareNewSerializationSession()
		{
		}

		public abstract string GetDataDump();

		protected abstract EntryType PeekEntry();

		protected abstract EntryType ReadToNextEntry();
	}
}
