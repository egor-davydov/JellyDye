using UnityEngine;

public class SyringeNoFillActor : SyringeActor
{
	public DyesModel DyesModel;

	public Color _prevColor;

	public bool _isColorChanged;

	private float _colorChangeSnapTimer;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public override void Update()
	{
	}

	public new void OnInputDown(Vector2 pos)
	{
	}

	public new void OnInput(Vector2 pos)
	{
	}

	public override void OnInputUp(Vector2 pos)
	{
	}

	private void CheckDyeAmountSnap()
	{
	}

	protected override void DyeUpdate()
	{
	}

	private void CheckColorChanged()
	{
	}

	public override void OnLevelStart(Material startMaterial)
	{
	}

	public override void UpdateDyeAmount()
	{
	}

	protected override void CheckFillAgain()
	{
	}
}
