namespace Newtonsoft.Json
{
	public class DefaultJsonNameTable : JsonNameTable
	{
		private class Entry
		{
			internal readonly string Value;

			internal readonly int HashCode;

			internal Entry Next;

			internal Entry(string value, int hashCode, Entry next)
			{
			}
		}

		private static readonly int HashCodeRandomizer;

		private int _count;

		private Entry[] _entries;

		private int _mask;

		static DefaultJsonNameTable()
		{
		}

		public override string Get(char[] key, int start, int length)
		{
			return null;
		}

		public string Add(string key)
		{
			return null;
		}

		private string AddEntry(string str, int hashCode)
		{
			return null;
		}

		private void Grow()
		{
		}

		private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length)
		{
			return false;
		}
	}
}
