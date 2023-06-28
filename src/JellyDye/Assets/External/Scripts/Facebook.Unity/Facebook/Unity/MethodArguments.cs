using System;
using System.Collections.Generic;

namespace Facebook.Unity
{
	internal class MethodArguments
	{
		private IDictionary<string, object> arguments;

		public MethodArguments()
		{
		}

		public MethodArguments(MethodArguments methodArgs)
		{
		}

		private MethodArguments(IDictionary<string, object> arguments)
		{
		}

		public void AddPrimative<T>(string argumentName, T value) where T : struct
		{
		}

		public void AddNullablePrimitive<T>(string argumentName, T? nullable) where T : struct
		{
		}

		public void AddString(string argumentName, string value)
		{
		}

		public void AddCommaSeparatedList(string argumentName, IEnumerable<string> value)
		{
		}

		public void AddDictionary(string argumentName, IDictionary<string, object> dict)
		{
		}

		public void AddList<T>(string argumentName, IEnumerable<T> list)
		{
		}

		public void AddUri(string argumentName, Uri uri)
		{
		}

		public string ToJsonString()
		{
			return null;
		}

		private static Dictionary<string, string> ToStringDict(IDictionary<string, object> dict)
		{
			return null;
		}
	}
}
