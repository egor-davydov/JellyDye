using System;

namespace Sirenix.Serialization
{
	public sealed class TypeFormatter : MinimalBaseFormatter<Type>
	{
		protected override void Read(ref Type value, IDataReader reader)
		{
		}

		protected override void Write(ref Type value, IDataWriter writer)
		{
		}

		protected override Type GetUninitializedObject()
		{
			return null;
		}

		public TypeFormatter()
		{
			((MinimalBaseFormatter<>)(object)this)._002Ector();
		}
	}
}
