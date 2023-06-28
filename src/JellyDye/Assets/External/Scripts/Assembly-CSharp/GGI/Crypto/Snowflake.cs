using GGI.Components;
using IdGen;

namespace GGI.Crypto
{
	public class Snowflake : AutoSingleton<Snowflake>
	{
		private IdGenerator _generator;

		public long Generate()
		{
			return 0L;
		}

		public Snowflake()
		{
			((AutoSingleton<>)(object)this)._002Ector();
		}
	}
}
