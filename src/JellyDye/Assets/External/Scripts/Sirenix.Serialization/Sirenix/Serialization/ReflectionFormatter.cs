using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class ReflectionFormatter<T> : BaseFormatter<T>
	{
		public ISerializationPolicy OverridePolicy
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ReflectionFormatter()
		{
			((BaseFormatter<>)(object)this)._002Ector();
		}

		public ReflectionFormatter(ISerializationPolicy overridePolicy)
		{
			((BaseFormatter<>)(object)this)._002Ector();
		}

		protected override void DeserializeImplementation(ref T value, IDataReader reader)
		{
		}

		protected override void SerializeImplementation(ref T value, IDataWriter writer)
		{
		}
	}
}
