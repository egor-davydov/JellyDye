using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Unity.Services.Analytics.Internal
{
	internal class ConsentTracker : IConsentTracker
	{
		private readonly IGeoAPI m_GeoAPI;

		internal GeoIPResponse response;

		internal ConsentStatus optInPiplConsentStatus
		{
			[CompilerGenerated]
			get
			{
				return default(ConsentStatus);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal ConsentStatus optOutConsentStatus
		{
			[CompilerGenerated]
			get
			{
				return default(ConsentStatus);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private Dictionary<string, string> piplHeaders => null;

		public Dictionary<string, string> requiredHeaders => null;

		public Task<GeoIPResponse> CheckGeoIP()
		{
			return null;
		}

		public bool IsGeoIpChecked()
		{
			return false;
		}

		public bool IsConsentGiven()
		{
			return false;
		}

		public bool IsConsentGiven(string identifier)
		{
			return false;
		}

		public bool IsConsentDenied()
		{
			return false;
		}

		public bool IsOptingOutInProgress()
		{
			return false;
		}

		public void BeginOptOutProcess()
		{
		}

		public void FinishOptOutProcess()
		{
		}

		public void SetDenyConsentToAll()
		{
		}

		internal void ReadOptInPiplConsentStatus()
		{
		}

		internal void ReadOptOutConsentStatus()
		{
		}

		internal Task<GeoIPResponse> GetGeoIPResponse()
		{
			return null;
		}

		private void ValidateConsentWasChecked()
		{
		}
	}
}
