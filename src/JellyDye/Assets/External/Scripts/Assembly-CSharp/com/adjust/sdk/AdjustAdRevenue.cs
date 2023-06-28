using System.Collections.Generic;

namespace com.adjust.sdk
{
	public class AdjustAdRevenue
	{
		internal string source;

		internal double? revenue;

		internal string currency;

		internal int? adImpressionsCount;

		internal string adRevenueNetwork;

		internal string adRevenueUnit;

		internal string adRevenuePlacement;

		internal List<string> partnerList;

		internal List<string> callbackList;

		public AdjustAdRevenue(string source)
		{
		}

		public void setRevenue(double amount, string currency)
		{
		}

		public void setAdImpressionsCount(int adImpressionsCount)
		{
		}

		public void setAdRevenueNetwork(string adRevenueNetwork)
		{
		}

		public void setAdRevenueUnit(string adRevenueUnit)
		{
		}

		public void setAdRevenuePlacement(string adRevenuePlacement)
		{
		}

		public void addCallbackParameter(string key, string value)
		{
		}

		public void addPartnerParameter(string key, string value)
		{
		}
	}
}
