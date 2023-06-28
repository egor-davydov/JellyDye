using UnityEngine;

public class MegaPointCacheInstance : MonoBehaviour
{
	[HideInInspector]
	public MegaPointCache mod;

	[HideInInspector]
	public MegaModifyObject modobj;

	public GameObject obj;

	[HideInInspector]
	public Mesh mesh;

	public float time;

	public float speed;

	public int updateRate;

	public int frame;

	public bool recalcNorms;

	public bool recalcBounds;

	public void SetSource(GameObject srcobj)
	{
	}

	private void Update()
	{
	}
}
