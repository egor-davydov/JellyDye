using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.V1.Resources
{
	public sealed class Bigquery : IMessage<Bigquery>, IMessage, IEquatable<Bigquery>, IDeepCloneable<Bigquery>, IBufferMessage
	{
		private static readonly MessageParser<Bigquery> _parser;

		private UnknownFieldSet _unknownFields;

		public const int AnalyticsIdFieldNumber = 1;

		private string analyticsId_;

		public const int ProjectIdFieldNumber = 2;

		private string projectId_;

		public const int CredentialsS3KeyFieldNumber = 3;

		private string credentialsS3Key_;

		public const int FirebaseAppIdFieldNumber = 4;

		private string firebaseAppId_;

		[DebuggerNonUserCode]
		public static MessageParser<Bigquery> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string AnalyticsId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string ProjectId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string CredentialsS3Key
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string FirebaseAppId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public Bigquery()
		{
		}

		[DebuggerNonUserCode]
		public Bigquery(Bigquery other)
		{
		}

		[DebuggerNonUserCode]
		public Bigquery Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Bigquery other)
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
		public void MergeFrom(Bigquery other)
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
	}
}
