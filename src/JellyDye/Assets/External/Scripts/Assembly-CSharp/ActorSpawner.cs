using Obi;
using UnityEngine;

public class ActorSpawner : MonoBehaviour
{
	public ObiActor template;

	public int basePhase;

	public int maxInstances;

	public float spawnDelay;

	private int phase;

	private int instances;

	private float timeFromLastSpawn;

	private void Update()
	{
	}
}
