using Sirenix.OdinInspector;
using Sirenix.Utilities;
using UnityEngine;

namespace Sirenix.Serialization
{
	[HideMonoScript]
	[SirenixGlobalConfig]
	public class GlobalSerializationConfig : GlobalConfig<GlobalSerializationConfig>
	{
		public const string ODIN_SERIALIZATION_CAUTIONARY_WARNING_TEXT = "Odin's custom serialization protocol is stable and fast, and doesn't use any reflection on standalone platforms in order to serialize and deserialize your data. It is built to be fast, reliable and resilient above all.\n\n*Words of caution* \nHowever, caveats apply - there is a reason Unity chose such a drastically limited serialization protocol. It keeps things simple and manageable, and limits how much complexity you can introduce into your data structures. It can be very easy to get carried away and shoot yourself in the foot when all limitations suddenly disappear, and hence we have included this cautionary warning.\n\nThere can of course be valid reasons to use a more powerful serialization protocol such as Odin's. However, please read the 'Words of caution' section under 'Serialize Anything' in the Manual, so you know what you're getting into.\n\n*For those on AOT platforms* \nAdditionally, if you are building to AOT platforms, you should be aware that Odin's serialization currently makes use of reflection behind the scenes on all AOT platforms, which may result in lag spikes in your game if you make heavy use of it.";

		public const string ODIN_PREFAB_CAUTIONARY_WARNING_TEXT = "In 2018.3, Unity introduced a new prefab workflow, and in so doing, changed how all prefabs fundamentally work. Despite our best efforts, we have so far been unable to achieve a stable implementation of Odin-serialized prefab modifications on prefab instances and variants in the new prefab workflow.This has nothing to do with Odin serializer itself, which remains rock solid. Odin-serialized ScriptableObjects and non-prefab Components/Behaviours are still perfectly stable - you are only seeing this message because this is an Odin-serialized prefab asset or instance.\n\nWe are currently in the process of doing an in-depth review of possible ways of implementing Odin-serialized modifications properly with the new prefab workflow. Meanwhile, using prefabs with Odin serialization in 2018.3 and above will be considered a *deprecated feature*.\n\nWe would like to emphasize that *our efforts may fail*. There is a real chance that we will conclude that we simply cannot support this feature any more in the new prefab workflow, in which case it will be deprecated *permanently*. We hope it won't come to that, but we sadly cannot promise that it won't happen. If we do deprecate the feature, we will not remove it, but we *will* stop supporting it. You may continue using it, but only at your own risk.\n\nPlease keep all this in mind, if you wish to continue using Odin-serialized prefabs.";

		public const string ODIN_SERIALIZATION_CAUTIONARY_WARNING_BUTTON_TEXT = "I know what I'm about, son. Hide message forever.";

		public const string ODIN_PREFAB_CAUTIONARY_WARNING_BUTTON_TEXT = "I understand that prefabs might break. Hide message forever.";

		private static readonly DataFormat[] BuildFormats;

		[ToggleLeft]
		public bool HideSerializationCautionaryMessage;

		[ToggleLeft]
		public bool HidePrefabCautionaryMessage;

		[ToggleLeft]
		[SerializeField]
		public bool HideOdinSerializeAttributeWarningMessages;

		[SerializeField]
		[ToggleLeft]
		public bool HideNonSerializedShowInInspectorWarningMessages;

		[SerializeField]
		private DataFormat buildSerializationFormat;

		[SerializeField]
		private DataFormat editorSerializationFormat;

		[SerializeField]
		private LoggingPolicy loggingPolicy;

		[SerializeField]
		private ErrorHandlingPolicy errorHandlingPolicy;

		public ILogger Logger => null;

		public DataFormat EditorSerializationFormat
		{
			get
			{
				return default(DataFormat);
			}
			set
			{
			}
		}

		public DataFormat BuildSerializationFormat
		{
			get
			{
				return default(DataFormat);
			}
			set
			{
			}
		}

		public LoggingPolicy LoggingPolicy
		{
			get
			{
				return default(LoggingPolicy);
			}
			set
			{
			}
		}

		public ErrorHandlingPolicy ErrorHandlingPolicy
		{
			get
			{
				return default(ErrorHandlingPolicy);
			}
			set
			{
			}
		}

		[OnInspectorGUI]
		private void OnInspectorGUI()
		{
		}

		public GlobalSerializationConfig()
		{
			((GlobalConfig<T>)(object)this)._002Ector();
		}
	}
}
