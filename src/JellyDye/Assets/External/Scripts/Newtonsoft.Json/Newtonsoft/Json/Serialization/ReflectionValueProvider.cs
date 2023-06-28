using System.Reflection;

namespace Newtonsoft.Json.Serialization
{
	public class ReflectionValueProvider : IValueProvider
	{
		private readonly MemberInfo _memberInfo;

		public ReflectionValueProvider(MemberInfo memberInfo)
		{
		}

		public void SetValue(object target, object value)
		{
		}

		public object GetValue(object target)
		{
			return null;
		}
	}
}
