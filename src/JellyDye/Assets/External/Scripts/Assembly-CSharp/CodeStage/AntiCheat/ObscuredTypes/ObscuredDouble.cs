using System;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredDouble : IEquatable<ObscuredDouble>, IFormattable
	{
		[StructLayout(2)]
		private struct DoubleLongBytesUnion
		{
			[FieldOffset(0)]
			public double d;

			[FieldOffset(0)]
			public long l;

			[FieldOffset(0)]
			public ACTkByte8 b8;
		}

		private static long cryptoKey;

		[SerializeField]
		private long currentCryptoKey;

		[SerializeField]
		private ACTkByte8 hiddenValue;

		[SerializeField]
		private byte[] hiddenValueOld;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private double fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredDouble(double value)
		{
		}

		public static void SetNewCryptoKey(long newKey)
		{
		}

		public static long Encrypt(double value)
		{
			return 0L;
		}

		public static long Encrypt(double value, long key)
		{
			return 0L;
		}

		private static ACTkByte8 InternalEncrypt(double value)
		{
			return default(ACTkByte8);
		}

		private static ACTkByte8 InternalEncrypt(double value, long key)
		{
			return default(ACTkByte8);
		}

		public static double Decrypt(long value)
		{
			return 0.0;
		}

		public static double Decrypt(long value, long key)
		{
			return 0.0;
		}

		public void ApplyNewCryptoKey()
		{
		}

		public void RandomizeCryptoKey()
		{
		}

		public long GetEncrypted()
		{
			return 0L;
		}

		public void SetEncrypted(long encrypted)
		{
		}

		public double GetDecrypted()
		{
			return 0.0;
		}

		private double InternalDecrypt()
		{
			return 0.0;
		}

		public static implicit operator ObscuredDouble(double value)
		{
			return default(ObscuredDouble);
		}

		public static implicit operator double(ObscuredDouble value)
		{
			return 0.0;
		}

		public static ObscuredDouble operator ++(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		public static ObscuredDouble operator --(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(string format)
		{
			return null;
		}

		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ObscuredDouble obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
