using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq
{
	public readonly struct JEnumerable<T> : IEnumerable<T>, IEnumerable, IEquatable<JEnumerable<T>> where T : JToken
	{
		public static readonly JEnumerable<T> Empty;

		private readonly IEnumerable<T> _enumerable;

		public JEnumerable(IEnumerable<T> enumerable)
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		public bool Equals(JEnumerable<T> other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
