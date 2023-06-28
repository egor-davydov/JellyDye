using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal abstract class MethodCall<T> where T : IResult
	{
		public string MethodName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public FacebookDelegate<T> Callback
		{
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected FacebookBase FacebookImpl
		{
			[CompilerGenerated]
			set
			{
			}
		}

		protected MethodArguments Parameters
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public MethodCall(FacebookBase facebookImpl, string methodName)
		{
		}

		public abstract void Call(MethodArguments args = null);
	}
}
