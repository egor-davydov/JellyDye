using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.GameConfig.Proto.Config.V3.Resources
{
	public sealed class Localization : IMessage<Localization>, IMessage, IEquatable<Localization>, IDeepCloneable<Localization>, IBufferMessage
	{
		private static readonly MessageParser<Localization> _parser;

		private UnknownFieldSet _unknownFields;

		public const int IdFieldNumber = 1;

		private string id_;

		public const int AccessModifyDataFieldNumber = 2;

		private string accessModifyData_;

		public const int AmBackBtnFieldNumber = 3;

		private string amBackBtn_;

		public const int AmDescFieldNumber = 4;

		private string amDesc_;

		public const int AmEmailLabelFieldNumber = 5;

		private string amEmailLabel_;

		public const int AmIdfaLabelFieldNumber = 6;

		private string amIdfaLabel_;

		public const int AmMessageLabelFieldNumber = 7;

		private string amMessageLabel_;

		public const int AmNameLabelFieldNumber = 8;

		private string amNameLabel_;

		public const int AmSaveBtnFieldNumber = 9;

		private string amSaveBtn_;

		public const int AmTitleFieldNumber = 10;

		private string amTitle_;

		public const int BannerDescFieldNumber = 11;

		private string bannerDesc_;

		public const int DeleteDescFieldNumber = 12;

		private string deleteDesc_;

		public const int DeleteMyDataFieldNumber = 13;

		private string deleteMyData_;

		public const int DeleteTitleFieldNumber = 14;

		private string deleteTitle_;

		public const int InitialTextAcceptButtonFieldNumber = 15;

		private string initialTextAcceptButton_;

		public const int InitialTextAdsConsentFieldNumber = 16;

		private string initialTextAdsConsent_;

		public const int InitialTextAnalyticsFieldNumber = 17;

		private string initialTextAnalytics_;

		public const int InitialTextDescFieldNumber = 18;

		private string initialTextDesc_;

		public const int InitialTextInformationFieldNumber = 19;

		private string initialTextInformation_;

		public const int InitialTextPrivacyPolicyFieldNumber = 20;

		private string initialTextPrivacyPolicy_;

		public const int InitialTextTellMoreFieldNumber = 21;

		private string initialTextTellMore_;

		public const int InitialTextTitleFieldNumber = 22;

		private string initialTextTitle_;

		public const int LanguageFieldNumber = 23;

		private string language_;

		public const int LearnMoreAcceptButtonFieldNumber = 24;

		private string learnMoreAcceptButton_;

		public const int LearnMoreDescFieldNumber = 25;

		private string learnMoreDesc_;

		public const int LearnMoreDesc2FieldNumber = 26;

		private string learnMoreDesc2_;

		public const int LearnMorePrivacySettingsFieldNumber = 27;

		private string learnMorePrivacySettings_;

		public const int LearnMoreRow1FieldNumber = 28;

		private string learnMoreRow1_;

		public const int LearnMoreRow2FieldNumber = 29;

		private string learnMoreRow2_;

		public const int LearnMoreRow3FieldNumber = 30;

		private string learnMoreRow3_;

		public const int LearnMoreTitleFieldNumber = 31;

		private string learnMoreTitle_;

		public const int PartnersDescFieldNumber = 32;

		private string partnersDesc_;

		public const int PartnersTitleFieldNumber = 33;

		private string partnersTitle_;

		public const int PrivacyButtonFirstPhaseFieldNumber = 34;

		private string privacyButtonFirstPhase_;

		public const int PrivacyButtonSecondPhaseFieldNumber = 35;

		private string privacyButtonSecondPhase_;

		public const int PrivacyDescFieldNumber = 36;

		private string privacyDesc_;

		public const int PrivacyDesc2FieldNumber = 37;

		private string privacyDesc2_;

		public const int PrivacyDescButtonFieldNumber = 38;

		private string privacyDescButton_;

		public const int PrivacyDescOffFieldNumber = 40;

		private string privacyDescOff_;

		public const int PrivacyRow1FieldNumber = 41;

		private string privacyRow1_;

		public const int PrivacyRow2FieldNumber = 42;

		private string privacyRow2_;

		public const int PrivacyTitleFieldNumber = 43;

		private string privacyTitle_;

		public const int WarningAcceptButtonFieldNumber = 44;

		private string warningAcceptButton_;

		public const int WarningConfirmFieldNumber = 45;

		private string warningConfirm_;

		public const int WarningDescFieldNumber = 46;

		private string warningDesc_;

		public const int WarningResultAcceptButtonFieldNumber = 47;

		private string warningResultAcceptButton_;

		public const int WarningResultConfirmFieldNumber = 48;

		private string warningResultConfirm_;

		public const int WarningResultDescFieldNumber = 49;

		private string warningResultDesc_;

		public const int WarningResultTitleFieldNumber = 50;

		private string warningResultTitle_;

		public const int WarningTitleFieldNumber = 51;

		private string warningTitle_;

		[DebuggerNonUserCode]
		public static MessageParser<Localization> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string Id
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string AccessModifyData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string AmBackBtn
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string AmDesc
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string AmEmailLabel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string AmIdfaLabel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string AmMessageLabel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string AmNameLabel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string AmSaveBtn
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string AmTitle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string BannerDesc
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string DeleteDesc
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string DeleteMyData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string DeleteTitle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string InitialTextAcceptButton
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string InitialTextAdsConsent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string InitialTextAnalytics
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string InitialTextDesc
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string InitialTextInformation
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string InitialTextPrivacyPolicy
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string InitialTextTellMore
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string InitialTextTitle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string Language
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string LearnMoreAcceptButton
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string LearnMoreDesc
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string LearnMoreDesc2
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string LearnMorePrivacySettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string LearnMoreRow1
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string LearnMoreRow2
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string LearnMoreRow3
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string LearnMoreTitle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string PartnersDesc
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string PartnersTitle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string PrivacyButtonFirstPhase
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string PrivacyButtonSecondPhase
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string PrivacyDesc
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string PrivacyDesc2
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string PrivacyDescButton
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string PrivacyDescOff
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string PrivacyRow1
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string PrivacyRow2
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string PrivacyTitle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string WarningAcceptButton
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string WarningConfirm
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string WarningDesc
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string WarningResultAcceptButton
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string WarningResultConfirm
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string WarningResultDesc
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string WarningResultTitle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string WarningTitle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public Localization()
		{
		}

		[DebuggerNonUserCode]
		public Localization(Localization other)
		{
		}

		[DebuggerNonUserCode]
		public Localization Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Localization other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[DebuggerNonUserCode]
		private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
		{
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(Localization other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[DebuggerNonUserCode]
		private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
		{
		}
	}
}
