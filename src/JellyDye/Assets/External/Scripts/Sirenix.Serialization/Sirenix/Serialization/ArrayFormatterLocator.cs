using System;

namespace Sirenix.Serialization
{
	internal class ArrayFormatterLocator : IFormatterLocator
	{
		public bool TryGetFormatter(Type type, FormatterLocationStep step, ISerializationPolicy policy, out IFormatter formatter)
		{
			formatter = null;
			return false;
		}
	}
}
