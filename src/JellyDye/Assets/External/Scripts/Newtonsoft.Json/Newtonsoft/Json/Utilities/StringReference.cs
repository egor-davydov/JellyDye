namespace Newtonsoft.Json.Utilities
{
	internal readonly struct StringReference
	{
		private readonly char[] _chars;

		private readonly int _startIndex;

		private readonly int _length;

		public char Item => '\0';

		public char[] Chars => null;

		public int StartIndex => 0;

		public int Length => 0;

		public StringReference(char[] chars, int startIndex, int length)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
