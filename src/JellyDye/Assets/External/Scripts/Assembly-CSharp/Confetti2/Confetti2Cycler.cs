using System.Collections.Generic;
using UnityEngine;

namespace Confetti2
{
	public class Confetti2Cycler : MonoBehaviour
	{
		[SerializeField]
		private List<GameObject> listOfEffects;

		[SerializeField]
		private float loopTimeLength;

		private float timeOfLastInstantiate;

		private GameObject instantiatedEffect;

		private int effectIndex;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
