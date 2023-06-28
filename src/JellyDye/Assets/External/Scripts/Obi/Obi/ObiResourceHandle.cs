namespace Obi
{
	public class ObiResourceHandle<T> where T : class
	{
		public T owner;

		public int index;

		private int referenceCount;

		public bool isValid => false;

		public void Invalidate()
		{
		}

		public void Reference()
		{
		}

		public bool Dereference()
		{
			return false;
		}

		public ObiResourceHandle(int index = -1)
		{
		}
	}
}
