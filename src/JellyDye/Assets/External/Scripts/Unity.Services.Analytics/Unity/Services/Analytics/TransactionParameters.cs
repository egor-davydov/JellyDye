namespace Unity.Services.Analytics
{
	public struct TransactionParameters
	{
		public string PaymentCountry;

		public string ProductID;

		public long? RevenueValidated;

		public string TransactionID;

		public string TransactionReceipt;

		public string TransactionReceiptSignature;

		public TransactionServer? TransactionServer;

		public string TransactorID;

		public string StoreItemSkuID;

		public string StoreItemID;

		public string StoreID;

		public string StoreSourceID;

		public string TransactionName;

		public TransactionType TransactionType;

		public Product ProductsReceived;

		public Product ProductsSpent;
	}
}
