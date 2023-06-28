using System;
using System.Collections;
using System.Collections.Generic;

namespace Google.Protobuf
{
	public sealed class ByteString : IEnumerable<byte>, IEnumerable, IEquatable<ByteString>
	{
		private static readonly ByteString empty;

		private readonly ReadOnlyMemory<byte> bytes;

		public static ByteString Empty => null;

		public int Length => 0;

		public ReadOnlySpan<byte> Span => default(ReadOnlySpan<byte>);

		internal static ByteString AttachBytes(ReadOnlyMemory<byte> bytes)
		{
			return null;
		}

		internal static ByteString AttachBytes(byte[] bytes)
		{
			return null;
		}

		private ByteString(ReadOnlyMemory<byte> bytes)
		{
		}

		public string ToBase64()
		{
			return null;
		}

		public static ByteString CopyFrom(params byte[] bytes)
		{
			return null;
		}

		public IEnumerator<byte> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		public CodedInputStream CreateCodedInput()
		{
			return null;
		}

		public static bool operator ==(ByteString lhs, ByteString rhs)
		{
			return false;
		}

		public static bool operator !=(ByteString lhs, ByteString rhs)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool Equals(ByteString other)
		{
			return false;
		}
	}
}
