using System.Threading.Tasks;

namespace Grpc.Core
{
	public abstract class ChannelBase
	{
		private readonly string target;

		protected ChannelBase(string target)
		{
		}

		public abstract CallInvoker CreateCallInvoker();

		public Task ShutdownAsync()
		{
			return null;
		}

		protected virtual Task ShutdownAsyncCore()
		{
			return null;
		}
	}
}
