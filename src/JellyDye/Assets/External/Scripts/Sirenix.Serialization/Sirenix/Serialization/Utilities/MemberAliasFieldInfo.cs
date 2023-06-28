using System;
using System.Globalization;
using System.Reflection;

namespace Sirenix.Serialization.Utilities
{
	internal sealed class MemberAliasFieldInfo : FieldInfo
	{
		private const string FAKE_NAME_SEPARATOR_STRING = "+";

		private FieldInfo aliasedField;

		private string mangledName;

		public FieldInfo AliasedField => null;

		public override Module Module => null;

		public override int MetadataToken => 0;

		public override string Name => null;

		public override Type DeclaringType => null;

		public override Type ReflectedType => null;

		public override Type FieldType => null;

		public override RuntimeFieldHandle FieldHandle => default(RuntimeFieldHandle);

		public override FieldAttributes Attributes => default(FieldAttributes);

		public MemberAliasFieldInfo(FieldInfo field, string namePrefix)
		{
		}

		public MemberAliasFieldInfo(FieldInfo field, string namePrefix, string separatorString)
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

		public override object GetValue(object obj)
		{
			return null;
		}

		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
		{
		}
	}
}
