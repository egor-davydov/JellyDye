using System;
using System.Globalization;
using System.IO;
using System.Xml;

namespace Newtonsoft.Json.Utilities
{
	internal static class DateTimeUtils
	{
		internal static readonly long InitialJavaScriptDateTicks;

		private static readonly int[] DaysToMonth365;

		private static readonly int[] DaysToMonth366;

		static DateTimeUtils()
		{
		}

		public static TimeSpan GetUtcOffset(this DateTime d)
		{
			return default(TimeSpan);
		}

		public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind)
		{
			return default(XmlDateTimeSerializationMode);
		}

		internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone)
		{
			return default(DateTime);
		}

		private static DateTime SwitchToLocalTime(DateTime value)
		{
			return default(DateTime);
		}

		private static DateTime SwitchToUtcTime(DateTime value)
		{
			return default(DateTime);
		}

		private static long ToUniversalTicks(DateTime dateTime)
		{
			return 0L;
		}

		private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset)
		{
			return 0L;
		}

		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset)
		{
			return 0L;
		}

		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime)
		{
			return 0L;
		}

		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc)
		{
			return 0L;
		}

		private static long UniversalTicksToJavaScriptTicks(long universalTicks)
		{
			return 0L;
		}

		internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks)
		{
			return default(DateTime);
		}

		internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt)
		{
			dt = default(DateTime);
			return false;
		}

		internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt)
		{
			dt = default(DateTimeOffset);
			return false;
		}

		private static DateTime CreateDateTime(DateTimeParser dateTimeParser)
		{
			return default(DateTime);
		}

		internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			dt = default(DateTime);
			return false;
		}

		internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			dt = default(DateTime);
			return false;
		}

		internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			dt = default(DateTimeOffset);
			return false;
		}

		internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			dt = default(DateTimeOffset);
			return false;
		}

		private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind)
		{
			ticks = default(long);
			offset = default(TimeSpan);
			kind = default(DateTimeKind);
			return false;
		}

		private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt)
		{
			dt = default(DateTime);
			return false;
		}

		private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			dt = default(DateTime);
			return false;
		}

		private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt)
		{
			dt = default(DateTimeOffset);
			return false;
		}

		private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			dt = default(DateTimeOffset);
			return false;
		}

		private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset)
		{
			offset = default(TimeSpan);
			return false;
		}

		internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture)
		{
		}

		internal static int WriteDateTimeString(char[] chars, int start, DateTime value, TimeSpan? offset, DateTimeKind kind, DateFormatHandling format)
		{
			return 0;
		}

		internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt)
		{
			return 0;
		}

		private static void CopyIntToCharArray(char[] chars, int start, int value, int digits)
		{
		}

		internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format)
		{
			return 0;
		}

		internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture)
		{
		}

		private static void GetDateValues(DateTime td, out int year, out int month, out int day)
		{
			year = default(int);
			month = default(int);
			day = default(int);
		}
	}
}
