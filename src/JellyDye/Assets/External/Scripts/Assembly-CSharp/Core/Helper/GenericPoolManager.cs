using System.Collections.Generic;
using UnityEngine;

namespace Core.Helper
{
	public class GenericPoolManager<T> where T : MonoBehaviour
	{
		private const int DefaultIncreaseAmount = 3;

		private readonly T _prefab;

		private readonly Transform _container;

		private readonly Queue<T> _availableItems;

		private readonly List<T> _busyItems;

		public int Capacity => 0;
	}
}
