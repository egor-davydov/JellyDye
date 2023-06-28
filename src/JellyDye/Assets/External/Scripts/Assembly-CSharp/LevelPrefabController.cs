using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class LevelPrefabController : MonoBehaviour
{
	public GameObject[] pieces;

	public float[] pieceSizes;

	public Material[] materials;

	public LevelColor[] ExtraColors;

	public LevelColor[] NearerColors;

	public LevelColor[] NearestColors;

	public Texture2D[] boundaryTex;

	public GameObject[] attachmentPoints;

	public Material fluidDisplay;

	public int activeIndex;

	private bool autoFill;

	private FluidSimulation fluidSimulation;

	private Quaternion initRotation;

	public UnityAction LevelEnd;

	private GameObject obiSolver;

	private int pieceCount;

	public UnityAction SyringeColliderDisable;

	private bool transitionForNewPiece;

	private int transitionPassFrameCount;

	private void Update()
	{
	}

	public void StartLevel()
	{
	}

	public void CreateSoftBody(GameObject softbodyObject, int i)
	{
	}

	public void PressQ()
	{
	}

	public void AutoFill()
	{
	}

	public void NextPiece()
	{
	}

	private IEnumerator ObiToggle(int index)
	{
		return null;
	}

	public void OptimizeOldPiece(GameObject piece)
	{
	}
}
