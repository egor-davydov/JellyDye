using System.Collections;
using Facebook.Unity;
using UnityEngine;
using UnityEngine.UI;

public class FBWindowsLoginManager : MonoBehaviour
{
	public FBWindowsLogsManager Logger;

	public InputField Permissions;

	public RawImage UserImage;

	public Text UserName;

	public void LogInReadButton()
	{
	}

	public void LogInPublishButton()
	{
	}

	public void LogOutButton()
	{
	}

	private void AuthCallback(ILoginResult result)
	{
	}

	public void GetCurrentProfile()
	{
	}

	public void GetUserLocale()
	{
	}

	private IEnumerator LoadPictureFromUrl(string url, RawImage itemImage)
	{
		return null;
	}
}
