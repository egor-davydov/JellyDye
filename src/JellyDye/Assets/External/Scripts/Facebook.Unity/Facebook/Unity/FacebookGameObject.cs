using System.Runtime.CompilerServices;
using UnityEngine;

namespace Facebook.Unity
{
	internal abstract class FacebookGameObject : MonoBehaviour, IFacebookCallbackHandler
	{
		public IFacebookImplementation Facebook
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Awake()
		{
		}

		public void OnInitComplete(string message)
		{
		}

		public void OnLoginComplete(string message)
		{
		}

		public void OnLogoutComplete(string message)
		{
		}

		public void OnGetAppLinkComplete(string message)
		{
		}

		public void OnAppRequestsComplete(string message)
		{
		}

		public void OnShareLinkComplete(string message)
		{
		}

		protected virtual void OnAwake()
		{
		}
	}
}
