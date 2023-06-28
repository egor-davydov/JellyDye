using System.Runtime.CompilerServices;
using UnityEngine;

namespace Obi
{
	public class SerializeProperty : PropertyAttribute
	{
		public string PropertyName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public SerializeProperty(string propertyName)
		{
		}
	}
}
