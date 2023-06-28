using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Collections
{
	public static class ProtobufEqualityComparers
	{
		private class BitwiseDoubleEqualityComparerImpl : EqualityComparer<double>
		{
			public override bool Equals(double x, double y)
			{
				return false;
			}

			public override int GetHashCode(double obj)
			{
				return 0;
			}

			public BitwiseDoubleEqualityComparerImpl()
			{
				((EqualityComparer<T>)(object)this)._002Ector();
			}
		}

		private class BitwiseSingleEqualityComparerImpl : EqualityComparer<float>
		{
			public override bool Equals(float x, float y)
			{
				return false;
			}

			public override int GetHashCode(float obj)
			{
				return 0;
			}

			public BitwiseSingleEqualityComparerImpl()
			{
				((EqualityComparer<T>)(object)this)._002Ector();
			}
		}

		private class BitwiseNullableDoubleEqualityComparerImpl : EqualityComparer<double?>
		{
			public override bool Equals(double? x, double? y)
			{
				return false;
			}

			public override int GetHashCode(double? obj)
			{
				return 0;
			}

			public BitwiseNullableDoubleEqualityComparerImpl()
			{
				((EqualityComparer<T>)(object)this)._002Ector();
			}
		}

		private class BitwiseNullableSingleEqualityComparerImpl : EqualityComparer<float?>
		{
			public override bool Equals(float? x, float? y)
			{
				return false;
			}

			public override int GetHashCode(float? obj)
			{
				return 0;
			}

			public BitwiseNullableSingleEqualityComparerImpl()
			{
				((EqualityComparer<T>)(object)this)._002Ector();
			}
		}

		public static EqualityComparer<double> BitwiseDoubleEqualityComparer
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public static EqualityComparer<float> BitwiseSingleEqualityComparer
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public static EqualityComparer<double?> BitwiseNullableDoubleEqualityComparer
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public static EqualityComparer<float?> BitwiseNullableSingleEqualityComparer
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public static EqualityComparer<T> GetEqualityComparer<T>()
		{
			return null;
		}
	}
}
