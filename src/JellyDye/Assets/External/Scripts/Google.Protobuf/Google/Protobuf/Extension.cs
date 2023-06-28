using System;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	public abstract class Extension
	{
		internal abstract Type TargetType { get; }

		public int FieldNumber
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		internal abstract bool IsRepeated { get; }

		internal abstract IExtensionValue CreateValue();
	}
	public sealed class Extension<TTarget, TValue> : Extension where TTarget : IExtendableMessage<TTarget>
	{
		private readonly FieldCodec<TValue> codec;

		internal TValue DefaultValue => default(TValue);

		internal override Type TargetType => null;

		internal override bool IsRepeated => false;

		internal override IExtensionValue CreateValue()
		{
			return null;
		}
	}
}
