using Sirenix.Serialization;
using UnityEngine;

namespace Sirenix.OdinInspector
{
	[ShowOdinSerializedPropertiesInInspector]
	public abstract class SerializedStateMachineBehaviour : StateMachineBehaviour, ISerializationCallbackReceiver
	{
		[SerializeField]
		[HideInInspector]
		private SerializationData serializationData;

		private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
		{
		}

		private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
		{
		}

		protected virtual void OnAfterDeserialize()
		{
		}

		protected virtual void OnBeforeSerialize()
		{
		}
	}
}
