namespace Facebook.Unity.Windows
{
	internal interface IWindowsFacebookImplementation : IWindowsFacebook, IPayFacebook, IFacebook, IFacebookWindows, IFacebookResultHandler
	{
		void Tick();

		void Deinit();
	}
}
