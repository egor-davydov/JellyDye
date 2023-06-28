using System;
using System.Globalization;
using System.Reflection;

namespace Sirenix.Serialization.Utilities
{
	internal sealed class MemberAliasMethodInfo : MethodInfo
	{
		private const string FAKE_NAME_SEPARATOR_STRING = "+";

		private MethodInfo aliasedMethod;

		private string mangledName;

		public MethodInfo AliasedMethod => null;

		public override ICustomAttributeProvider ReturnTypeCustomAttributes => null;

		public override RuntimeMethodHandle MethodHandle => default(RuntimeMethodHandle);

		public override MethodAttributes Attributes => default(MethodAttributes);

		public override Type ReturnType => null;

		public override Type DeclaringType => null;

		public override string Name => null;

		public override Type ReflectedType => null;

		public MemberAliasMethodInfo(MethodInfo method, string namePrefix)
		{
		}

		public MemberAliasMethodInfo(MethodInfo method, string namePrefix, string separatorString)
		{
		}

		public override MethodInfo GetBaseDefinition()
		{
			return null;
		}

		public override object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return null;
		}

		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return default(MethodImplAttributes);
		}

		public override ParameterInfo[] GetParameters()
		{
			return null;
		}

		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			return null;
		}

		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return false;
		}
	}
}
