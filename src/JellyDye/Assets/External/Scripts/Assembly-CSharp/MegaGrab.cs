using System.Collections;
using UnityEngine;

public class MegaGrab : MonoBehaviour
{
	public Camera SrcCamera;

	public KeyCode GrabKey;

	public int ResUpscale;

	public float Blur;

	public int AASamples;

	public AnisotropicFiltering FilterMode;

	public bool UseJitter;

	public string SaveName;

	public string Format;

	public string Enviro;

	public string Path;

	public bool UseDOF;

	public float focalDistance;

	public int totalSegments;

	public float sampleRadius;

	public bool CalcFromSize;

	public int Dpi;

	public float Width;

	public int NumberOfGrabs;

	public float EstimatedTime;

	public int GrabWidthWillBe;

	public int GrabHeightWillBe;

	public bool UseCoroutine;

	private float mleft;

	private float mright;

	private float mtop;

	private float mbottom;

	private int sampcount;

	private Vector2[] poisson;

	private Texture2D grabtex;

	private Color[,] accbuf;

	private Color[,] blendbuf;

	private byte[] output1;

	private Color[] outputjpg;

	private AnisotropicFiltering filtering;

	private MGBlendTable blendtable;

	private int DOFSamples;

	private Vector3 camfor;

	private Vector3 campos;

	private Matrix4x4 camtm;

	public IMGFormat OutputFormat;

	public float Quality;

	public bool uploadGrabs;

	public string m_URL;

	private void CalcDOFInfo(Camera camera)
	{
	}

	private void ChangeDOFPos(int segment)
	{
	}

	private static Matrix4x4 PerspectiveOffCenter(float left, float right, float bottom, float top, float near, float far)
	{
		return default(Matrix4x4);
	}

	private Matrix4x4 CalcProjectionMatrix(float left, float right, float bottom, float top, float near, float far, float xoff, float yoff)
	{
		return default(Matrix4x4);
	}

	private void Cleanup()
	{
	}

	private bool InitGrab(int width, int height, int aasamples)
	{
		return false;
	}

	private Texture2D GrabImage(int samples, float x, float y)
	{
		return null;
	}

	private void GrabAA(float x, float y)
	{
	}

	private Texture2D GrabImageDOF(int samples, float x, float y)
	{
		return null;
	}

	private void DoGrabTGA()
	{
	}

	private void DoGrabJPG()
	{
	}

	private void SaveJPG(string filename, int width, int height, Color[] pixels)
	{
	}

	private void UploadJPG(string filename, int width, int height, Color[] pixels)
	{
	}

	private void SaveTGA(string filename, int width, int height, byte[] pixels)
	{
	}

	private void CalcUpscale()
	{
	}

	private void CalcEstimate()
	{
	}

	private IEnumerator GrabCoroutine()
	{
		return null;
	}

	private void LateUpdate()
	{
	}

	private void OnDrawGizmos()
	{
	}

	private IEnumerator UploadFileCo(byte[] data, string uploadURL, string filename)
	{
		return null;
	}

	private void UploadFile(byte[] data, string uploadURL, string filename)
	{
	}

	private IEnumerator UploadLevel(byte[] data, string uploadURL, string filename)
	{
		return null;
	}
}
