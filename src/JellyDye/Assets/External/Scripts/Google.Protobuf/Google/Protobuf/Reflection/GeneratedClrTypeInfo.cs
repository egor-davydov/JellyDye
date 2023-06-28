using System;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	public sealed class GeneratedClrTypeInfo
	{
		private static readonly string[] EmptyNames;

		private static readonly GeneratedClrTypeInfo[] EmptyCodeInfo;

		private static readonly Extension[] EmptyExtensions;

		public Type ClrType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public MessageParser Parser
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string[] PropertyNames
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Extension[] Extensions
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string[] OneofNames
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public GeneratedClrTypeInfo[] NestedTypes
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Type[] NestedEnums
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public GeneratedClrTypeInfo(Type clrType, MessageParser parser, string[] propertyNames, string[] oneofNames, Type[] nestedEnums, Extension[] extensions, GeneratedClrTypeInfo[] nestedTypes)
		{
		}

		public GeneratedClrTypeInfo(Type clrType, MessageParser parser, string[] propertyNames, string[] oneofNames, Type[] nestedEnums, GeneratedClrTypeInfo[] nestedTypes)
		{
		}

		public GeneratedClrTypeInfo(Type[] nestedEnums, Extension[] extensions, GeneratedClrTypeInfo[] nestedTypes)
		{
		}

		public GeneratedClrTypeInfo(Type[] nestedEnums, GeneratedClrTypeInfo[] nestedTypes)
		{
		}
	}
}
