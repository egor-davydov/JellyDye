using System.Threading.Tasks;

namespace Grpc.Core
{
	public delegate Task<TResponse> UnaryServerMethod<TRequest, TResponse>(TRequest request, ServerCallContext context) where TRequest : class where TResponse : class;
}
