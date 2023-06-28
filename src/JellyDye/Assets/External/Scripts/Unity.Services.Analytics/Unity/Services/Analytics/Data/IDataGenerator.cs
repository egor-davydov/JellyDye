using System;
using Unity.Services.Analytics.Internal;

namespace Unity.Services.Analytics.Data
{
	internal interface IDataGenerator
	{
		void GameRunning(ref IBuffer buf, DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier);

		void SdkStartup(ref IBuffer buf, DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier);

		void NewPlayer(ref IBuffer buf, DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier, string deviceModel);

		void GameStarted(ref IBuffer buf, DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier, string idLocalProject, string osVersion, bool isTiny, bool debugDevice, string userLocale);

		void GameEnded(ref IBuffer buf, DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier, DataGenerator.SessionEndState quitState);

		void Transaction(ref IBuffer buf, DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier, TransactionParameters transactionParameters);

		void TransactionFailed(ref IBuffer buf, DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier, TransactionFailedParameters transactionParameters);

		void ClientDevice(ref IBuffer buf, DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier, string cpuType, string gpuType, long cpuCores, long ramTotal, long screenWidth, long screenHeight, long screenDPI);
	}
}
