namespace Unity.Services.Analytics
{
	public interface IAnalyticsService
	{
		void Transaction(TransactionParameters transactionParameters);

		void TransactionFailed(TransactionFailedParameters parameters);

		long ConvertCurrencyToMinorUnits(string currencyCode, double value);
	}
}
