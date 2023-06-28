namespace GGI.Components
{
	public class FacebookInitializer : AutoSingletonMono<FacebookInitializer>
	{
		private bool _didInit;

		protected override void Awake()
		{
		}

		public void Init()
		{
		}

		private void OnApplicationPause(bool pauseState)
		{
		}

		private void InitCallback()
		{
		}

		public FacebookInitializer()
		{
			((AutoSingletonMono<>)(object)this)._002Ector();
		}
	}
}
