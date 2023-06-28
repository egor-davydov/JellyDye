using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Newtonsoft.Json.Linq
{
	public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, IBindingList, ICollection, IList
	{
		internal ListChangedEventHandler _listChanged;

		internal NotifyCollectionChangedEventHandler _collectionChanged;

		private object _syncRoot;

		private bool _busy;

		protected abstract IList<JToken> ChildrenTokens { get; }

		public override bool HasValues => false;

		public override JToken First => null;

		public override JToken Last => null;

		private JToken System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EIsReadOnly => false;

		private bool System_002ECollections_002EIList_002EIsFixedSize => false;

		private bool System_002ECollections_002EIList_002EIsReadOnly => false;

		private object System_002ECollections_002EIList_002EItem
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

		private bool System_002ECollections_002EICollection_002EIsSynchronized => false;

		private object System_002ECollections_002EICollection_002ESyncRoot => null;

		internal JContainer()
		{
		}

		internal JContainer(JContainer other)
		{
		}

		internal void CheckReentrancy()
		{
		}

		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
		}

		protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
		{
		}

		public override JEnumerable<JToken> Children()
		{
			return default(JEnumerable<JToken>);
		}

		internal bool IsMultiContent(object content)
		{
			return false;
		}

		internal JToken EnsureParentToken(JToken item, bool skipParentCheck)
		{
			return null;
		}

		internal abstract int IndexOfItem(JToken item);

		internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck)
		{
			return false;
		}

		internal virtual void RemoveItemAt(int index)
		{
		}

		internal virtual bool RemoveItem(JToken item)
		{
			return false;
		}

		internal virtual JToken GetItem(int index)
		{
			return null;
		}

		internal virtual void SetItem(int index, JToken item)
		{
		}

		internal virtual void ClearItems()
		{
		}

		internal virtual void ReplaceItem(JToken existing, JToken replacement)
		{
		}

		internal virtual bool ContainsItem(JToken item)
		{
			return false;
		}

		internal virtual void CopyItemsTo(Array array, int arrayIndex)
		{
		}

		internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue)
		{
			return false;
		}

		internal virtual void ValidateToken(JToken o, JToken existing)
		{
		}

		public virtual void Add(object content)
		{
		}

		internal bool TryAdd(object content)
		{
			return false;
		}

		internal void AddAndSkipParentCheck(JToken token)
		{
		}

		internal bool TryAddInternal(int index, object content, bool skipParentCheck)
		{
			return false;
		}

		internal static JToken CreateFromContent(object content)
		{
			return null;
		}

		public void RemoveAll()
		{
		}

		internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options)
		{
		}

		internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings)
		{
		}

		private static JProperty ReadProperty(JsonReader r, JsonLoadSettings settings, IJsonLineInfo lineInfo, JContainer parent)
		{
			return null;
		}

		private int System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EIndexOf(JToken item)
		{
			return 0;
		}

		private void System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EInsert(int index, JToken item)
		{
		}

		private void System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ERemoveAt(int index)
		{
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EAdd(JToken item)
		{
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EClear()
		{
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EContains(JToken item)
		{
			return false;
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECopyTo(JToken[] array, int arrayIndex)
		{
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ERemove(JToken item)
		{
			return false;
		}

		private JToken EnsureValue(object value)
		{
			return null;
		}

		private int System_002ECollections_002EIList_002EAdd(object value)
		{
			return 0;
		}

		private void System_002ECollections_002EIList_002EClear()
		{
		}

		private bool System_002ECollections_002EIList_002EContains(object value)
		{
			return false;
		}

		private int System_002ECollections_002EIList_002EIndexOf(object value)
		{
			return 0;
		}

		private void System_002ECollections_002EIList_002EInsert(int index, object value)
		{
		}

		private void System_002ECollections_002EIList_002ERemove(object value)
		{
		}

		private void System_002ECollections_002EIList_002ERemoveAt(int index)
		{
		}

		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
		{
		}
	}
}
