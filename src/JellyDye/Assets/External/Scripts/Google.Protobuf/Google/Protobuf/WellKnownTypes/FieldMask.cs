using System;
using System.Collections.Generic;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public sealed class FieldMask : IMessage<FieldMask>, IMessage, IEquatable<FieldMask>, IDeepCloneable<FieldMask>, IBufferMessage, ICustomDiagnosticMessage
	{
		private static readonly MessageParser<FieldMask> _parser;

		private UnknownFieldSet _unknownFields;

		private static readonly FieldCodec<string> _repeated_paths_codec;

		private readonly RepeatedField<string> paths_;

		[DebuggerNonUserCode]
		public static MessageParser<FieldMask> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public RepeatedField<string> Paths => null;

		[DebuggerNonUserCode]
		public FieldMask()
		{
		}

		[DebuggerNonUserCode]
		public FieldMask(FieldMask other)
		{
		}

		[DebuggerNonUserCode]
		public FieldMask Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(FieldMask other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[DebuggerNonUserCode]
		private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
		{
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(FieldMask other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[DebuggerNonUserCode]
		private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
		{
		}

		internal static string ToJson(IList<string> paths, bool diagnosticOnly)
		{
			return null;
		}

		public string ToDiagnosticString()
		{
			return null;
		}

		private static bool IsPathValid(string input)
		{
			return false;
		}
	}
}
