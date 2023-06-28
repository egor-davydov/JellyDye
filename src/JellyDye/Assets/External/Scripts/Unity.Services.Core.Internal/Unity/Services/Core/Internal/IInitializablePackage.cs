using System.Threading.Tasks;

namespace Unity.Services.Core.Internal
{
	public interface IInitializablePackage
	{
		Task Initialize(CoreRegistry registry);
	}
}
