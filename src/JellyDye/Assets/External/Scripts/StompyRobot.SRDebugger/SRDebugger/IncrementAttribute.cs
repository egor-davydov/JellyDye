using System;

namespace SRDebugger
{
	public class IncrementAttribute : Attribute
	{
		public readonly double Increment;

		public IncrementAttribute(double increment)
		{
		}
	}
}
