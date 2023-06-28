using Sirenix.OdinInspector;

public class Marketing3DManager : MonoSingleton<Marketing3DManager>
{
	public int LEVELID;

	public SyringeActor Syringe;

	public SyringeActor ActiveSyringe;

	public LevelPrefabController[] Levels;

	public void Start()
	{
	}

	[Button]
	public void ActivateLevel()
	{
	}

	public Marketing3DManager()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
