using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GGI.Scripts.Internal.iOS;
using Gjg.Io.GameConfig.Proto.Config.V3.Resources;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GGI.UI.IDFAOptin
{
	public class IDFAOptinUI : MonoBehaviour
	{
		public enum Extras
		{
			FullSubliminalColors = 0,
			FullSubliminalColorsNoTransparency = 1,
			SubliminalBackground = 2,
			SubliminalBackgroundFull = 3,
			ArrowsLeftRight = 4,
			EmojiButtons = 5,
			ButtonWideSubliminalColors = 6,
			HighlightedYes = 7,
			XButton = 8,
			MoreInfoTransition = 9,
			Stylized = 10,
			Hand = 11,
			DisabledNo = 12,
			PlayIconNextToYes = 13,
			Multiple = 14,
			MultipleQuestion = 15,
			MultipleQuestionSingleChoice = 16,
			ConfettiParticle = 17,
			HappyFaceParticle = 18,
			SadFaceParticle = 19,
			HappyThumbsUp = 20,
			ReversedButtons = 21,
			AggressiveOptin = 22,
			DiamondIcon = 23,
			ProgressAmount = 24,
			KillProgress = 25,
			YoutubeIcon = 26,
			TapCount = 27,
			MultipleEndless = 28,
			MultipleSwitch = 29,
			WarningIcon = 30,
			GamesIcon = 31,
			VerticalNativeButtons = 32
		}

		public enum Occurence
		{
			EveryTime = 0,
			Once = 1,
			EveryLevel5 = 2,
			EveryLevel3 = 3,
			EvenNo = 4
		}

		public enum OptinPlace
		{
			Off = 0,
			SessionStart = 1,
			Level1 = 2,
			Level2 = 3,
			FirstWin = 4,
			DebugPanel = 5,
			SRDebugger = 6,
			Banner = 7,
			Custom = 8,
			SecondLevelInSession = 9
		}

		public enum ClickType
		{
			No = 0,
			Yes = 1,
			XButton = 2,
			MoreInfo = 3,
			BackButton = 4
		}

		public Dictionary<Extras, string> ExtrasMap;

		public Dictionary<string, Occurence> OccurenceMap;

		public IDFAOptinPopupType1 Type1;

		public IDFAOptinPopupType2 Type2;

		public IDFAOptinPopupType4 Type4;

		public IDFAOptinPopupType5 Type5;

		public IDFAOptinPopupType6 Type6;

		public IDFAOptinPopupType7 Type7;

		public IDFAOptinPopupType8 Type8;

		public IDFAOptinPopupType9 Type9;

		public IDFAOptinPopupType10 Type10;

		public IDFAOptinPopupType11 Type11;

		public IDFAOptinPopupType12 Type12;

		public IDFAOptinPopupType13 Type13;

		public IDFAOptinPopupType14 Type14;

		public IDFAOptinPopupType17 Type17;

		public IDFAOptinBanner Banner;

		private float _warmupImpressionStartSeconds;

		private float _optinImpressionStartSeconds;

		public static Vector2 ReferenceResolution;

		public AnimationCurve Type3AnimCurve;

		public string CurrentTestIdentifier;

		public bool BannerMode;

		private bool _isShowing;

		private int _warmupChoice;

		private bool _delayedPopupClose;

		public static IDFAOptinUI Instance;

		public bool DarkMode
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Color DarkModePopupBackgroundColor
		{
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Color DarkModeTextColor
		{
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Color LightModePopupBackgroundColor
		{
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Color LightModeTextColor
		{
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Color LightModeSeperatorColor
		{
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Color DarkModeSeperatorColor
		{
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public OptinPlace CurrentTestPlace => default(OptinPlace);

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SceneManagerOnsceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		private void Start()
		{
		}

		public void ShowBanner()
		{
		}

		public void ShowFakeOptinNativePopup(int warmupChoice, string title = "$GAME_NAME would like permission to track you across apps and websites owned by other companies.", string desc = "Your data may be used by Good Job Games and its partners for personalized advertising and analytics purposes.", string yesButtonText = "Allow Tracking", string noButtonText = "Ask App Not To Track")
		{
		}

		public void OnClickedYes(bool isDelayedClose = false)
		{
		}

		public void OnClickedNo()
		{
		}

		public void OnChoiceToAtt(TrackingAuthorizationStatus status)
		{
		}

		private void OnExitingOptin()
		{
		}

		private void ShowAtt(int warmupChoice)
		{
		}

		public bool OnCustomChoiceToRealPopup(bool choice)
		{
			return false;
		}

		public void OnClickedYesToRealPopup()
		{
		}

		public void OnClickedNoToRealPopup()
		{
		}

		public void OnClickedX()
		{
		}

		public void OnClickedMoreInfo()
		{
		}

		public void OnClickedMoreInfoBack()
		{
		}

		public static bool OnLevelWin(int progress)
		{
			return false;
		}

		public static void OnLevelLose(int progress)
		{
		}

		public static bool OnCustomPlace()
		{
			return false;
		}

		public static void EnablePopupStatic(string testId, OptinPlace where)
		{
		}

		public void EnablePopup(string testId, OptinPlace where)
		{
		}

		private void CloseCurrentPopup()
		{
		}

		public void SetColorMode(bool isDarkMode)
		{
		}

		private void RefreshViews()
		{
		}

		public void DisableAll()
		{
		}

		private void AnimateAndOpen(GameObject obj, CanvasGroup canvas)
		{
		}

		private void SlideOpen(GameObject obj, RectTransform transform)
		{
		}

		public string TranslateText(string text)
		{
			return null;
		}

		public bool IsShowing()
		{
			return false;
		}

		public OptinConfig GetConfig()
		{
			return null;
		}

		public OptinText GetText(long id)
		{
			return null;
		}

		public bool HasExtra(Extras extra)
		{
			return false;
		}

		public Occurence GetOccurence()
		{
			return default(Occurence);
		}

		public OptinPlace GetPlace()
		{
			return default(OptinPlace);
		}

		public static string GetCurrentTestIdentifier()
		{
			return null;
		}

		private int GetShownAmount()
		{
			return 0;
		}

		private bool IsShownBefore()
		{
			return false;
		}

		public void SetShownAmount(int shown)
		{
		}

		public void SetShown()
		{
		}

		public void SetOptinShowed()
		{
		}

		public bool IsOptinShowed()
		{
			return false;
		}

		public void SetOptinResponse(bool allow)
		{
		}

		public bool HasOptinResponse()
		{
			return false;
		}

		public DataExtra GetExtraData(Extras extra)
		{
			return null;
		}

		public List<Extras> GetExtras()
		{
			return null;
		}

		public Vector2 GetPopupSize()
		{
			return default(Vector2);
		}
	}
}
