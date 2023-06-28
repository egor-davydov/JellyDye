using System;
using System.Collections.Generic;
using System.Reflection;

namespace Sirenix.Utilities
{
	public static class TypeExtensions
	{
		private static readonly object GenericConstraintsSatisfaction_LOCK;

		private static readonly Dictionary<Type, Type> GenericConstraintsSatisfactionInferredParameters;

		private static readonly Dictionary<Type, Type> GenericConstraintsSatisfactionResolvedMap;

		private static readonly HashSet<Type> GenericConstraintsSatisfactionProcessedParams;

		private static readonly object WeaklyTypedTypeCastDelegates_LOCK;

		private static readonly object StronglyTypedTypeCastDelegates_LOCK;

		private static readonly DoubleLookupDictionary<Type, Type, Func<object, object>> WeaklyTypedTypeCastDelegates;

		private static readonly DoubleLookupDictionary<Type, Type, Delegate> StronglyTypedTypeCastDelegates;

		private static HashSet<string> ReservedCSharpKeywords;

		public static readonly Dictionary<string, string> TypeNameAlternatives;

		private static readonly object CachedNiceNames_LOCK;

		private static readonly Dictionary<Type, string> CachedNiceNames;

		private static readonly Type VoidPointerType;

		private static readonly Dictionary<Type, HashSet<Type>> PrimitiveImplicitCasts;

		private static readonly HashSet<Type> ExplicitCastIntegrals;

		private static string GetCachedNiceName(Type type)
		{
			return null;
		}

		private static string CreateNiceName(Type type)
		{
			return null;
		}

		private static bool HasCastDefined(this Type from, Type to, bool requireImplicitCast)
		{
			return false;
		}

		public static bool IsValidIdentifier(string identifier)
		{
			return false;
		}

		private static bool IsValidIdentifierStartCharacter(char c)
		{
			return false;
		}

		private static bool IsValidIdentifierPartCharacter(char c)
		{
			return false;
		}

		public static bool IsCastableTo(this Type from, Type to, bool requireImplicitCast = false)
		{
			return false;
		}

		public static Func<object, object> GetCastMethodDelegate(this Type from, Type to, bool requireImplicitCast = false)
		{
			return null;
		}

		public static Func<TFrom, TTo> GetCastMethodDelegate<TFrom, TTo>(bool requireImplicitCast = false)
		{
			return null;
		}

		public static MethodInfo GetCastMethod(this Type from, Type to, bool requireImplicitCast = false)
		{
			return null;
		}

		public static Func<T, T, bool> GetEqualityComparerDelegate<T>()
		{
			return null;
		}

		public static T GetAttribute<T>(this Type type, bool inherit) where T : Attribute
		{
			return null;
		}

		public static bool ImplementsOrInherits(this Type type, Type to)
		{
			return false;
		}

		public static bool ImplementsOpenGenericType(this Type candidateType, Type openGenericType)
		{
			return false;
		}

		public static bool ImplementsOpenGenericInterface(this Type candidateType, Type openGenericInterfaceType)
		{
			return false;
		}

		public static bool ImplementsOpenGenericClass(this Type candidateType, Type openGenericType)
		{
			return false;
		}

		public static Type[] GetArgumentsOfInheritedOpenGenericType(this Type candidateType, Type openGenericType)
		{
			return null;
		}

		public static Type[] GetArgumentsOfInheritedOpenGenericClass(this Type candidateType, Type openGenericType)
		{
			return null;
		}

		public static Type[] GetArgumentsOfInheritedOpenGenericInterface(this Type candidateType, Type openGenericInterfaceType)
		{
			return null;
		}

		public static MethodInfo GetOperatorMethod(this Type type, Operator op)
		{
			return null;
		}

		public static MethodInfo[] GetOperatorMethods(this Type type, Operator op)
		{
			return null;
		}

		public static IEnumerable<MemberInfo> GetAllMembers(this Type type, BindingFlags flags = BindingFlags.Default)
		{
			return null;
		}

		public static IEnumerable<MemberInfo> GetAllMembers(this Type type, string name, BindingFlags flags = BindingFlags.Default)
		{
			return null;
		}

		public static IEnumerable<T> GetAllMembers<T>(this Type type, BindingFlags flags = BindingFlags.Default) where T : MemberInfo
		{
			return null;
		}

