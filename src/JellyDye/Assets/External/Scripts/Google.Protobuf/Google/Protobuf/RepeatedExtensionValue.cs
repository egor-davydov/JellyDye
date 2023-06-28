using System;
using Google.Protobuf.Collections;

namespace Google.Protobuf
{
	internal sealed class RepeatedExtensionValue<T> : IExtensionValue, IEquatable<IExtensionValue>, IDeepCloneable<IExtensionValue>
	{
		private RepeatedField<T> field;

		private readonly FieldCodec<T> codec;

		internal RepeatedExtensionValue(FieldCodec<T> codec)
		{
		}

		public int CalculateSize()
		{
			return 0;
		}

		public IExtensionValue Clone()
		{
			return null;
		}

		public bool Equals(IExtensionValue other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public void MergeFrom(ref ParseContext ctx)
		{
		}

		public void MergeFrom(IExtensionValue value)
		{
		}

		public void WriteTo(ref WriteContext ctx)
		{
		}

		public RepeatedField<T> GetValue()
		{
			return null;
		}
	}
}
