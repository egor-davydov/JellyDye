using System;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredFloat : IEquatable<ObscuredFloat>, IFormattable
	{
		[StructLayout(2)]
		private struct FloatIntBytesUnion
		{
			[FieldOffset(0)]
			public float f;

			[FieldOffset(0)]
			public int i;

			[FieldOffset(0)]
			public ACTkByte4 b4;
		}

		private static int cryptoKey;

		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private ACTkByte4 hiddenValue;

		[SerializeField]
		private byte[] hiddenValueOld;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private float fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredFloat(float value)
		{
		}

		public static void SetNewCryptoKey(int newKey)
		{
		}

		public static int Encrypt(float value)
		{
			return 0;
		}

		public static int Encrypt(float value, int key)
		{
			return 0;
		}

		private static ACTkByte4 InternalEncrypt(float value)
		{
			return default(ACTkByte4);
		}

		private static ACTkByte4 InternalEncrypt(float value, int key)
		{
			return default(ACTkByte4);
		}

		public static float Decrypt(int value)
		{
			return 0f;
		}

		public static float Decrypt(int value, int key)
		{
			return 0f;
		}

		public void ApplyNewCryptoKey()
		{
		}

		public void RandomizeCryptoKey()
		{
		}

		public int GetEncrypted()
		{
			return 0;
		}

		public void SetEncrypted(int encrypted)
		{
		}

		public float GetDecrypted()
		{
			return 0f;
		}

		private float InternalDecrypt()
		{
			return 0f;
		}

		public static implicit operator ObscuredFloat(float value)
		{
			return default(ObscuredFloat);
		}

		public static implicit operator float(ObscuredFloat value)
		{
			return 0f;
		}

		public static ObscuredFloat operator ++(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		public static ObscuredFloat operator --(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ObscuredFloat obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
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
	}
}
