using System.Runtime.InteropServices;

namespace Cysharp.Threading.Tasks
{
	[StructLayout(0, Size = 1)]
	public readonly struct UniTaskVoid
	{
		public void Forget()
		{
		}
	}
}
