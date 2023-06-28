using System;

namespace Google.Protobuf
{
	internal struct ObjectIntPair<T> : IEquatable<ObjectIntPair<T>> where T : class
	{
		private readonly int number;

		private readonly T obj;

		internal ObjectIntPair(T obj, int number)
		{
		}

		public bool Equals(ObjectIntPair<T> other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
