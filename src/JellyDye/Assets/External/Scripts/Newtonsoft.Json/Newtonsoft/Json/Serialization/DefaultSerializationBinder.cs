using System;
using System.Reflection;
using System.Runtime.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	public class DefaultSerializationBinder : SerializationBinder, ISerializationBinder
	{
		internal static readonly DefaultSerializationBinder Instance;

		private readonly ThreadSafeStore<StructMultiKey<string, string>, Type> _typeCache;

		private Type GetTypeFromTypeNameKey(StructMultiKey<string, string> typeNameKey)
		{
			return null;
		}

		private Type GetGenericTypeFromTypeName(string typeName, Assembly assembly)
		{
			return null;
		}

		private Type GetTypeByName(StructMultiKey<string, string> typeNameKey)
		{
			return null;
		}

		public override Type BindToType(string assemblyName, string typeName)
		{
			return null;
		}

		public override void BindToName(Type serializedType, out string assemblyName, out string typeName)
		{
			assemblyName = null;
			typeName = null;
		}
	}
}
