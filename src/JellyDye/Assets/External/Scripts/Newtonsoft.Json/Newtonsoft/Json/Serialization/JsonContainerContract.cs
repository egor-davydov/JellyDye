using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	public class JsonContainerContract : JsonContract
	{
		private JsonContract _itemContract;

		private JsonContract _finalItemContract;

		internal JsonContract ItemContract
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal JsonContract FinalItemContract => null;

		public JsonConverter ItemConverter
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

		public bool? ItemIsReference
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

		public ReferenceLoopHandling? ItemReferenceLoopHandling
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

		public TypeNameHandling? ItemTypeNameHandling
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

		internal JsonContainerContract(Type underlyingType)
			: base(null)
		{
		}
	}
}
