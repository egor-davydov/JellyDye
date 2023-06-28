using System;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredByte : IEquatable<ObscuredByte>, IFormattable
	{
		private static byte cryptoKey;

		private byte currentCryptoKey;

		private byte hiddenValue;

		private bool inited;

		private byte fakeValue;

		private bool fakeValueActive;

		private ObscuredByte(byte value)
		{
		}

		public static void SetNewCryptoKey(byte newKey)
		{
		}

		public static byte EncryptDecrypt(byte value)
		{
			return 0;
		}

		public static byte EncryptDecrypt(byte value, byte key)
		{
			return 0;
		}

		public void ApplyNewCryptoKey()
		{
		}

		public void RandomizeCryptoKey()
		{
		}

		public byte GetEncrypted()
		{
			return 0;
		}

		public void SetEncrypted(byte encrypted)
		{
		}

		public byte GetDecrypted()
		{
			return 0;
		}

		private byte InternalDecrypt()
		{
			return 0;
		}

		public static implicit operator ObscuredByte(byte value)
		{
			return default(ObscuredByte);
		}

		public static implicit operator byte(ObscuredByte value)
		{
			return 0;
		}

		public static ObscuredByte operator ++(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		public static ObscuredByte operator --(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ObscuredByte obj)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(string format)
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
}
