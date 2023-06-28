using System;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	public class DiscriminatedUnionConverter : JsonConverter
	{
		internal class Union
		{
			public readonly FSharpFunction TagReader;

			public readonly List<UnionCase> Cases;

			public Union(FSharpFunction tagReader, List<UnionCase> cases)
			{
			}
		}

		internal class UnionCase
		{
			public readonly int Tag;

			public readonly string Name;

			public readonly PropertyInfo[] Fields;

			public readonly FSharpFunction FieldReader;

			public readonly FSharpFunction Constructor;

			public UnionCase(int tag, string name, PropertyInfo[] fields, FSharpFunction fieldReader, FSharpFunction constructor)
			{
			}
		}

		private const string CasePropertyName = "Case";

		private const string FieldsPropertyName = "Fields";

		private static readonly ThreadSafeStore<Type, Union> UnionCache;

		private static readonly ThreadSafeStore<Type, Type> UnionTypeLookupCache;

		private static Type CreateUnionTypeLookup(Type t)
		{
			return null;
		}

		private static Union CreateUnion(Type t)
		{
			return null;
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		public override bool CanConvert(Type objectType)
		{
			return false;
		}
	}
}
