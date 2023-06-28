using System.ComponentModel;
using System.Runtime.CompilerServices;
using SRDebugger;
using UnityEngine;

public class SROptions : INotifyPropertyChanged
{
	public sealed class DisplayNameAttribute : System.ComponentModel.DisplayNameAttribute
	{
		public DisplayNameAttribute(string displayName)
		{
		}
	}

	public sealed class IncrementAttribute : SRDebugger.IncrementAttribute
	{
		public IncrementAttribute(double increment)
			: base(0.0)
		{
		}
	}

	public sealed class NumberRangeAttribute : SRDebugger.NumberRangeAttribute
	{
		public NumberRangeAttribute(double min, double max)
			: base(0.0, 0.0)
		{
		}
	}

	public sealed class SortAttribute : SRDebugger.SortAttribute
	{
		public SortAttribute(int priority)
			: base(0)
		{
		}
	}

	private static readonly SROptions _current;

	public static SROptions Current => null;

	[Category]
	public bool LoadCustomMiniGame
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[Category]
	public int CustomMiniGameIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[Category]
	public int LOADLEVELID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[Category]
	public int FillMode
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[Category]
	public int RefMode
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[Category]
	public int PlayMode
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[Category]
	public int NoBorderMode
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[Category]
	public int CurrentLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[Category]
	public int PerformanceMode
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[Category]
	public float MoveSpeed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Category]
	public float DyeForceStart
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Category]
	public float DyeForceEnd
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Category]
	public float DyeRotateSpeed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Category]
	public float FullDyeTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Category]
	public float SyringeStickMovement
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Category]
	public float AutoFillStartPercent
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Category]
	public float HoldTimerToDye
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Category]
	public float HapticIntensityMax
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Category]
	public float HapticIntensityMin
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Category]
	public float HapticSharpnessMax
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Category]
	public float HapticSharpnessMin
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public event SROptionsPropertyChanged PropertyChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private event PropertyChangedEventHandler InterfacePropertyChangedEventHandler
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private event PropertyChangedEventHandler System_002EComponentModel_002EINotifyPropertyChanged_002EPropertyChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	[Category]
	public void TryShowInter()
	{
	}

	[Category]
	public void TryShowRewarded()
	{
	}

	[Category]
	public void HideBanner()
	{
	}

	[Category]
	public void ShowMediationDebugger()
	{
	}

	[Category]
	public void DestroyBanner()
	{
	}

	[Category]
	public void ShowBanner()
	{
	}

	[Category]
	public void ShowGDPRSettings()
	{
	}

	[Category]
	public void ToggleAppOpenLoadingScreen()
	{
	}

	[Category]
	public void Clear()
	{
	}

	[RuntimeInitializeOnLoadMethod]
	public static void OnStartup()
	{
	}

	public void OnPropertyChanged(string propertyName)
	{
	}

	[Category]
	public void NextLevel()
	{
	}

	[Category]
	public void DeleteAll()
	{
	}

	[Category]
	public void Restart()
	{
	}

	[Category]
	public void LOADLEVEL()
	{
	}
}
