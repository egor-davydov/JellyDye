using System.Collections;
using System.Collections.Generic;

namespace Sirenix.Serialization.Utilities
{
	internal interface IImmutableList : IList, IEnumerable, ICollection
	{
	}
	internal interface IImmutableList<T> : IImmutableList, IList, IEnumerable, ICollection, IList<T>, ICollection<T>, IEnumerable<T>
	{
		new T Item { get; }
	}
}
