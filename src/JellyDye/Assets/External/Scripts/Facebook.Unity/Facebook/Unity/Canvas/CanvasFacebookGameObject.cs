namespace Facebook.Unity.Canvas
{
	internal class CanvasFacebookGameObject : FacebookGameObject, ICanvasFacebookCallbackHandler, IFacebookCallbackHandler
	{
		protected ICanvasFacebookImplementation CanvasFacebookImpl => null;

		public void OnPayComplete(string result)
		{
		}

		public void OnFacebookAuthResponseChange(string message)
		{
		}

		public void OnUrlResponse(string message)
		{
		}

		public void OnHideUnity(bool hide)
		{
		}

		protected override void OnAwake()
		{
		}
	}
}
