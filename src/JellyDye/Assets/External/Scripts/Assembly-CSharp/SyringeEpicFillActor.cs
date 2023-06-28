using UnityEngine;

public class SyringeEpicFillActor : SyringeActor
{
	private MeshCollider _pairPiece;

	public AnimationCurve RadiusCurve;

	public float MaxRadius;

	public float RotationOffset;

	public float RotationStart;

	public float RotationEnd;

	public int Index;

	public Vector3 MidPoint;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	protected override void UpdateHaptic()
	{
	}

	protected override void StartContinousHaptic()
	{
	}

	public void FindPosition(MeshCollider pairPiece, Material mat)
	{
	}

	public void SetRotationIndex(int index)
	{
	}

	protected override void CheckFillAgain()
	{
	}

	protected override void Splat(Vector2 direction, float force, float radius)
	{
	}
}
