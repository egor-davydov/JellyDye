using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Obi
{
	public class ObiContactEventDispatcher : MonoBehaviour
	{
		private class ContactComparer : IComparer<Oni.Contact>
		{
			private ObiSolver solver;

			public ContactComparer(ObiSolver solver)
			{
			}

			public int Compare(Oni.Contact x, Oni.Contact y)
			{
				return 0;
			}
		}

		[Serializable]
		public class ContactCallback : UnityEvent<ObiSolver, Oni.Contact>
		{
			public ContactCallback()
			{
				((UnityEvent<T0, T1>)(object)this)._002Ector();
			}
		}

		private ObiSolver solver;

		private Oni.Contact[] prevData;

		private int prevCount;

		private ContactComparer comparer;

		public float distanceThreshold;

		public ContactCallback onContactEnter;

		public ContactCallback onContactStay;

		public ContactCallback onContactExit;

		private static int CompareByRef(ref Oni.Contact a, ref Oni.Contact b, ObiSolver solver)
		{
			return 0;
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private int FilterOutDistantContacts(Oni.Contact[] data, int count)
		{
			return 0;
		}

		private int RemoveDuplicates(Oni.Contact[] data, int count)
		{
			return 0;
		}

		private void InvokeCallbacks(Oni.Contact[] data, int count)
		{
		}

		private void Solver_OnCollision(object sender, ObiSolver.ObiCollisionEventArgs args)
		{
		}
	}
}
