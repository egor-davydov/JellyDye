public class MaxTargetingData
{
	public enum AdContentRating
	{
		None = 0,
		AllAudiences = 1,
		EveryoneOverTwelve = 2,
		MatureAudiences = 3
	}

	public enum UserGender
	{
		Unknown = 0,
		Female = 1,
		Male = 2,
		Other = 3
	}

	public int YearOfBirth
	{
		set
		{
		}
	}

	public UserGender Gender
	{
		set
		{
		}
	}

	public AdContentRating MaximumAdContentRating
	{
		set
		{
		}
	}

	public string Email
	{
		set
		{
		}
	}

	public string PhoneNumber
	{
		set
		{
		}
	}

	public string[] Keywords
	{
		set
		{
		}
	}

	public string[] Interests
	{
		set
		{
		}
	}

	public void ClearAll()
	{
	}
}
