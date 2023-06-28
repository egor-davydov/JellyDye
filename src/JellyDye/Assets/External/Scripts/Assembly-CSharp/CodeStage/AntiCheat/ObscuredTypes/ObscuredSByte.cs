using System;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredSByte : IEquatable<ObscuredSByte>, IFormattable
	{
		private static sbyte cryptoKey;

		private sbyte currentCryptoKey;

		private sbyte hiddenValue;

		private bool inited;

		private sbyte fakeValue;

		private bool fakeValueActive;

		private ObscuredSByte(sbyte value)
		{
		}

		public static void SetNewCryptoKey(sbyte newKey)
		{
		}

		public static sbyte EncryptDecrypt(sbyte value)
		{
			return 0;
		}

		public static sbyte EncryptDecrypt(sbyte value, sbyte key)
		{
			return 0;
		}

		public void ApplyNewCryptoKey()
		{
		}

		public void RandomizeCryptoKey()
		{
		}

		public sbyte GetEncrypted()
		{
			return 0;
		}

		public void SetEncrypted(sbyte encrypted)
		{
		}

		public sbyte GetDecrypted()
		{
			return 0;
		}

		private sbyte InternalDecrypt()
		{
			return 0;
		}

		public static implicit operator ObscuredSByte(sbyte value)
		{
			return default(ObscuredSByte);
		}

		public static implicit operator sbyte(ObscuredSByte value)
		{
			return 0;
		}

		public static ObscuredSByte operator ++(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		public static ObscuredSByte operator --(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ObscuredSByte obj)
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
