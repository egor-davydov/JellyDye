using System;
using System.Collections.Generic;
using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;

namespace GJG.Ingame.Marketing
{
	public class AllPiecesSceneManager : MonoBehaviour
	{
		public bool FallThemAll;

		public float FallHeight;

		public float FallDuration;

		public Ease FallEase;

		[SerializeField]
		private List<FluidSimulation> fluidSimulations;

		[SerializeField]
		private List<Material> jellymats;

		public static Action OnLevelGenerated;

		public int LevelId;

		public SyringeActor Syringe;

		public ColorPalette ColorPalette;

		private LevelPrefabController level;

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
