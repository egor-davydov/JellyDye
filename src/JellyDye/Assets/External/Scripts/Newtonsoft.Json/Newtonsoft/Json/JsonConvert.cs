using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json
{
	public static class JsonConvert
	{
		public static readonly string True;

		public static readonly string False;

		public static readonly string Null;

		public static readonly string Undefined;

		public static readonly string PositiveInfinity;

		public static readonly string NegativeInfinity;

		public static readonly string NaN;

		public static Func<JsonSerializerSettings> DefaultSettings
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public static string ToString(bool value)
		{
			return null;
		}

		public static string ToString(char value)
		{
			return null;
		}

		internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return null;
		}

		private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return null;
		}

		internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return null;
		}

		private static string EnsureDecimalPlace(double value, string text)
		{
			return null;
		}

		private static string EnsureDecimalPlace(string text)
		{
			return null;
		}

		public static string ToString(decimal value)
		{
			return null;
		}

		public static string ToString(string value)
		{
			return null;
		}

		public static string ToString(string value, char delimiter)
		{
			return null;
		}

		public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling)
		{
			return null;
		}

		[DebuggerStepThrough]
		public static string SerializeObject(object value)
		{
			return null;
		}

		[DebuggerStepThrough]
		public static string SerializeObject(object value, JsonSerializerSettings settings)
		{
			return null;
		}

		[DebuggerStepThrough]
		public static string SerializeObject(object value, Type type, JsonSerializerSettings settings)
		{
			return null;
		}

		[DebuggerStepThrough]
		public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings)
		{
			return null;
		}

		[DebuggerStepThrough]
		public static string SerializeObject(object value, Type type, Formatting formatting, JsonSerializerSettings settings)
		{
			return null;
		}

		private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer)
		{
			return null;
		}

		[DebuggerStepThrough]
		public static T DeserializeObject<T>(string value)
		{
			return default(T);
		}

		[DebuggerStepThrough]
		public static T DeserializeObject<T>(string value, JsonSerializerSettings settings)
		{
			return default(T);
		}

		public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings)
		{
			return null;
		}
	}
}
