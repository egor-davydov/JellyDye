using System;
using System.Runtime.InteropServices;

namespace Sirenix.Serialization
{
	public static class ProperBitConverter
	{
		[StructLayout(2)]
		private struct SingleByteUnion
		{
			[FieldOffset(0)]
			public byte Byte0;

			[FieldOffset(1)]
			public byte Byte1;

			[FieldOffset(2)]
			public byte Byte2;

			[FieldOffset(3)]
			public byte Byte3;

			[FieldOffset(0)]
			public float Value;
		}

		[StructLayout(2)]
		private struct DoubleByteUnion
		{
			[FieldOffset(0)]
			public byte Byte0;

			[FieldOffset(1)]
			public byte Byte1;

			[FieldOffset(2)]
			public byte Byte2;

			[FieldOffset(3)]
			public byte Byte3;

			[FieldOffset(4)]
			public byte Byte4;

			[FieldOffset(5)]
			public byte Byte5;

			[FieldOffset(6)]
			public byte Byte6;

			[FieldOffset(7)]
			public byte Byte7;

			[FieldOffset(0)]
			public double Value;
		}

		[StructLayout(2)]
		private struct DecimalByteUnion
		{
			[FieldOffset(0)]
			public byte Byte0;

			[FieldOffset(1)]
			public byte Byte1;

			[FieldOffset(2)]
			public byte Byte2;

			[FieldOffset(3)]
			public byte Byte3;

			[FieldOffset(4)]
			public byte Byte4;

			[FieldOffset(5)]
			public byte Byte5;

			[FieldOffset(6)]
			public byte Byte6;

			[FieldOffset(7)]
			public byte Byte7;

			[FieldOffset(8)]
			public byte Byte8;

			[FieldOffset(9)]
			public byte Byte9;

			[FieldOffset(10)]
			public byte Byte10;

			[FieldOffset(11)]
			public byte Byte11;

			[FieldOffset(12)]
			public byte Byte12;

			[FieldOffset(13)]
			public byte Byte13;

			[FieldOffset(14)]
			public byte Byte14;

			[FieldOffset(15)]
			public byte Byte15;

			[FieldOffset(0)]
			public decimal Value;
		}

		[StructLayout(2)]
		private struct GuidByteUnion
		{
			[FieldOffset(0)]
			public byte Byte0;

			[FieldOffset(1)]
			public byte Byte1;

			[FieldOffset(2)]
			public byte Byte2;

			[FieldOffset(3)]
			public byte Byte3;

			[FieldOffset(4)]
			public byte Byte4;

			[FieldOffset(5)]
			public byte Byte5;

			[FieldOffset(6)]
			public byte Byte6;

			[FieldOffset(7)]
			public byte Byte7;

			[FieldOffset(8)]
			public byte Byte8;

			[FieldOffset(9)]
			public byte Byte9;

			[FieldOffset(10)]
			public byte Byte10;

			[FieldOffset(11)]
			public byte Byte11;

			[FieldOffset(12)]
			public byte Byte12;

			[FieldOffset(13)]
			public byte Byte13;

			[FieldOffset(14)]
			public byte Byte14;

			[FieldOffset(15)]
			public byte Byte15;

			[FieldOffset(0)]
			public Guid Value;
		}

		private static readonly uint[] ByteToHexCharLookupLowerCase;

		private static readonly uint[] ByteToHexCharLookupUpperCase;

		private static readonly byte[] HexToByteLookup;

		private static uint[] CreateByteToHexLookup(bool upperCase)
		{
			return null;
		}

		public static string BytesToHexString(byte[] bytes, bool lowerCaseHexChars = true)
		{
			return null;
		}

		public static byte[] HexStringToBytes(string hex)
		{
			return null;
		}

		public static short ToInt16(byte[] buffer, int index)
		{
			return 0;
		}

		public static ushort ToUInt16(byte[] buffer, int index)
		{
			return 0;
		}

		public static int ToInt32(byte[] buffer, int index)
		{
			return 0;
		}

		public static uint ToUInt32(byte[] buffer, int index)
		{
			return 0u;
		}

		public static long ToInt64(byte[] buffer, int index)
		{
			return 0L;
		}

		public static ulong ToUInt64(byte[] buffer, int index)
		{
			return 0uL;
		}

		public static float ToSingle(byte[] buffer, int index)
		{
			return 0f;
		}

		public static double ToDouble(byte[] buffer, int index)
		{
			return 0.0;
		}

		public static decimal ToDecimal(byte[] buffer, int index)
		{
			return default(decimal);
		}

		public static Guid ToGuid(byte[] buffer, int index)
		{
			return default(Guid);
		}

		public static void GetBytes(byte[] buffer, int index, short value)
		{
		}

		public static void GetBytes(byte[] buffer, int index, ushort value)
		{
		}

		public static void GetBytes(byte[] buffer, int index, int value)
		{
		}

		public static void GetBytes(byte[] buffer, int index, uint value)
		{
		}

		public static void GetBytes(byte[] buffer, int index, long value)
		{
		}

		public static void GetBytes(byte[] buffer, int index, ulong value)
		{
		}

		public static void GetBytes(byte[] buffer, int index, float value)
		{
		}

		public static void GetBytes(byte[] buffer, int index, double value)
		{
		}

		public static void GetBytes(byte[] buffer, int index, decimal value)
		{
		}

		public static void GetBytes(byte[] buffer, int index, Guid value)
		{
		}
	}
}
