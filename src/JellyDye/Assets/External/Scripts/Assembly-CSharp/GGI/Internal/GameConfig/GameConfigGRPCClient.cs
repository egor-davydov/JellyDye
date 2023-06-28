using System;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Gjg.Io.GameConfig.Proto.Config.V6.Resources;
using Gjg.Io.GameConfig.Proto.Config.V6.Services;
using Gjg.Io.GameConfig.Proto.Country.V1.Services;
using Gjg.Io.GameConfig.Proto.CrossPromo.V1.Services;
using Gjg.Io.GameConfig.Proto.Exchange.V1.Services;
using Gjg.Io.GameConfig.Proto.GDPR.V1.Services;
using Gjg.Io.GameConfig.Proto.PostInit.V2.Services;
using Grpc.Core;

namespace GGI.Internal.GameConfig
{
	public class GameConfigGRPCClient
	{
		private Grpc.Core.Channel _connection;

		private ConfigService.ConfigServiceClient _client;

		private CrossPromoService.CrossPromoServiceClient _crossClient;

		private ExchangeService.ExchangeServiceClient _exchangeClient;

		private CountryService.CountryServiceClient _countryClient;

		private PostInitService.PostInitServiceClient _postInitClient;

		private GDPRService.GDPRServiceClient _gdprClient;

		private ChannelCredentials _credentials;

		public void Init()
		{
		}

		public Task Quit()
		{
			return null;
		}

		public UniTaskVoid RequestGameConfigAsync(GetConfigRequest config, Action<Config> onResponse, Action onError)
		{
			return default(UniTaskVoid);
		}

		public Task PostInit(PostInitRequest config, Metadata headers, DateTime? deadline)
		{
			return null;
		}

		public UniTask<ConversionValue> GetConversionValue(GetConversionValueRequest request)
		{
			return default(UniTask<ConversionValue>);
		}

		public UniTask<ConvertResponse> ConvertCurrency(ConvertRequest request)
		{
			return default(UniTask<ConvertResponse>);
		}

		public UniTask<FindMeResponse> FindMe()
		{
			return default(UniTask<FindMeResponse>);
		}

		public UniTaskVoid GiveConsent(GiveConsentRequest request)
		{
			return default(UniTaskVoid);
		}
	}
}
