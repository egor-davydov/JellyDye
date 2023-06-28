using System;

namespace MEC
{
	public struct CoroutineHandle : IEquatable<CoroutineHandle>
	{
		private const byte ReservedSpace = 15;

		private static readonly int[] NextIndex;

		private readonly int _id;

		public byte Key => 0;

		public bool IsValid => false;

		public CoroutineHandle(byte ind)
		{
		}

		public bool Equals(CoroutineHandle other)
		{
			return false;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public static bool operator ==(CoroutineHandle a, CoroutineHandle b)
		{
			return false;
		}

		public static bool operator !=(CoroutineHandle a, CoroutineHandle b)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
