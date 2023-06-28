using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	public abstract class JsonContainerAttribute : Attribute
	{
		internal bool? _isReference;

		internal bool? _itemIsReference;

		internal ReferenceLoopHandling? _itemReferenceLoopHandling;

		internal TypeNameHandling? _itemTypeNameHandling;

		private Type _namingStrategyType;

		private object[] _namingStrategyParameters;

		public Type ItemConverterType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public object[] ItemConverterParameters
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Type NamingStrategyType => null;

		public object[] NamingStrategyParameters => null;

		internal NamingStrategy NamingStrategyInstance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
