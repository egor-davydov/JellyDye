using System;

namespace Sirenix.Serialization
{
	public sealed class TimeSpanFormatter : MinimalBaseFormatter<TimeSpan>
	{
		protected override void Read(ref TimeSpan value, IDataReader reader)
		{
		}

		protected override void Write(ref TimeSpan value, IDataWriter writer)
		{
		}

		public TimeSpanFormatter()
		{
			((MinimalBaseFormatter<>)(object)this)._002Ector();
		}
	}
}
