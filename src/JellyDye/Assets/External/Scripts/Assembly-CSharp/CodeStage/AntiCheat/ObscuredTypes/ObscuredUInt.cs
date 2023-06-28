using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredUInt : IEquatable<ObscuredUInt>, IFormattable
	{
		private static uint cryptoKey;

		[SerializeField]
		private uint currentCryptoKey;

		[SerializeField]
		private uint hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private uint fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredUInt(uint value)
		{
		}

		public static void SetNewCryptoKey(uint newKey)
		{
		}

		public static uint Encrypt(uint value)
		{
			return 0u;
		}

		public static uint Decrypt(uint value)
		{
			return 0u;
		}

		public static uint Encrypt(uint value, uint key)
		{
			return 0u;
		}

		public static uint Decrypt(uint value, uint key)
		{
			return 0u;
		}

		public void ApplyNewCryptoKey()
		{
		}

		public void RandomizeCryptoKey()
		{
		}

		public uint GetEncrypted()
		{
			return 0u;
		}

		public void SetEncrypted(uint encrypted)
		{
		}

		public uint GetDecrypted()
		{
			return 0u;
		}

		private uint InternalDecrypt()
		{
			return 0u;
		}

		public static implicit operator ObscuredUInt(uint value)
		{
			return default(ObscuredUInt);
		}

		public static implicit operator uint(ObscuredUInt value)
		{
			return 0u;
		}

		public static explicit operator ObscuredInt(ObscuredUInt value)
		{
			return default(ObscuredInt);
		}

		public static ObscuredUInt operator ++(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		public static ObscuredUInt operator --(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ObscuredUInt obj)
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
