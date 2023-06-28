using System.Collections.Generic;

namespace Unity.Services.Analytics
{
	internal class TransactionCurrencyConverter
	{
		private Dictionary<string, int> m_CurrencyCodeToMinorUnits;

		public long Convert(string currencyCode, double value)
		{
			return 0L;
		}

		public void LoadCurrencyCodeDictionary()
		{
		}
	}
}
