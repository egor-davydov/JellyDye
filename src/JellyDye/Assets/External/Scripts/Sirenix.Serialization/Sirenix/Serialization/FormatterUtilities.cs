using System;
using System.Collections.Generic;
using System.Reflection;
using Sirenix.Serialization.Utilities;
using UnityEngine;

namespace Sirenix.Serialization
{
	public static class FormatterUtilities
	{
		private static readonly DoubleLookupDictionary<ISerializationPolicy, Type, MemberInfo[]> MemberArrayCache;

		private static readonly DoubleLookupDictionary<ISerializationPolicy, Type, Dictionary<string, MemberInfo>> MemberMapCache;

		private static readonly object LOCK;

		private static readonly HashSet<Type> PrimitiveArrayTypes;

		private static readonly FieldInfo UnityObjectRuntimeErrorStringField;

		private const string UnityObjectRuntimeErrorString = "The variable nullValue of {0} has not been assigned.\r\nYou probably need to assign the nullValue variable of the {0} script in the inspector.";

		static FormatterUtilities()
		{
		}

		public static Dictionary<string, MemberInfo> GetSerializableMembersMap(Type type, ISerializationPolicy policy)
		{
			return null;
		}

		public static MemberInfo[] GetSerializableMembers(Type type, ISerializationPolicy policy)
		{
			return null;
		}

		public static UnityEngine.Object CreateUnityNull(Type nullType, Type owningType)
		{
			return null;
		}

		public static bool IsPrimitiveType(Type type)
		{
			return false;
		}

		public static bool IsPrimitiveArrayType(Type type)
		{
			return false;
		}

		public static Type GetContainedType(MemberInfo member)
		{
			return null;
		}

		public static object GetMemberValue(MemberInfo member, object obj)
		{
			return null;
		}

		public static void SetMemberValue(MemberInfo member, object obj, object value)
		{
		}

		private static Dictionary<string, MemberInfo> FindSerializableMembersMap(Type type, ISerializationPolicy policy)
		{
			return null;
		}

		private static void FindSerializableMembers(Type type, List<MemberInfo> members, ISerializationPolicy policy)
		{
		}

		internal static MemberInfo GetPrivateMemberAlias(MemberInfo member, string prefixString = null, string separatorString = null)
		{
			return null;
		}

		private static bool MemberIsPrivate(MemberInfo member)
		{
			return false;
		}
	}
}
