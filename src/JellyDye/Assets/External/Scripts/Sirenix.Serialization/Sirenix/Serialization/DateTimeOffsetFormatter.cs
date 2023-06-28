using System;

namespace Sirenix.Serialization
{
	public sealed class DateTimeOffsetFormatter : MinimalBaseFormatter<DateTimeOffset>
	{
		protected override void Read(ref DateTimeOffset value, IDataReader reader)
		{
		}

		protected override void Write(ref DateTimeOffset value, IDataWriter writer)
		{
		}

		public DateTimeOffsetFormatter()
		{
			((MinimalBaseFormatter<>)(object)this)._002Ector();
		}
	}
}
