using System.Collections.Generic;

namespace Newtonsoft.Json.Utilities
{
	internal class DynamicProxy<T>
	{
		public virtual IEnumerable<string> GetDynamicMemberNames(T instance)
		{
			return null;
		}
	}
}
