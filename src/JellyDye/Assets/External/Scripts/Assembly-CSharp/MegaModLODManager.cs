using UnityEngine;

public class MegaModLODManager : MonoBehaviour
{
	public GameObject theCamera;

	public GameObject meshContainer;

	public MegaModLOD[] levelsOfDetail;

	public int currentLOD;

	private float lastLODCheckTime;

	private float LODCheckInterval;

	private void Update()
	{
	}
}
