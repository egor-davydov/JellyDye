using System;
using System.IO;

namespace Newtonsoft.Json.Utilities
{
	internal static class JavaScriptUtils
	{
		internal static readonly bool[] SingleQuoteCharEscapeFlags;

		internal static readonly bool[] DoubleQuoteCharEscapeFlags;

		internal static readonly bool[] HtmlCharEscapeFlags;

		static JavaScriptUtils()
		{
		}

		public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar)
		{
			return null;
		}

		public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags)
		{
			return false;
		}

		public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref char[] writeBuffer)
		{
		}

		public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling)
		{
			return null;
		}

		private static int FirstCharToEscape(string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling)
		{
			return 0;
		}

		public static bool TryGetDateFromConstructorJson(JsonReader reader, out DateTime dateTime, out string errorMessage)
		{
			dateTime = default(DateTime);
			errorMessage = null;
			return false;
		}

		private static bool TryGetDateConstructorValue(JsonReader reader, out long? integer, out string errorMessage)
		{
			integer = null;
			errorMessage = null;
			return false;
		}
	}
}
