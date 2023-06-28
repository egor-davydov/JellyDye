using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Unity.Services.Analytics.Data;
using Unity.Services.Analytics.Internal;
using Unity.Services.Analytics.Platform;
using Unity.Services.Authentication.Internal;
using Unity.Services.Core.Device.Internal;

namespace Unity.Services.Analytics
{
	internal class AnalyticsServiceInstance : IAnalyticsService
	{
		internal IConsentTracker ConsentTracker;

		internal IAnalyticsForgetter analyticsForgetter;

		internal IBuffer dataBuffer;

		internal IDataGenerator dataGenerator;

		private string m_CollectURL;

		private readonly string m_SessionID;

		private readonly StdCommonParams m_CommonParams;

		private readonly string m_StartUpCallingId;

		internal IIDeviceIdentifiersInternal deviceIdentifiersInternal;

		private readonly TransactionCurrencyConverter converter;

		internal IPlayerId PlayerId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal IInstallationId InstallId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal string CustomAnalyticsId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal IDispatcher dataDispatcher
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal bool ServiceEnabled
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public void OptOut()
		{
		}

		private void Revoke()
		{
		}

		internal void RevokeWithForgetEvent()
		{
		}

		internal void ForgetMeEventUploaded()
		{
		}

		internal AnalyticsServiceInstance()
		{
		}

		public void Flush()
		{
		}

		internal void SetDependencies(IInstallationId installId, IPlayerId playerId, string environment, string customAnalyticsId)
		{
		}

		internal Task Initialize(IInstallationId installId, IPlayerId playerId, string environment, string customAnalyticsId)
		{
			return null;
		}

		private Task InitializeUser()
		{
			return null;
		}

		internal void Startup()
		{
		}

		internal void NewPlayerEvent()
		{
		}

		internal void GameEnded()
		{
		}

		internal void InternalTick()
		{
		}

		private void SetVariableCommonParams()
		{
		}

		public void Transaction(TransactionParameters transactionParameters)
		{
		}

		public long ConvertCurrencyToMinorUnits(string currencyCode, double value)
		{
			return 0L;
		}

		public void TransactionFailed(TransactionFailedParameters parameters)
		{
		}
	}
}
