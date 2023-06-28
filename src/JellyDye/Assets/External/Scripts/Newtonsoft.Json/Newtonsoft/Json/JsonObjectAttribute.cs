namespace Newtonsoft.Json
{
	public sealed class JsonObjectAttribute : JsonContainerAttribute
	{
		private MemberSerialization _memberSerialization;

		internal MissingMemberHandling? _missingMemberHandling;

		internal Required? _itemRequired;

		internal NullValueHandling? _itemNullValueHandling;

		public MemberSerialization MemberSerialization => default(MemberSerialization);
	}
}
