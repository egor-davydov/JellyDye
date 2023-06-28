namespace Sirenix.Serialization
{
	public abstract class EasyBaseFormatter<T> : BaseFormatter<T>
	{
		protected sealed override void DeserializeImplementation(ref T value, IDataReader reader)
		{
		}

		protected sealed override void SerializeImplementation(ref T value, IDataWriter writer)
		{
		}

		protected abstract void ReadDataEntry(ref T value, string entryName, EntryType entryType, IDataReader reader);

		protected abstract void WriteDataEntries(ref T value, IDataWriter writer);

		protected EasyBaseFormatter()
		{
			((BaseFormatter<>)(object)this)._002Ector();
		}
	}
}
