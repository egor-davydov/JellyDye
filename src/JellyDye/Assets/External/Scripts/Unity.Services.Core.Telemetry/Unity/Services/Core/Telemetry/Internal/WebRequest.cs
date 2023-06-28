namespace Unity.Services.Core.Telemetry.Internal
{
	internal struct WebRequest
	{
		public WebRequestResult Result;

		public string ErrorMessage;

		public string ErrorBody;

		public long ResponseCode;

		public bool IsSuccess => false;
	}
}
