using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;

namespace Google.Protobuf
{
	public static class ExtensionSet
	{
		private static bool TryGetValue<TTarget>(ref ExtensionSet<TTarget> set, Extension extension, out IExtensionValue value) where TTarget : IExtendableMessage<TTarget>
		{
			value = null;
			return false;
		}

		public static TValue Get<TTarget, TValue>(ref ExtensionSet<TTarget> set, Extension<TTarget, TValue> extension) where TTarget : IExtendableMessage<TTarget>
		{
			return default(TValue);
		}

		public static RepeatedField<TValue> Get<TTarget, TValue>(ref ExtensionSet<TTarget> set, RepeatedExtension<TTarget, TValue> extension) where TTarget : IExtendableMessage<TTarget>
		{
			return null;
		}

		public static RepeatedField<TValue> GetOrInitialize<TTarget, TValue>(ref ExtensionSet<TTarget> set, RepeatedExtension<TTarget, TValue> extension) where TTarget : IExtendableMessage<TTarget>
		{
			return null;
		}

		public static bool Has<TTarget, TValue>(ref ExtensionSet<TTarget> set, Extension<TTarget, TValue> extension) where TTarget : IExtendableMessage<TTarget>
		{
			return false;
		}

		public static void Clear<TTarget, TValue>(ref ExtensionSet<TTarget> set, Extension<TTarget, TValue> extension) where TTarget : IExtendableMessage<TTarget>
		{
		}

		public static bool TryMergeFieldFrom<TTarget>(ref ExtensionSet<TTarget> set, ref ParseContext ctx) where TTarget : IExtendableMessage<TTarget>
		{
			return false;
		}

		public static void MergeFrom<TTarget>(ref ExtensionSet<TTarget> first, ExtensionSet<TTarget> second) where TTarget : IExtendableMessage<TTarget>
		{
		}

		public static ExtensionSet<TTarget> Clone<TTarget>(ExtensionSet<TTarget> set) where TTarget : IExtendableMessage<TTarget>
		{
			return null;
		}
	}
	public sealed class ExtensionSet<TTarget> where TTarget : IExtendableMessage<TTarget>
	{
		internal Dictionary<int, IExtensionValue> ValuesByNumber
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public int CalculateSize()
		{
			return 0;
		}

		public void WriteTo(ref WriteContext ctx)
		{
		}
	}
}
