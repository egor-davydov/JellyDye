using System;
using System.Reflection;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	internal abstract class ReflectionDelegateFactory
	{
		public Func<T, object> CreateGet<T>(MemberInfo memberInfo)
		{
			return null;
		}

		public Action<T, object> CreateSet<T>(MemberInfo memberInfo)
		{
			return null;
		}

		public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method);

		public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);

		public abstract Func<T> CreateDefaultConstructor<T>(Type type);

		public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);

		public abstract Func<T, object> CreateGet<T>(FieldInfo fieldInfo);

		public abstract Action<T, object> CreateSet<T>(FieldInfo fieldInfo);

		public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);
	}
}
