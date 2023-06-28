using System;
using GJG.Ingame;
using UnityEngine;

public class SyringeTriggers : MonoBehaviour
{
	public static Action OnPenetrated;

	public static Action OnRemoved;

	private SyringeAnimationController animator;

	private void OnEnable()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
