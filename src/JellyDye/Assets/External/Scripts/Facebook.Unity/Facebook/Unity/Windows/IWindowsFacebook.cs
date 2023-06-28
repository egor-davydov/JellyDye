namespace Facebook.Unity.Windows
{
	internal interface IWindowsFacebook : IPayFacebook, IFacebook, IFacebookWindows
	{
		void SetVirtualGamepadLayout(string layout, FacebookDelegate<IVirtualGamepadLayoutResult> callback);

		void SetSoftKeyboardOpen(bool open, FacebookDelegate<ISoftKeyboardOpenResult> callback);
	}
}
