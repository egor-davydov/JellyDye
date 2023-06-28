using UnityEngine;
using UnityEngine.UI;

namespace Lofelt.NiceVibrations
{
	public class MMFPSCounter : MonoBehaviour
	{
		public float UpdateInterval;

		protected float _framesAccumulated;

		protected float _framesDrawnInTheInterval;

		protected float _timeLeft;

		protected Text _text;

		protected int _currentFPS;

		private static string[] _stringsFrom00To300;

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}
	}
}
