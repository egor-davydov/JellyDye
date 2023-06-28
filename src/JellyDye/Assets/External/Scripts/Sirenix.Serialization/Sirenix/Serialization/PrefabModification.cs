using System.Collections.Generic;
using UnityEngine;

namespace Sirenix.Serialization
{
	public sealed class PrefabModification
	{
		public PrefabModificationType ModificationType;

		public string Path;

		public List<string> ReferencePaths;

		public object ModifiedValue;

		public int NewLength;

		public object[] DictionaryKeysAdded;

		public object[] DictionaryKeysRemoved;

		public void Apply(Object unityObject)
		{
		}

		private void ApplyValue(Object unityObject)
		{
		}

		private void ApplyListLength(Object unityObject)
		{
		}

		private void ApplyDictionaryModifications(Object unityObject)
		{
		}

		private static void ReplaceAllReferencesInGraph(object graph, object oldReference, object newReference, HashSet<object> processedReferences = null)
		{
		}

		private static object GetInstanceFromPath(string path, object instance)
		{
			return null;
		}

		private static object GetInstanceOfStep(string step, object instance)
		{
			return null;
		}

		private static void SetInstanceToPath(string path, object instance, object value)
		{
		}

		private static void SetInstanceToPath(string path, string[] steps, int index, object instance, object value, out bool setParentInstance)
		{
			setParentInstance = default(bool);
		}

		private static bool TrySetInstanceOfStep(string step, object instance, object value, out bool setParentInstance)
		{
			setParentInstance = default(bool);
			return false;
		}
	}
}
