namespace Grpc.Core
{
	public class ServiceBinderBase
	{
		public virtual void AddMethod<TRequest, TResponse>(Method<TRequest, TResponse> method, UnaryServerMethod<TRequest, TResponse> handler) where TRequest : class where TResponse : class
		{
		}
	}
}
