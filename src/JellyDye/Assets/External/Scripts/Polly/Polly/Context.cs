using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Polly
{
	public class Context : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<string, object>, IReadOnlyCollection<KeyValuePair<string, object>>
	{
		private Dictionary<string, object> wrappedDictionary;

		public string PolicyWrapKey
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public string PolicyKey
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		private Dictionary<string, object> WrappedDictionary => null;

		public ICollection<string> Keys => null;

		public ICollection<object> Values => null;

		public int Count => 0;

		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CSystem_002EObject_003E_003E_002EIsReadOnly => false;

		public object Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private bool System_002ECollections_002EIDictionary_002EIsFixedSize => false;

		private bool System_002ECollections_002EIDictionary_002EIsReadOnly => false;

		private ICollection System_002ECollections_002EIDictionary_002EKeys => null;

		private ICollection System_002ECollections_002EIDictionary_002EValues => null;

		private bool System_002ECollections_002EICollection_002EIsSynchronized => false;

		private object System_002ECollections_002EICollection_002ESyncRoot => null;

		private object System_002ECollections_002EIDictionary_002EItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal static Context None()
		{
			return null;
		}

		public Context(string operationKey)
		{
		}

		public Context()
		{
		}

		public void Add(string key, object value)
		{
		}

		public bool ContainsKey(string key)
		{
			return false;
		}

		public bool Remove(string key)
		{
			return false;
		}

		public bool TryGetValue(string key, out object value)
		{
			value = null;
			return false;
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CSystem_002EObject_003E_003E_002EAdd(KeyValuePair<string, object> item)
		{
		}

		public void Clear()
		{
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CSystem_002EObject_003E_003E_002EContains(KeyValuePair<string, object> item)
		{
			return false;
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CSystem_002EObject_003E_003E_002ECopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
		{
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CSystem_002EObject_003E_003E_002ERemove(KeyValuePair<string, object> item)
		{
			return false;
		}

		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		public void Add(object key, object value)
		{
		}

		public bool Contains(object key)
		{
			return false;
		}

		private IDictionaryEnumerator System_002ECollections_002EIDictionary_002EGetEnumerator()
		{
			return null;
		}

		public void Remove(object key)
		{
		}

		public void CopyTo(Array array, int index)
		{
		}
	}
}
