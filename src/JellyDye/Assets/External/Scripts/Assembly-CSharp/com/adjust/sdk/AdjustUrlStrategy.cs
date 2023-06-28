using System;

namespace com.adjust.sdk
{
	[Serializable]
	public enum AdjustUrlStrategy
	{
		Default = 0,
		DataResidencyEU = 1,
		DataResidencyTK = 2,
		DataResidencyUS = 3,
		India = 4,
		China = 5
	}
}
