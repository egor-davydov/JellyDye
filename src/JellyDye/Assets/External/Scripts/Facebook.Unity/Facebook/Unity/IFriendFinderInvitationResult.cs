using System.Collections.Generic;

namespace Facebook.Unity
{
	public interface IFriendFinderInvitationResult : IResult
	{
		IList<FriendFinderInviation> Invitations { get; }
	}
}
