using System;

namespace Sirenix.Serialization
{
	public struct NodeInfo
	{
		public static readonly NodeInfo Empty;

		public readonly string Name;

		public readonly int Id;

		public readonly Type Type;

		public readonly bool IsArray;

		public readonly bool IsEmpty;

		public NodeInfo(string name, int id, Type type, bool isArray)
		{
		}

		private NodeInfo(bool parameter)
		{
		}

		public static bool operator ==(NodeInfo a, NodeInfo b)
		{
			return false;
		}

		public static bool operator !=(NodeInfo a, NodeInfo b)
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
