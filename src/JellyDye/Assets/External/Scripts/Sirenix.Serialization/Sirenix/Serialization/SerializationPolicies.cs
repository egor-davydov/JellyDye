namespace Sirenix.Serialization
{
	public static class SerializationPolicies
	{
		private static readonly object LOCK;

		private static ISerializationPolicy everythingPolicy;

		private static ISerializationPolicy unityPolicy;

		private static ISerializationPolicy strictPolicy;

		public static ISerializationPolicy Everything => null;

		public static ISerializationPolicy Unity => null;

		public static ISerializationPolicy Strict => null;

		public static bool TryGetByID(string name, out ISerializationPolicy policy)
		{
			policy = null;
			return false;
		}
	}
}
