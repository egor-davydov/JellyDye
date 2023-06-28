using System;

namespace Sirenix.Serialization
{
	public sealed class MultiDimensionalArrayFormatter<TArray, TElement> : BaseFormatter<TArray> where TArray : class
	{
		private const string RANKS_NAME = "ranks";

		private const char RANKS_SEPARATOR = '|';

		private static readonly int ArrayRank;

		private static readonly Serializer<TElement> ValueReaderWriter;

		static MultiDimensionalArrayFormatter()
		{
		}

		protected override TArray GetUninitializedObject()
		{
			return null;
		}

		protected override void DeserializeImplementation(ref TArray value, IDataReader reader)
		{
		}

		protected override void SerializeImplementation(ref TArray value, IDataWriter writer)
		{
		}

		private void IterateArrayWrite(Array a, Func<TElement> write)
		{
		}

		private void IterateArrayWrite(Array a, int rank, int[] indices, Func<TElement> write)
		{
		}

		private void IterateArrayRead(Array a, Action<TElement> read)
		{
		}

		private void IterateArrayRead(Array a, int rank, int[] indices, Action<TElement> read)
		{
		}

		public MultiDimensionalArrayFormatter()
		{
			((BaseFormatter<>)(object)this)._002Ector();
		}
	}
}
