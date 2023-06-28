using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace GJG.Ingame.Marketing
{
	public class HandWiggleSceneManager : MonoBehaviour
	{
		public static Action OnLevelGenerated;

		public int LevelId;

		public Material fluidDisplay;

		private LevelPrefabController level;

		public SyringeActor Syringe;

		public ColorPalette ColorPalette;

		private HandController hand;

		private Vector3 initialSyringePosition;

		[SerializeField]
		private List<FluidSimulation> fluidSimulations;

		[SerializeField]
		private List<Material> jellymats;

		private void Update()
		{
		}

		[Button]
		public void GenerateLevel()
		{
		}

		private void AttachPiece(GameObject piece, GameObject attachmentPoint)
		{
		}

		[Button]
		public void Clear()
		{
		}
	}
}
