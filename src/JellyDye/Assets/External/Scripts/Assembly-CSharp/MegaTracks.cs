using UnityEngine;

[ExecuteInEditMode]
public class MegaTracks : MonoBehaviour
{
	public MegaShape shape;

	public int curve;

	public float start;

	public Vector3 rotate;

	public bool displayspline;

	public Vector3 linkOff;

	public Vector3 linkScale;

	public Vector3 linkOff1;

	public Vector3 linkPivot;

	public Vector3 linkRot;

	public GameObject LinkObj;

	public bool RandomOrder;

	public float LinkSize;

	public bool dolateupdate;

	public bool animate;

	public float speed;

	public Vector3 trackup;

	public bool InvisibleUpdate;

	public int seed;

	public bool rebuild;

	private bool visible;

	public bool randRot;

	private float lastpos;

	private Matrix4x4 tm;

	private Matrix4x4 wtm;

	private int linkcount;

	private int remain;

	private Transform[] linkobjs;

	public void Help()
	{
	}

	private void Awake()
	{
	}

	private void Reset()
	{
	}

	public void Rebuild()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void BuildTrack()
	{
	}

	private void OnBecameVisible()
	{
	}

	private void OnBecameInvisible()
	{
	}

	private void InitLinkObjects(MegaShape path)
	{
	}

	private void BuildObjectLinks(MegaShape path)
	{
	}

	private Quaternion GetLinkQuat(float alpha, float last, out Vector3 ps, MegaShape path)
	{
		ps = default(Vector3);
		return default(Quaternion);
	}
}
