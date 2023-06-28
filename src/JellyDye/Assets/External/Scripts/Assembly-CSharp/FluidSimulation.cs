using System.Collections;
using UnityEngine;

public class FluidSimulation : MonoBehaviour
{
	public FluidConfig Config;

	public FluidConfig LowConfig;

	public Material SplatMaterial;

	public Material SplatVelocityMaterial;

	public Material DisplayMaterial;

	public Material CurlMaterial;

	public Material VorticityMaterial;

	public Material DivergenceMaterial;

	public Material ClearMaterial;

	public Material PressureMaterial;

	public Material GradientMaterial;

	public Material AdvectMaterial;

	public Material FillMaterial;

	private DoubleSlab VelocitySlab;

	private DoubleSlab DyeSlab;

	private DoubleSlab PressureSlab;

	private Slab DivergenceSlab;

	private Slab CurlSlab;

	public Texture2D BoundryTex;

	public Texture2D EmptyTex;

	public bool IsDone;

	public bool IsCreatedTextures;

	public int Index;

	private Color lastColor;

	private void Awake()
	{
	}

	public void CreateTextures()
	{
	}

	public void SetBorder(Texture2D boundaryTex, int index)
	{
	}

	public void Init(Texture2D boundaryTex, int index = 0)
	{
	}

	private IEnumerator InitCoroutine(Texture2D boundaryTex, int index)
	{
		return null;
	}

	private void Update()
	{
	}

	public void Step()
	{
	}

	public void Splat(float x, float y, float dx, float dy, Color color, float splatForce = 1f, float radius = 1f, float tool = 0f)
	{
	}

	private void Splat()
	{
	}

	public void Fill(Color color)
	{
	}

	public RenderTexture EndSimulation()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private void OnGUI()
	{
	}
}
