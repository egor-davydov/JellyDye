using System;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	internal static class ReflectionUtils
	{
		public static readonly Type[] EmptyTypes;

		static ReflectionUtils()
		{
		}

		public static bool IsVirtual(this PropertyInfo propertyInfo)
		{
			return false;
		}

		public static MethodInfo GetBaseDefinition(this PropertyInfo propertyInfo)
		{
			return null;
		}

		public static bool IsPublic(PropertyInfo property)
		{
			return false;
		}

		public static Type GetObjectType(object v)
		{
			return null;
		}

		public static string GetTypeName(Type t, TypeNameAssemblyFormatHandling assemblyFormat, ISerializationBinder binder)
		{
			return null;
		}

		private static string GetFullyQualifiedTypeName(Type t, ISerializationBinder binder)
		{
			return null;
		}

		private static string RemoveAssemblyDetails(string fullyQualifiedTypeName)
		{
			return null;
		}

		public static bool HasDefaultConstructor(Type t, bool nonPublic)
		{
			return false;
		}

		public static ConstructorInfo GetDefaultConstructor(Type t)
		{
			return null;
		}

		public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic)
		{
			return null;
		}

		public static bool IsNullable(Type t)
		{
			return false;
		}

		public static bool IsNullableType(Type t)
		{
			return false;
		}

		public static Type EnsureNotNullableType(Type t)
		{
			return null;
		}

		public static Type EnsureNotByRefType(Type t)
		{
			return null;
		}

		public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			return false;
		}

		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			return false;
		}

		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType)
		{
			implementingType = null;
			return false;
		}

		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition)
		{
			return false;
		}

		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType)
		{
			implementingType = null;
			return false;
		}

		private static bool InheritsGenericDefinitionInternal(Type currentType, Type genericClassDefinition, out Type implementingType)
		{
			implementingType = null;
			return false;
		}

		public static Type GetCollectionItemType(Type type)
		{
			return null;
		}

		public static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType)
		{
			keyType = null;
			valueType = null;
		}

		public static Type GetMemberUnderlyingType(MemberInfo member)
		{
			return null;
		}

		public static bool IsByRefLikeType(Type type)
		{
			return false;
		}

		public static bool IsIndexedProperty(PropertyInfo property)
		{
			return false;
		}

		public static object GetMemberValue(MemberInfo member, object target)
		{
			return null;
		}

		public static void SetMemberValue(MemberInfo member, object target, object value)
		{
		}

		public static bool CanReadMemberValue(MemberInfo member, bool nonPublic)
		{
			return false;
		}

		public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly)
		{
			return false;
		}

		public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr)
		{
			return null;
		}

		private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr)
		{
			return false;
		}

		public static T GetAttribute<T>(object attributeProvider) where T : Attribute
		{
			return null;
		}

		public static T GetAttribute<T>(object attributeProvider, bool inherit) where T : Attribute
		{
			return null;
		}

		public static T[] GetAttributes<T>(object attributeProvider, bool inherit) where T : Attribute
		{
			return null;
		}

		public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit)
		{
			return null;
		}

		public static StructMultiKey<string, string> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName)
		{
			return default(StructMultiKey<string, string>);
		}

		private static int? GetAssemblyDelimiterIndex(string fullyQualifiedTypeName)
		{
			return null;
		}

		public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo)
		{
			return null;
		}

		public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr)
		{
			return null;
		}

		private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type targetType, BindingFlags bindingAttr)
		{
		}

		public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr)
		{
			return null;
		}

		public static BindingFlags RemoveFlag(this BindingFlags bindingAttr, BindingFlags flag)
		{
			return default(BindingFlags);
		}

		private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type targetType, BindingFlags bindingAttr)
		{
		}

		public static bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method)
		{
			return false;
		}

		public static object GetDefaultValue(Type type)
		{
			return null;
		}
	}
}
