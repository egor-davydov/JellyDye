using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Firebase
{
	internal class StringStringMap : IDisposable, IDictionary<string, string>, ICollection<KeyValuePair<string, string>>, IEnumerable<KeyValuePair<string, string>>, IEnumerable
	{
		public sealed class StringStringMapEnumerator : IEnumerator, IEnumerator<KeyValuePair<string, string>>, IDisposable
		{
			private StringStringMap collectionRef;

			private IList<string> keyCollection;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public KeyValuePair<string, string> Current => default(KeyValuePair<string, string>);

			private object global_003A_003ASystem_002ECollections_002EIEnumerator_002ECurrent => null;

			public StringStringMapEnumerator(StringStringMap collection)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}

			public void Dispose()
			{
			}
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public string Item
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

		public ICollection<string> Keys => null;

		public ICollection<string> Values => null;

		internal StringStringMap(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(StringStringMap obj)
		{
			return default(HandleRef);
		}

		~StringStringMap()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		public bool TryGetValue(string key, out string value)
		{
			value = null;
			return false;
		}

		public void Add(KeyValuePair<string, string> item)
		{
		}

		public bool Remove(KeyValuePair<string, string> item)
		{
			return false;
		}

		public bool Contains(KeyValuePair<string, string> item)
		{
			return false;
		}

		public void CopyTo(KeyValuePair<string, string>[] array, int arrayIndex)
		{
		}

		private IEnumerator<KeyValuePair<string, string>> global_003A_003ASystem_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CSystem_002EString_003E_003E_002EGetEnumerator()
		{
			return null;
		}

		private IEnumerator global_003A_003ASystem_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		public StringStringMapEnumerator GetEnumerator()
		{
			return null;
		}

		public StringStringMap()
		{
		}

		private uint size()
		{
			return 0u;
		}

		public void Clear()
		{
		}

		private string getitem(string key)
		{
			return null;
		}

		private void setitem(string key, string x)
		{
		}

		public bool ContainsKey(string key)
		{
			return false;
		}

		public void Add(string key, string value)
		{
		}

		public bool Remove(string key)
		{
			return false;
		}

		private IntPtr create_iterator_begin()
		{
			return (IntPtr)0;
		}

		private string get_next_key(IntPtr swigiterator)
		{
			return null;
		}

		private void destroy_iterator(IntPtr swigiterator)
		{
		}
	}
}
