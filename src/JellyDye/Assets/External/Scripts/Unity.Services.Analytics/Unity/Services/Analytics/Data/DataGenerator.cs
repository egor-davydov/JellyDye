using System;
using Unity.Services.Analytics.Internal;

namespace Unity.Services.Analytics.Data
{
	internal class DataGenerator : IDataGenerator
	{
		internal enum SessionEndState
		{
			PAUSED = 0,
			KILLEDINBACKGROUND = 1,
			KILLEDINFOREGROUND = 2,
			QUIT = 3
		}

		public void SdkStartup(ref IBuffer buf, DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier)
		{
		}

		public void GameRunning(ref IBuffer buf, DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier)
		{
		}

		public void NewPlayer(ref IBuffer buf, DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier, string deviceModel)
		{
		}

		public void GameStarted(ref IBuffer buf, DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier, string idLocalProject, string osVersion, bool isTiny, bool debugDevice, string userLocale)
		{
		}

		public void GameEnded(ref IBuffer buf, DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier, SessionEndState quitState)
		{
		}

		public void Transaction(ref IBuffer buf, DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier, TransactionParameters transactionParameters)
		{
		}

		public void TransactionFailed(ref IBuffer buf, DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier, TransactionFailedParameters parameters)
		{
		}

		public void ClientDevice(ref IBuffer buf, DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier, string cpuType, string gpuType, long cpuCores, long ramTotal, long screenWidth, long screenHeight, long screenDPI)
		{
		}

		private void SetProduct(ref IBuffer buf, string productName, Product product)
		{
		}
	}
}
