using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lofelt.NiceVibrations
{
	public class V2DemoManager : MonoBehaviour
	{
		public List<RectTransform> Pages;

		public int CurrentPage;

		public float PageTransitionDuration;

		public AnimationCurve TransitionCurve;

		public Color ActiveColor;

		public Color InactiveColor;

		public bool SoundActive;

		protected Vector3 _position;

		protected List<Pagination> _paginations;

		protected Coroutine _transitionCoroutine;

		protected virtual void Start()
		{
		}

		protected virtual void Initialization()
		{
		}

		public virtual void PreviousPage()
		{
		}

		public virtual void NextPage()
		{
		}

		protected virtual void SetCurrentPage()
		{
		}

		protected virtual void Transition(int previous, int next, bool goingRight)
		{
		}

		protected virtual IEnumerator TransitionCoroutine(int previous, int next, bool goingRight)
		{
			return null;
		}

		public virtual void TurnHapticsOn()
		{
		}

		public virtual void TurnHapticsOff()
		{
		}

		public virtual void TurnSoundsOn()
		{
		}

		public virtual void TurnSoundsOff()
		{
		}
	}
}
