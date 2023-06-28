using System.IO;

namespace Newtonsoft.Json.Utilities
{
	internal class Base64Encoder
	{
		private readonly char[] _charsLine;

		private readonly TextWriter _writer;

		private byte[] _leftOverBytes;

		private int _leftOverBytesCount;

		public Base64Encoder(TextWriter writer)
		{
		}

		private void ValidateEncode(byte[] buffer, int index, int count)
		{
		}

		public void Encode(byte[] buffer, int index, int count)
		{
		}

		private void StoreLeftOverBytes(byte[] buffer, int index, ref int count)
		{
		}

		private bool FulfillFromLeftover(byte[] buffer, int index, ref int count)
		{
			return false;
		}

		public void Flush()
		{
		}

		private void WriteChars(char[] chars, int index, int count)
		{
		}
	}
}
