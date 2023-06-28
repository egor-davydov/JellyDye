using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncJointBreak2DTrigger : AsyncTriggerBase<Joint2D>
	{
		private void OnJointBreak2D(Joint2D brokenJoint)
		{
		}

		public IAsyncOnJointBreak2DHandler GetOnJointBreak2DAsyncHandler()
		{
			return null;
		}

		public IAsyncOnJointBreak2DHandler GetOnJointBreak2DAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<Joint2D> OnJointBreak2DAsync()
		{
			return default(UniTask<Joint2D>);
		}

		public UniTask<Joint2D> OnJointBreak2DAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<Joint2D>);
		}

		public AsyncJointBreak2DTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}
