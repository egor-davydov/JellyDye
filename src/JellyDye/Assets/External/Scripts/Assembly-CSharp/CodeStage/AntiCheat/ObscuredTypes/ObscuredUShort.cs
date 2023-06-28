using System;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredUShort : IEquatable<ObscuredUShort>, IFormattable
	{
		private static ushort cryptoKey;

		private ushort currentCryptoKey;

		private ushort hiddenValue;

		private bool inited;

		private ushort fakeValue;

		private bool fakeValueActive;

		private ObscuredUShort(ushort value)
		{
		}

		public static void SetNewCryptoKey(ushort newKey)
		{
		}

		public static ushort EncryptDecrypt(ushort value)
		{
			return 0;
		}

		public static ushort EncryptDecrypt(ushort value, ushort key)
		{
			return 0;
		}

		public void ApplyNewCryptoKey()
		{
		}

		public void RandomizeCryptoKey()
		{
		}

		public ushort GetEncrypted()
		{
			return 0;
		}

		public void SetEncrypted(ushort encrypted)
		{
		}

		public ushort GetDecrypted()
		{
			return 0;
		}

		private ushort InternalDecrypt()
		{
			return 0;
		}

		public static implicit operator ObscuredUShort(ushort value)
		{
			return default(ObscuredUShort);
		}

		public static implicit operator ushort(ObscuredUShort value)
		{
			return 0;
		}

		public static ObscuredUShort operator ++(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		public static ObscuredUShort operator --(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ObscuredUShort obj)
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
