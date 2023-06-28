using System.Collections.Generic;

namespace Google.Protobuf.Reflection
{
	internal static class DescriptorUtil
	{
		internal delegate TOutput IndexedConverter<TInput, TOutput>(TInput element, int index);

		internal static IList<TOutput> ConvertAndMakeReadOnly<TInput, TOutput>(IList<TInput> input, IndexedConverter<TInput, TOutput> converter)
		{
			return null;
		}
	}
}
