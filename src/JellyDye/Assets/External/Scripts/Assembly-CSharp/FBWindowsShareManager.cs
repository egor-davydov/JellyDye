using Facebook.Unity;
using UnityEngine;
using UnityEngine.UI;

public class FBWindowsShareManager : MonoBehaviour
{
	public FBWindowsLogsManager Logger;

	public InputField Caption;

	public InputField ImageFile;

	public InputField VideoFile;

	public InputField TravelID;

	public Toggle ShouldShowDialog;

	public Button ImageUploadButton;

	public Button VideoUploadButton;

	public void Button_UploadImage()
	{
	}

	public void Button_UploadVideo()
	{
	}

	private void CallbackUploadImage(IMediaUploadResult result)
	{
	}

	private void CallbackUploadVideo(IMediaUploadResult result)
	{
	}
}
