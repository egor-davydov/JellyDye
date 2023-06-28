namespace Sirenix.Serialization
{
	public class SerializationConfig
	{
		private readonly object LOCK;

		private ISerializationPolicy serializationPolicy;

		private DebugContext debugContext;

		public bool AllowDeserializeInvalidData;

		public ISerializationPolicy SerializationPolicy
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DebugContext DebugContext
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void ResetToDefault()
		{
		}
	}
}
