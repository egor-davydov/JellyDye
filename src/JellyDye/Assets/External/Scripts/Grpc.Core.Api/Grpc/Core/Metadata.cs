using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Grpc.Core
{
	public sealed class Metadata : IList<Metadata.Entry>, ICollection<Metadata.Entry>, IEnumerable<Metadata.Entry>, IEnumerable
	{
		public class Entry
		{
			private readonly string key;

			private readonly string value;

			private readonly byte[] valueBytes;

			private static readonly byte[] EmptyByteArray;

			public string Key => null;

			public bool IsBinary => false;

			private Entry(string key, string value, byte[] valueBytes)
			{
			}

			public override string ToString()
			{
				return null;
			}

			internal byte[] GetSerializedValueUnsafe()
			{
				return null;
			}

			internal static Entry CreateUnsafe(string key, IntPtr source, int length)
			{
				return null;
			}

			private static bool HasBinaryHeaderSuffix(string key)
			{
				return false;
			}
		}

		public static readonly Metadata Empty;

		private static readonly Encoding EncodingASCII;

		private readonly List<Entry> entries;

		private bool readOnly;

		public Entry Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Count => 0;

		public bool IsReadOnly => false;

		internal Metadata Freeze()
		{
			return null;
		}

		public int IndexOf(Entry item)
		{
			return 0;
		}

		public void Insert(int index, Entry item)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void Add(Entry item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(Entry item)
		{
			return false;
		}

		public void CopyTo(Entry[] array, int arrayIndex)
		{
		}

		public bool Remove(Entry item)
		{
			return false;
		}

		public IEnumerator<Entry> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		private void CheckWriteable()
		{
		}
	}
}
