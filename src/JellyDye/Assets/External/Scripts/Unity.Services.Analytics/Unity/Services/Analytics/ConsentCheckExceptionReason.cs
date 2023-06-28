using UnityEngine.Scripting;

namespace Unity.Services.Analytics
{
	[Preserve]
	public enum ConsentCheckExceptionReason
	{
		Unknown = 0,
		DeserializationIssue = 1,
		NoInternetConnection = 2,
		InvalidConsentFlow = 3,
		ConsentFlowNotKnown = 4
	}
}
