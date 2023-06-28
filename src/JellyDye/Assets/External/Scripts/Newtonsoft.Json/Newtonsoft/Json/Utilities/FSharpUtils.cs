using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	internal class FSharpUtils
	{
		private static readonly object Lock;

		private static FSharpUtils _instance;

		private MethodInfo _ofSeq;

		private Type _mapType;

		public static FSharpUtils Instance => null;

		private Assembly FSharpCoreAssembly
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public MethodCall<object, object> IsUnion
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

		public MethodCall<object, object> GetUnionCases
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

		public MethodCall<object, object> PreComputeUnionTagReader
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

		public MethodCall<object, object> PreComputeUnionReader
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

		public MethodCall<object, object> PreComputeUnionConstructor
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

		public Func<object, object> GetUnionCaseInfoDeclaringType
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

		public Func<object, object> GetUnionCaseInfoName
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

		public Func<object, object> GetUnionCaseInfoTag
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

		public MethodCall<object, object> GetUnionCaseInfoFields
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

		private FSharpUtils(Assembly fsharpCoreAssembly)
		{
		}

		public static void EnsureInitialized(Assembly fsharpCoreAssembly)
		{
		}

		private static MethodInfo GetMethodWithNonPublicFallback(Type type, string methodName, BindingFlags bindingFlags)
		{
			return null;
		}

		private static MethodCall<object, object> CreateFSharpFuncCall(Type type, string methodName)
		{
			return null;
		}

		public ObjectConstructor<object> CreateSeq(Type t)
		{
			return null;
		}

		public ObjectConstructor<object> CreateMap(Type keyType, Type valueType)
		{
			return null;
		}

		public ObjectConstructor<object> BuildMapCreator<TKey, TValue>()
		{
			return null;
		}
	}
}
