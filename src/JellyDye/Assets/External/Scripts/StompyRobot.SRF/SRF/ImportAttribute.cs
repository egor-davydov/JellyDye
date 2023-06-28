using System;

namespace SRF
{
	public class ImportAttribute : Attribute
	{
		public readonly Type Service;

		public ImportAttribute()
		{
		}

		public ImportAttribute(Type serviceType)
		{
		}
	}
}
