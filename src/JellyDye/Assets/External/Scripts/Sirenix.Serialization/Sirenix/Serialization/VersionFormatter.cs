using System;

namespace Sirenix.Serialization
{
	public sealed class VersionFormatter : MinimalBaseFormatter<Version>
	{
		protected override Version GetUninitializedObject()
		{
			return null;
		}

		protected override void Read(ref Version value, IDataReader reader)
		{
		}

		protected override void Write(ref Version value, IDataWriter writer)
		{
		}

		public VersionFormatter()
		{
			((MinimalBaseFormatter<>)(object)this)._002Ector();
		}
	}
}
