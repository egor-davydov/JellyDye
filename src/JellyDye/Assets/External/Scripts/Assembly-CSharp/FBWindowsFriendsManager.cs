using Facebook.Unity;
using UnityEngine;

public class FBWindowsFriendsManager : MonoBehaviour
{
	public FBWindowsLogsManager Logger;

	public Transform ReceivedInvitationsPanelTransform;

	public GameObject ShowReceivedInvitation;

	public void Button_OpenReceivedInvitations()
	{
	}

	private void OpenFriendsDialogCallBack(IGamingServicesFriendFinderResult result)
	{
	}

	public void Button_GetFriendFinderInvitations()
	{
	}

	private void GetFriendFinderInvitationsCallback(IFriendFinderInvitationResult receivedInvitations)
	{
	}

	private void DeleteFriendFinderInvitationCallback(IFriendFinderInvitationResult receivedInvitations)
	{
	}
}
