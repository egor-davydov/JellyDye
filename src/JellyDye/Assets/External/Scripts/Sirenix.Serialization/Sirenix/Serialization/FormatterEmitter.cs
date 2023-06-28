using System;

namespace Sirenix.Serialization
{
	public static class FormatterEmitter
	{
		[EmittedFormatter]
		public abstract class AOTEmittedFormatter<T> : EasyBaseFormatter<T>
		{
			protected AOTEmittedFormatter()
			{
				((EasyBaseFormatter<>)(object)this)._002Ector();
			}
		}

		public abstract class EmptyAOTEmittedFormatter<T> : AOTEmittedFormatter<T>
		{
			protected override void ReadDataEntry(ref T value, string entryName, EntryType entryType, IDataReader reader)
			{
			}

			protected override void WriteDataEntries(ref T value, IDataWriter writer)
			{
			}

			protected EmptyAOTEmittedFormatter()
			{
				((AOTEmittedFormatter<>)(object)this)._002Ector();
			}
		}

		public const string PRE_EMITTED_ASSEMBLY_NAME = "Sirenix.Serialization.AOTGenerated";

		public const string RUNTIME_EMITTED_ASSEMBLY_NAME = "Sirenix.Serialization.RuntimeEmitted";

		public static IFormatter GetEmittedFormatter(Type type, ISerializationPolicy policy)
		{
			return null;
		}
	}
}
