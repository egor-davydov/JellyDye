using System.Collections;
using System.Collections.Generic;

namespace Sirenix.Utilities
{
	public interface IImmutableList : IList, IEnumerable, ICollection
	{
	}
	public interface IImmutableList<T> : IImmutableList, IList, IEnumerable, ICollection, IList<T>, ICollection<T>, IEnumerable<T>
	{
		new T Item { get; }
	}
}
