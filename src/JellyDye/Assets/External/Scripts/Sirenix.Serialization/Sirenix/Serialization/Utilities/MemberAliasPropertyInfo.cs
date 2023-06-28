using System;
using System.Globalization;
using System.Reflection;

namespace Sirenix.Serialization.Utilities
{
	internal sealed class MemberAliasPropertyInfo : PropertyInfo
	{
		private const string FakeNameSeparatorString = "+";

		private PropertyInfo aliasedProperty;

		private string mangledName;

		public PropertyInfo AliasedProperty => null;

		public override Module Module => null;

		public override int MetadataToken => 0;

		public override string Name => null;

		public override Type DeclaringType => null;

		public override Type ReflectedType => null;

		public override Type PropertyType => null;

		public override PropertyAttributes Attributes => default(PropertyAttributes);

		public override bool CanRead => false;

		public override bool CanWrite => false;

		public MemberAliasPropertyInfo(PropertyInfo prop, string namePrefix)
		{
		}

		public MemberAliasPropertyInfo(PropertyInfo prop, string namePrefix, string separatorString)
		{
		}

		public override object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return null;
		}

		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return false;
		}

		public override MethodInfo[] GetAccessors(bool nonPublic)
		{
			return null;
		}

		public override MethodInfo GetGetMethod(bool nonPublic)
		{
			return null;
		}

		public override ParameterInfo[] GetIndexParameters()
		{
			return null;
		}

		public override MethodInfo GetSetMethod(bool nonPublic)
		{
			return null;
		}

		public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
		{
			return null;
		}

		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
		{
		}
	}
}
