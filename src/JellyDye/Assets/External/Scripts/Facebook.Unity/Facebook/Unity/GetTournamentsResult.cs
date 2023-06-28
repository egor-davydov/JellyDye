using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal class GetTournamentsResult : ResultBase, IGetTournamentsResult, IResult
	{
		private TournamentResult[] Tournaments
		{
			[CompilerGenerated]
			set
			{
			}
		}

		internal GetTournamentsResult(ResultContainer resultContainer)
			: base(null)
		{
		}
	}
}
