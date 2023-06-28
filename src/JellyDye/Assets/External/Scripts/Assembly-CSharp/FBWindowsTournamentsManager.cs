using System.Collections.Generic;
using Facebook.Unity;
using UnityEngine;
using UnityEngine.UI;

public class FBWindowsTournamentsManager : MonoBehaviour
{
	public FBWindowsLogsManager Logger;

	public InputField Title;

	public InputField Image;

	public Dropdown SortOrder;

	public Dropdown ScoreFormat;

	public InputField Data;

	public InputField InitialScore;

	public InputField Score;

	public InputField ShareData;

	private Dictionary<string, string> ConvertDataToDict(string UTF8String)
	{
		return null;
	}

	public void Button_CreateTournament()
	{
	}

	private void CallbackCreateTournament(ITournamentResult result)
	{
	}

	public void Button_PostSessionScore()
	{
	}

	private void CallbackPostSessionScore(ISessionScoreResult result)
	{
	}

	public void Button_PostTournamentScore()
	{
	}

	private void CallbackPostTournamentScore(ITournamentScoreResult result)
	{
	}

	public void Button_ShareTournament()
	{
	}

	private void CallbackShareTournament(ITournamentScoreResult result)
	{
	}

	public void Button_GetTournament()
	{
	}

	private void CallbackGetTournament(ITournamentResult result)
	{
	}
}
