using System;

namespace Facebook.Unity
{
	internal interface IFacebookWindows
	{
		void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, FacebookDelegate<IMediaUploadResult> callback);

		void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, FacebookDelegate<IMediaUploadResult> callback);
	}
}
