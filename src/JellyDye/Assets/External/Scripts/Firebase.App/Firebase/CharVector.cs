using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Firebase
{
	internal class CharVector : IDisposable, IEnumerable, IList<byte>, ICollection<byte>, IEnumerable<byte>
	{
		public sealed class CharVectorEnumerator : IEnumerator, IEnumerator<byte>, IDisposable
		{
			private CharVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public byte Current => 0;

			private object global_003A_003ASystem_002ECollections_002EIEnumerator_002ECurrent => null;

			public CharVectorEnumerator(CharVector collection)
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

		public bool IsReadOnly => false;

		public byte Item
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

		internal CharVector(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		~CharVector()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		public void CopyTo(byte[] array)
		{
		}

		public void CopyTo(byte[] array, int arrayIndex)
		{
		}

		public void CopyTo(int index, byte[] array, int arrayIndex, int count)
		{
		}

		private IEnumerator<byte> global_003A_003ASystem_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EByte_003E_002EGetEnumerator()
		{
			return null;
		}

		private IEnumerator global_003A_003ASystem_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		public void Clear()
		{
		}

		public void Add(byte x)
		{
		}

		private uint size()
		{
			return 0u;
		}

		private byte getitemcopy(int index)
		{
			return 0;
		}

		private byte getitem(int index)
		{
			return 0;
		}

		private void setitem(int index, byte val)
		{
		}

		public void Insert(int index, byte x)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public bool Contains(byte value)
		{
			return false;
		}

		public int IndexOf(byte value)
		{
			return 0;
		}

		public bool Remove(byte value)
		{
			return false;
		}
	}
}
