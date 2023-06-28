using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredShort : IEquatable<ObscuredShort>, IFormattable
	{
		private static short cryptoKey;

		[SerializeField]
		private short currentCryptoKey;

		[SerializeField]
		private short hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private short fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredShort(short value)
		{
		}

		public static void SetNewCryptoKey(short newKey)
		{
		}

		public static short EncryptDecrypt(short value)
		{
			return 0;
		}

		public static short EncryptDecrypt(short value, short key)
		{
			return 0;
		}

		public void ApplyNewCryptoKey()
		{
		}

		public void RandomizeCryptoKey()
		{
		}

		public short GetEncrypted()
		{
			return 0;
		}

		public void SetEncrypted(short encrypted)
		{
		}

		public short GetDecrypted()
		{
			return 0;
		}

		private short InternalDecrypt()
		{
			return 0;
		}

		public static implicit operator ObscuredShort(short value)
		{
			return default(ObscuredShort);
		}

		public static implicit operator short(ObscuredShort value)
		{
			return 0;
		}

		public static ObscuredShort operator ++(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		public static ObscuredShort operator --(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ObscuredShort obj)
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
