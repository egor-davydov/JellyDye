using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.V1.Resources
{
	public sealed class App : IMessage<App>, IMessage, IEquatable<App>, IDeepCloneable<App>, IBufferMessage
	{
		private static readonly MessageParser<App> _parser;

		private UnknownFieldSet _unknownFields;

		public const int IdFieldNumber = 1;

		private string id_;

		public const int VersionFieldNumber = 2;

		private string version_;

		public const int DisplayNameFieldNumber = 3;

		private string displayName_;

		public const int IconUrlFieldNumber = 4;

		private string iconUrl_;

		public const int BundleIdFieldNumber = 5;

		private string bundleId_;

		public const int EnabledFieldNumber = 6;

		private bool enabled_;

		public const int PlatformsFieldNumber = 7;

		private static readonly MapField<string, Platform>.Codec _map_platforms_codec;

		private readonly MapField<string, Platform> platforms_;

		public const int GitlabFieldNumber = 8;

		private Gitlab gitlab_;

		public const int CloudbuildFieldNumber = 9;

		private Cloudbuild cloudbuild_;

		public const int TiktokAccountIdsFieldNumber = 10;

		private static readonly FieldCodec<string> _repeated_tiktokAccountIds_codec;

		private readonly RepeatedField<string> tiktokAccountIds_;

		public const int FacebookAccountIdsFieldNumber = 11;

		private static readonly FieldCodec<string> _repeated_facebookAccountIds_codec;

		private readonly RepeatedField<string> facebookAccountIds_;

		[DebuggerNonUserCode]
		public static MessageParser<App> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string Id
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
		public string Version
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
		public string DisplayName
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
		public string IconUrl
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
		public string BundleId
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
		public bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public MapField<string, Platform> Platforms => null;

		[DebuggerNonUserCode]
		public Gitlab Gitlab
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
		public Cloudbuild Cloudbuild
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
		public RepeatedField<string> TiktokAccountIds => null;

		[DebuggerNonUserCode]
		public RepeatedField<string> FacebookAccountIds => null;

		[DebuggerNonUserCode]
		public App()
		{
		}

		[DebuggerNonUserCode]
		public App(App other)
		{
		}

		[DebuggerNonUserCode]
		public App Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(App other)
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
		public void MergeFrom(App other)
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
