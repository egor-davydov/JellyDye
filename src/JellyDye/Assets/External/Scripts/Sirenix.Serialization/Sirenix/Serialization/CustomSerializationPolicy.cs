using System;
using System.Reflection;

namespace Sirenix.Serialization
{
	public class CustomSerializationPolicy : ISerializationPolicy
	{
		private string id;

		private bool allowNonSerializableTypes;

		private Func<MemberInfo, bool> shouldSerializeFunc;

		public string ID => null;

		public bool AllowNonSerializableTypes => false;

		public CustomSerializationPolicy(string id, bool allowNonSerializableTypes, Func<MemberInfo, bool> shouldSerializeFunc)
		{
		}

		public bool ShouldSerializeMember(MemberInfo member)
		{
			return false;
		}
	}
}
