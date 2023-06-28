namespace Facebook.Unity.Windows
{
	internal class WindowsFacebookGameObject : FacebookGameObject, IFacebookCallbackHandler
	{
		protected IWindowsFacebookImplementation WindowsFacebookImpl => null;

		protected override void OnAwake()
		{
		}

		public void Update()
		{
		}

		public void OnDestroy()
		{
		}
	}
}
