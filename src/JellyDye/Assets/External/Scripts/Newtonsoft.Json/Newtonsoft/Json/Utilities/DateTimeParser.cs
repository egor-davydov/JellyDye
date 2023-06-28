namespace Newtonsoft.Json.Utilities
{
	internal struct DateTimeParser
	{
		public int Year;

		public int Month;

		public int Day;

		public int Hour;

		public int Minute;

		public int Second;

		public int Fraction;

		public int ZoneHour;

		public int ZoneMinute;

		public ParserTimeZone Zone;

		private char[] _text;

		private int _end;

		private static readonly int[] Power10;

		private static readonly int Lzyyyy;

		private static readonly int Lzyyyy_;

		private static readonly int Lzyyyy_MM;

		private static readonly int Lzyyyy_MM_;

		private static readonly int Lzyyyy_MM_dd;

		private static readonly int Lzyyyy_MM_ddT;

		private static readonly int LzHH;

		private static readonly int LzHH_;

		private static readonly int LzHH_mm;

		private static readonly int LzHH_mm_;

		private static readonly int LzHH_mm_ss;

		private static readonly int Lz_;

		private static readonly int Lz_zz;

		static DateTimeParser()
		{
		}

		public bool Parse(char[] text, int startIndex, int length)
		{
			return false;
		}

		private bool ParseDate(int start)
		{
			return false;
		}

		private bool ParseTimeAndZoneAndWhitespace(int start)
		{
			return false;
		}

		private bool ParseTime(ref int start)
		{
			return false;
		}

		private bool ParseZone(int start)
		{
			return false;
		}

		private bool Parse4Digit(int start, out int num)
		{
			num = default(int);
			return false;
		}

		private bool Parse2Digit(int start, out int num)
		{
			num = default(int);
			return false;
		}

		private bool ParseChar(int start, char ch)
		{
			return false;
		}
	}
}
