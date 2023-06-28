using UnityEngine;

public class MegaGUI : MonoBehaviour
{
	public GameObject source;

	public GameObject ground;

	private bool showcommon;

	private bool showgcommon;

	private MegaModifier[] mods;

	private MegaModifier[] gmods;

	private bool[] showmod;

	private bool[] showgmod;

	private MegaModifiers context;

	private MegaModifiers gcontext;

	public bool showparams;

	public bool showgparams;

	private GUIContent[] Axislist;

	public float objsize;

	private GUIContent[] EAxislist;

	private Vector2 pos;

	public float sx;

	private Rect windowRect;

	public Material mat;

	public Material gmat;

	private GUIContent[] MatList;

	private Color gr;

	private Color gg;

	private Color gb;

	public float butwidth;

	public Color bcol;

	public Color bcol1;

	public bool ShowGui;

	public float dsize;

	public float svd;

	private float svh;

	private float lastscreenheight;

	public GUISkin skin;

	private void Start()
	{
	}

	private void InitAxis()
	{
	}

	private void InitEAxis()
	{
	}

	private void InitMatList()
	{
	}

	public int EAxisXYZ(string name, int val)
	{
		return 0;
	}

	public int EditInt(string name, int val)
	{
		return 0;
	}

	public int XYZ(string name, int val)
	{
		return 0;
	}

	public float ProSlider(string name, float val, float low, float high, float pro)
	{
		return 0f;
	}

	public float ProSlider(float val, float low, float high, float pro)
	{
		return 0f;
	}

	public float Slider(string name, float val, float low, float high)
	{
		return 0f;
	}

	public float AngleSlider(string name, float val, float scl)
	{
		return 0f;
	}

	public float AngleSlider(float val, float scl)
	{
		return 0f;
	}

	public Vector3 AngleSlider(string name, ref Vector3 val, float scl)
	{
		return default(Vector3);
	}

	public Vector3 ProSlider(string name, ref Vector3 val, float low, float high, float pro)
	{
		return default(Vector3);
	}

	public Color ColSlider(string name, ref Color val, float low, float high, float pro)
	{
		return default(Color);
	}

	private void ShowCommon(MegaModifier md, int i)
	{
	}

	private void ShowGCommon(MegaModifier md, int i)
	{
	}

	private void ShowGUI(MegaModifier mod)
	{
	}

	public void ShowGUI()
	{
	}

	private void ShowGroundGUI()
	{
	}

	private void DoWindow(int windowID)
	{
	}

	private void Update()
	{
	}

	private void SizeChange()
	{
	}

	private void OnGUI()
	{
	}
}