		public static Type GetGenericBaseType(this Type type, Type baseType)
		{
			return null;
		}

		public static Type GetGenericBaseType(this Type type, Type baseType, out int depthCount)
		{
			depthCount = default(int);
			return null;
		}

		public static IEnumerable<Type> GetBaseTypes(this Type type, bool includeSelf = false)
		{
			return null;
		}

		public static IEnumerable<Type> GetBaseClasses(this Type type, bool includeSelf = false)
		{
			return null;
		}

		private static string TypeNameGauntlet(this Type type)
		{
			return null;
		}

		public static string GetNiceName(this Type type)
		{
			return null;
		}

		public static string GetNiceFullName(this Type type)
		{
			return null;
		}

		public static string GetCompilableNiceName(this Type type)
		{
			return null;
		}

		public static string GetCompilableNiceFullName(this Type type)
		{
			return null;
		}

		public static T GetCustomAttribute<T>(this Type type, bool inherit) where T : Attribute
		{
			return null;
		}

		public static T GetCustomAttribute<T>(this Type type) where T : Attribute
		{
			return null;
		}

		public static IEnumerable<T> GetCustomAttributes<T>(this Type type) where T : Attribute
		{
			return null;
		}

		public static IEnumerable<T> GetCustomAttributes<T>(this Type type, bool inherit) where T : Attribute
		{
			return null;
		}

		public static bool IsDefined<T>(this Type type) where T : Attribute
		{
			return false;
		}

		public static bool IsDefined<T>(this Type type, bool inherit) where T : Attribute
		{
			return false;
		}

		public static bool InheritsFrom<TBase>(this Type type)
		{
			return false;
		}

		public static bool InheritsFrom(this Type type, Type baseType)
		{
			return false;
		}

		public static int GetInheritanceDistance(this Type type, Type baseType)
		{
			return 0;
		}

		public static bool HasParamaters(this MethodInfo methodInfo, IList<Type> paramTypes, bool inherit = true)
		{
			return false;
		}

		public static Type GetReturnType(this MemberInfo memberInfo)
		{
			return null;
		}

		public static object GetMemberValue(this MemberInfo member, object obj)
		{
			return null;
		}

		public static void SetMemberValue(this MemberInfo member, object obj, object value)
		{
		}

		public static bool TryInferGenericParameters(this Type genericTypeDefinition, out Type[] inferredParams, params Type[] knownParameters)
		{
			inferredParams = null;
			return false;
		}

		public static bool AreGenericConstraintsSatisfiedBy(this Type genericType, params Type[] parameters)
		{
			return false;
		}

		public static bool AreGenericConstraintsSatisfiedBy(this MethodBase genericMethod, params Type[] parameters)
		{
			return false;
		}

		public static bool AreGenericConstraintsSatisfiedBy(Type[] definitions, Type[] parameters)
		{
			return false;
		}

		public static bool GenericParameterIsFulfilledBy(this Type genericParameterDefinition, Type parameterType)
		{
			return false;
		}

		private static bool GenericParameterIsFulfilledBy(this Type genericParameterDefinition, Type parameterType, Dictionary<Type, Type> resolvedMap, HashSet<Type> processedParams = null)
		{
			return false;
		}

		public static string GetGenericConstraintsString(this Type type, bool useFullTypeNames = false)
		{
			return null;
		}

		public static string GetGenericParameterConstraintsString(this Type type, bool useFullTypeNames = false)
		{
			return null;
		}

		public static bool GenericArgumentsContainsTypes(this Type type, params Type[] types)
		{
			return false;
		}

		public static bool IsFullyConstructedGenericType(this Type type)
		{
			return false;
		}

		public static bool IsNullableType(this Type type)
		{
			return false;
		}

		public static ulong GetEnumBitmask(object value, Type enumType)
		{
			return 0uL;
		}

		public static bool IsCSharpKeyword(string identifier)
		{
			return false;
		}

		public static Type[] SafeGetTypes(this Assembly assembly)
		{
			return null;
		}

		public static bool SafeIsDefined(this Assembly assembly, Type attribute, bool inherit)
		{
			return false;
		}

		public static object[] SafeGetCustomAttributes(this Assembly assembly, Type type, bool inherit)
		{
			return null;
		}
	}
}
