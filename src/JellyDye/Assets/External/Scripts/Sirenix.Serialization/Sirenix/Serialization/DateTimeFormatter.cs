using System;

namespace Sirenix.Serialization
{
	public sealed class DateTimeFormatter : MinimalBaseFormatter<DateTime>
	{
		protected override void Read(ref DateTime value, IDataReader reader)
		{
		}

		protected override void Write(ref DateTime value, IDataWriter writer)
		{
		}

		public DateTimeFormatter()
		{
			((MinimalBaseFormatter<>)(object)this)._002Ector();
		}
	}
}
