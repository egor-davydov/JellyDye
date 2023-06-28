using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;

public class CameraManager : MonoSingleton<CameraManager>
{
	public GameObject Floor;

	private Vector3 _initialPos;

	private Vector3 _initialRot;

	public Vector3 GameEndPosition;

	public Vector3 GameEndRotation;

	public float AnimTimer;

	public float TargetX;

	private Sequence _anim;

	public Camera _cam;

	private void Start()
	{
	}

	[Button]
	public void OnGameEnd()
	{
	}

	[Button]
	public void OnGameStart()
	{
	}

	public CameraManager()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
