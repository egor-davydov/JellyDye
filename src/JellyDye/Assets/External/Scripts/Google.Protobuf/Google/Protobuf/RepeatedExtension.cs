using System;

namespace Google.Protobuf
{
	public sealed class RepeatedExtension<TTarget, TValue> : Extension where TTarget : IExtendableMessage<TTarget>
	{
		private readonly FieldCodec<TValue> codec;

		internal override Type TargetType => null;

		internal override bool IsRepeated => false;

		internal override IExtensionValue CreateValue()
		{
			return null;
		}
	}
}
