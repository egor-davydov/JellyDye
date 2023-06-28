using System;
using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;

namespace GJG.Ingame.Marketing
{
	public class AllPiecesFullEffectSceneManager : MonoBehaviour
	{
		public static Action OnLevelGenerated;

		public bool FallThemAll;

		public float FallHeight;

		public float FallDuration;

		public Ease FallEase;

		public int LevelId;

		public Material fluidDisplay;

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
