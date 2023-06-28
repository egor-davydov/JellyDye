using System;

namespace Sirenix.Serialization
{
	public abstract class BaseDataReaderWriter
	{
		private NodeInfo[] nodes;

		private int nodesLength;

		[Obsolete]
		public TwoWaySerializationBinder Binder
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsInArrayNode => false;

		protected int NodeDepth => 0;

		protected NodeInfo CurrentNode => default(NodeInfo);

		protected void PushNode(NodeInfo node)
		{
		}

		protected void PushNode(string name, int id, Type type)
		{
		}

		protected void PushArray()
		{
		}

		private void ExpandNodes()
		{
		}

		protected void PopNode(string name)
		{
		}

		protected void PopArray()
		{
		}

		protected void ClearNodes()
		{
		}
	}
}
