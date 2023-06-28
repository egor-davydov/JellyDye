using Facebook.Unity;
using UnityEngine;
using UnityEngine.UI;

public class FBWindowsA2UNotificationsManager : MonoBehaviour
{
	public FBWindowsLogsManager Logger;

	public InputField TitleText;

	public InputField BodyText;

	public InputField MediaText;

	public InputField PayloadText;

	public InputField TimeIntervalText;

	public void ScheduleButton()
	{
	}

	private void A2UNotificationCallback(IScheduleAppToUserNotificationResult result)
	{
	}
}
