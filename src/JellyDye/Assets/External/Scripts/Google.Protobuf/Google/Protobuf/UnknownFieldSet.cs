using System.Collections.Generic;

namespace Google.Protobuf
{
	public sealed class UnknownFieldSet
	{
		private readonly IDictionary<int, UnknownField> fields;

		private int lastFieldNumber;

		private UnknownField lastField;

		internal UnknownFieldSet()
		{
		}

		internal bool HasField(int field)
		{
			return false;
		}

		public void WriteTo(CodedOutputStream output)
		{
		}

		public void WriteTo(ref WriteContext ctx)
		{
		}

		public int CalculateSize()
		{
			return 0;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private UnknownField GetOrAddField(int number)
		{
			return null;
		}

		internal UnknownFieldSet AddOrReplaceField(int number, UnknownField field)
		{
			return null;
		}

		private bool MergeFieldFrom(ref ParseContext ctx)
		{
			return false;
		}

		internal void MergeGroupFrom(ref ParseContext ctx)
		{
		}

		public static UnknownFieldSet MergeFieldFrom(UnknownFieldSet unknownFields, CodedInputStream input)
		{
			return null;
		}

		public static UnknownFieldSet MergeFieldFrom(UnknownFieldSet unknownFields, ref ParseContext ctx)
		{
			return null;
		}

		private UnknownFieldSet MergeFrom(UnknownFieldSet other)
		{
			return null;
		}

		public static UnknownFieldSet MergeFrom(UnknownFieldSet unknownFields, UnknownFieldSet other)
		{
			return null;
		}

		private UnknownFieldSet MergeField(int number, UnknownField field)
		{
			return null;
		}

		public static UnknownFieldSet Clone(UnknownFieldSet other)
		{
			return null;
		}
	}
}
