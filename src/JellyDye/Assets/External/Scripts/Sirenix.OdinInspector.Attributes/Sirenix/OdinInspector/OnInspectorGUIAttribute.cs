namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	public sealed class OnInspectorGUIAttribute : ShowInInspectorAttribute
	{
		public string PrependMethodName;

		public string AppendMethodName;

		public OnInspectorGUIAttribute()
		{
		}

		public OnInspectorGUIAttribute(string methodName, bool append = true)
		{
		}

		public OnInspectorGUIAttribute(string prependMethodName, string appendMethodName)
		{
		}
	}
}
