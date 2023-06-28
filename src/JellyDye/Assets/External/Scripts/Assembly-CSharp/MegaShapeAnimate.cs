using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MegaShapeAnimate : MonoBehaviour
{
	public bool animate;

	public float time;

	public float speed;

	public MegaRepeatMode LoopMode;

	public List<MegaKnotAnim> animations;
}
