using UnityEngine;

public class MegaPageFlip : MegaModifier
{
	public bool animT;

	public bool autoMode;

	public bool lockRho;

	public bool lockTheta;

	public float timeStep;

	public float rho;

	public float theta;

	public float deltaT;

	public float kT;

	public float turn;

	public float ap1;

	public float ap2;

	public float ap3;

	public bool flipx;

	private Vector3 apex;

	private Vector3 _cornerP;

	private Vector3 _pageOrigin;

	private float fx;

	public void calcAuto(float t)
	{
	}

	public float calcTheta(float _rho)
	{
		return 0f;
	}

	public float calcTheta2(float t)
	{
		return 0f;
	}

	public Vector3 curlTurn(Vector3 p)
	{
		return default(Vector3);
	}

	public float funcLinear(float ft, float f0, float f1)
	{
		return 0f;
	}

	public float funcQuad(float ft, float f0, float f1, float p)
	{
		return 0f;
	}

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	public Vector3 flatTurn1(Vector3 p)
	{
		return default(Vector3);
	}

	public Vector3 rotpage(Vector3 p)
	{
		return default(Vector3);
	}

	public override Vector3 Map(int i, Vector3 p)
	{
		return default(Vector3);
	}

	public override bool ModLateUpdate(MegaModContext mc)
	{
		return false;
	}

	public override bool Prepare(MegaModContext mc)
	{
		return false;
	}
}
