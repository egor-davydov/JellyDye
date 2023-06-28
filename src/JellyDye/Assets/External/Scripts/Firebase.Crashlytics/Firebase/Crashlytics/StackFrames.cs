using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Firebase.Crashlytics
{
	internal class StackFrames : IDisposable, IEnumerable, IEnumerable<FirebaseCrashlyticsFrame>
	{
		public sealed class StackFramesEnumerator : IEnumerator, IEnumerator<FirebaseCrashlyticsFrame>, IDisposable
		{
			private StackFrames collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public FirebaseCrashlyticsFrame Current => null;

			private object global_003A_003ASystem_002ECollections_002EIEnumerator_002ECurrent => null;

			public StackFramesEnumerator(StackFrames collection)
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

		public bool IsFixedSize => false;

		public bool IsReadOnly => false;

		public FirebaseCrashlyticsFrame Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Capacity
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Count => 0;

		public bool IsSynchronized => false;

		internal StackFrames(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(StackFrames obj)
		{
			return default(HandleRef);
		}

		~StackFrames()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		public StackFrames(IEnumerable c)
		{
		}

		public StackFrames(IEnumerable<FirebaseCrashlyticsFrame> c)
		{
		}

		public void CopyTo(FirebaseCrashlyticsFrame[] array)
		{
		}

		public void CopyTo(FirebaseCrashlyticsFrame[] array, int arrayIndex)
		{
		}

		public void CopyTo(int index, FirebaseCrashlyticsFrame[] array, int arrayIndex, int count)
		{
		}

		public FirebaseCrashlyticsFrame[] ToArray()
		{
			return null;
		}

		private IEnumerator<FirebaseCrashlyticsFrame> global_003A_003ASystem_002ECollections_002EGeneric_002EIEnumerable_003CFirebase_002ECrashlytics_002EFirebaseCrashlyticsFrame_003E_002EGetEnumerator()
		{
			return null;
		}

		private IEnumerator global_003A_003ASystem_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		public StackFramesEnumerator GetEnumerator()
		{
			return null;
		}

		public void Clear()
		{
		}

		public void Add(FirebaseCrashlyticsFrame x)
		{
		}

		private uint size()
		{
			return 0u;
		}

		private uint capacity()
		{
			return 0u;
		}

		private void reserve(uint n)
		{
		}

		public StackFrames()
		{
		}

		public StackFrames(StackFrames other)
		{
		}

		public StackFrames(int capacity)
		{
		}

		private FirebaseCrashlyticsFrame getitemcopy(int index)
		{
			return null;
		}

		private FirebaseCrashlyticsFrame getitem(int index)
		{
			return null;
		}

		private void setitem(int index, FirebaseCrashlyticsFrame val)
		{
		}

		public void AddRange(StackFrames values)
		{
		}

		public StackFrames GetRange(int index, int count)
		{
			return null;
		}

		public void Insert(int index, FirebaseCrashlyticsFrame x)
		{
		}

		public void InsertRange(int index, StackFrames values)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void RemoveRange(int index, int count)
		{
		}

		public static StackFrames Repeat(FirebaseCrashlyticsFrame value, int count)
		{
			return null;
		}

		public void Reverse()
		{
		}

		public void Reverse(int index, int count)
		{
		}

		public void SetRange(int index, StackFrames values)
		{
		}
	}
}
