using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.V1.Services
{
	public sealed class GetCloudbuildYAMLRequest : IMessage<GetCloudbuildYAMLRequest>, IMessage, IEquatable<GetCloudbuildYAMLRequest>, IDeepCloneable<GetCloudbuildYAMLRequest>, IBufferMessage
	{
		private static readonly MessageParser<GetCloudbuildYAMLRequest> _parser;

		private UnknownFieldSet _unknownFields;

		public const int UnityVersionFieldNumber = 1;

		private string unityVersion_;

		public const int KeystorePathFieldNumber = 2;

		private string keystorePath_;

		public const int GameIdFieldNumber = 3;

		private string gameId_;

		[DebuggerNonUserCode]
		public static MessageParser<GetCloudbuildYAMLRequest> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string UnityVersion
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
		public string KeystorePath
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
		public string GameId
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
		public GetCloudbuildYAMLRequest()
		{
		}

		[DebuggerNonUserCode]
		public GetCloudbuildYAMLRequest(GetCloudbuildYAMLRequest other)
		{
		}

		[DebuggerNonUserCode]
		public GetCloudbuildYAMLRequest Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(GetCloudbuildYAMLRequest other)
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
		public void MergeFrom(GetCloudbuildYAMLRequest other)
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
