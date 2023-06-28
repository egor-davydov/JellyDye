using System;
using System.Collections.Generic;
using System.Reflection;

namespace Sirenix.Serialization
{
	public class DefaultSerializationBinder : TwoWaySerializationBinder
	{
		private static readonly object ASSEMBLY_LOOKUP_LOCK;

		private static readonly Dictionary<string, Assembly> assemblyNameLookUp;

		private static readonly Dictionary<string, Type> customTypeNameToTypeBindings;

		private static readonly object TYPETONAME_LOCK;

		private static readonly Dictionary<Type, string> nameMap;

		private static readonly object NAMETOTYPE_LOCK;

		private static readonly Dictionary<string, Type> typeMap;

		private static readonly List<string> genericArgNamesList;

		private static readonly List<Type> genericArgTypesList;

		static DefaultSerializationBinder()
		{
		}

		private static void RegisterAssembly(Assembly assembly)
		{
		}

		public override string BindToName(Type type, DebugContext debugContext = null)
		{
			return null;
		}

		public override bool ContainsType(string typeName)
		{
			return false;
		}

		public override Type BindToType(string typeName, DebugContext debugContext = null)
		{
			return null;
		}

		private Type ParseTypeName(string typeName, DebugContext debugContext)
		{
			return null;
		}

		private static void ParseName(string fullName, out string typeName, out string assemblyName)
		{
			typeName = null;
			assemblyName = null;
		}

		private Type ParseGenericAndOrArrayType(string typeName, DebugContext debugContext)
		{
			return null;
		}

		private static bool TryParseGenericAndOrArrayTypeName(string typeName, out string actualTypeName, out bool isGeneric, out List<string> genericArgNames, out bool isArray, out int arrayRank)
		{
			actualTypeName = null;
			isGeneric = default(bool);
			genericArgNames = null;
			isArray = default(bool);
			arrayRank = default(int);
			return false;
		}

		private static char Peek(string str, int i, int ahead)
		{
			return '\0';
		}

		private static bool ReadGenericArg(string typeName, ref int i, out string argName)
		{
			argName = null;
			return false;
		}
	}
}
