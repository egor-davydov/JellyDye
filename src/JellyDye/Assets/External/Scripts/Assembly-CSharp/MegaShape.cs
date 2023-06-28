using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MegaShape : MonoBehaviour
{
	public enum CrossSectionType
	{
		Circle = 0,
		Box = 1
	}

	public MegaAxis axis;

	public Color col1;

	public Color col2;

	public Color KnotCol;

	public Color HandleCol;

	public Color VecCol;

	public float KnotSize;

	public float stepdist;

	public bool normalizedInterp;

	public bool drawHandles;

	public bool drawKnots;

	public bool drawspline;

	public bool drawTwist;

	public bool lockhandles;

	public bool showorigin;

	public bool usesnap;

	public bool usesnaphandles;

	public Vector3 snap;

	public MegaHandleType handleType;

	public float CursorPos;

	public List<MegaSpline> splines;

	public bool showanimations;

	public float keytime;

	public bool updateondrag;

	public float angleError;

	public float areaError;

	public float hardAngle;

	public float packMargin;

	public float defRadius;

	public bool smoothonaddknot;

	private const float CIRCLE_VECTOR_LENGTH = 0.5517862f;

	public float testtime;

	public float time;

	public bool animate;

	public float speed;

	public int selcurve;

	public bool imported;

	public float CursorPercent;

	private float t;

	public float MaxTime;

	public MegaRepeatMode LoopMode;

	public bool dolateupdate;

	public bool makeMesh;

	public MeshShapeType meshType;

	public bool DoubleSided;

	public bool CalcTangents;

	public bool GenUV;

	public bool PhysUV;

	public float Height;

	public int HeightSegs;

	public int Sides;

	public float TubeStep;

	public float Start;

	public float End;

	public float Rotate;

	public Vector3 Pivot;

	public Vector2 UVOffset;

	public Vector2 UVRotate;

	public Vector2 UVScale;

	public Vector2 UVOffset1;

	public Vector2 UVRotate1;

	public Vector2 UVScale1;

	public Vector2 UVOffset2;

	public Vector2 UVRotate3;

	public Vector2 UVScale3;

	public bool autosmooth;

	public float smoothness;

	public bool flipNormals;

	public MegaShapeBezComputeMode smoothMode;

	public bool smoothOnDrag;

	public bool freezeX;

	public bool freezeY;

	public bool freezeZ;

	public Material mat1;

	public Material mat2;

	public Material mat3;

	public bool UseHeightCurve;

	public AnimationCurve heightCrv;

	public float heightOff;

	public Mesh shapemesh;

	private static float lastout;

	private static float lastin;

	private List<Vector3> verts;

	private List<Vector2> uvs;

	private List<int> tris;

	private List<int> tris1;

	private List<int> tris2;

	private Vector3[] cross;

	public int tsides;

	public CrossSectionType crossType;

	public float Twist;

	public int strands;

	public float tradius;

	public float offset;

	public float uvtilex;

	public float uvtiley;

	public float uvtwist;

	public float TubeLength;

	public float TubeStart;

	public float SegsPerUnit;

	public float TwistPerUnit;

	public float strandRadius;

	public float startAng;

	public float rotate;

	private int segments;

	public bool cap;

	private Vector3[] tverts;

	private Vector2[] tuvs;

	private int[] ttris;

	private Matrix4x4 tm;

	private Matrix4x4 mat;

	private Matrix4x4 wtm;

	public MegaAxis RopeUp;

	private Vector3 ropeup;

	public AnimationCurve scaleX;

	public AnimationCurve scaleY;

	public bool unlinkScale;

	public float boxwidth;

	public float boxheight;

	private float[] boxuv;

	public MegaAxis raxis;

	public int ribsegs;

	private int[] empty;

	private static int CURVELENGTHSTEPS;

	public bool conform;

	public GameObject target;

	public Collider conformCollider;

	public float[] offsets;

	public float[] last;

	public float conformAmount;

	public float raystartoff;

	public float raydist;

	public float conformOffset;

	private float minz;

	public float conformWeight;

	public virtual void MakeShape()
	{
	}

	public virtual string GetHelpURL()
	{
		return null;
	}

	public void Help()
	{
	}

	public void ResetMesh()
	{
	}

	public Matrix4x4 GetMatrix()
	{
		return default(Matrix4x4);
	}

	public void CopyIDS(int curve)
	{
	}

	public void Reverse(int c)
	{
	}

	public void SetHeight(int c, float y)
	{
	}

	public void SetTwist(int c, float twist)
	{
	}

	public MegaSpline NewSpline()
	{
		return null;
	}

	private void Reset()
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void DoUpdate()
	{
	}

	public void Centre(float scale, Vector3 axis)
	{
	}

	public void Centre(float scale, Vector3 axis, int start)
	{
	}

	public void CoordAdjust(float scale, Vector3 axis, int start)
	{
	}

	public void Scale(float scale)
	{
	}

	public void Scale(float scale, int start)
	{
	}

	public void Scale(Vector3 scale)
	{
	}

	public void MoveSpline(Vector3 delta)
	{
	}

	public void MoveSpline(Vector3 delta, int c, bool calc)
	{
	}

	public void RotateSpline(Vector3 rot, int c, bool calc)
	{
	}

	public int GetSpline(int p, ref MegaKnotAnim ma)
	{
		return 0;
	}

	public float GetCurveLength(int curve)
	{
		return 0f;
	}

	public float CalcLength(int curve, int step)
	{
		return 0f;
	}

	public void ReCalcLength()
	{
	}

	public float CalcLength()
	{
		return 0f;
	}

	public float CalcLength(int curve)
	{
		return 0f;
	}

	public Vector3 GetKnotPos(int curve, int knot)
	{
		return default(Vector3);
	}

	public Vector3 GetKnotInVec(int curve, int knot)
	{
		return default(Vector3);
	}

	public Vector3 GetKnotOutVec(int curve, int knot)
	{
		return default(Vector3);
	}

	public void SetKnotPos(int curve, int knot, Vector3 p)
	{
	}

	public void SetKnot(int curve, int knot, Vector3 p, Vector3 intan, Vector3 outtan)
	{
	}

	public void SetHandles(int curve, int knot, Vector3 intan, Vector3 outtan)
	{
	}

	public void MoveKnot(int curve, int knot, Vector3 p)
	{
	}

	public Quaternion GetRotate(int curve, float alpha)
	{
		return default(Quaternion);
	}

	public Vector3 InterpCurve3D(int curve, float alpha, bool type)
	{
		return default(Vector3);
	}

	public Vector3 InterpCurve3D(int curve, float alpha, bool type, ref float twist)
	{
		return default(Vector3);
	}

	public Vector3 InterpCurve3D(int curve, float alpha, float tanalpha, bool type, ref float twist, ref Quaternion rot)
	{
		return default(Vector3);
	}

	public static float veccalc(float angstep)
	{
		return 0f;
	}

	public Vector3 FindNearestPointWorld(Vector3 p, int iterations, ref int kn, ref Vector3 tangent, ref float alpha)
	{
		return default(Vector3);
	}

	public Vector3 FindNearestPointWorldXZ(Vector3 p, int iterations, ref int kn, ref Vector3 tangent, ref float alpha)
	{
		return default(Vector3);
	}

	public Vector3 FindNearestPoint(Vector3 p, int iterations, ref int kn, ref Vector3 tangent, ref float alpha)
	{
		return default(Vector3);
	}

	public Vector3 FindNearestPointXZ(Vector3 p, int iterations, ref int kn, ref Vector3 tangent, ref float alpha)
	{
		return default(Vector3);
	}

	public Vector3 FindNearestPoint(int crv, Vector3 p, int iterations, ref int kn, ref Vector3 tangent, ref float alpha)
	{
		return default(Vector3);
	}

	public void BuildSplineWorld(int curve, Vector3[] points, bool closed)
	{
	}

	public void BuildSpline(int curve, Vector3[] points, bool closed)
	{
	}

	public void BuildSpline(Vector3[] points, bool closed)
	{
	}

	public void AddToSpline(int curve, Vector3[] points)
	{
	}

	public void AddToSpline(int curve, Vector3 point)
	{
	}

	public void AutoCurve(int s)
	{
	}

	public void AutoCurve(MegaSpline spline)
	{
	}

	public void ComputeControlPointsOld(MegaSpline spline)
	{
	}

	public void ComputeControlPointsNew(MegaSpline spline)
	{
	}

	public void ComputeControlPointsNewClosed(MegaSpline spline)
	{
	}

	public void AutoCurve(MegaSpline spline, int start, int end)
	{
	}

	public void AutoCurve()
	{
	}

	private Vector3 SetVectorLength(Vector3 dir, float mag)
	{
		return default(Vector3);
	}

	public void SmoothHandles(MegaSpline spline, int i, float lengthFactor)
	{
	}

	private void BuildCrossSection(float rad)
	{
	}

	public void BuildTubeMesh()
	{
	}

	private Matrix4x4 GetDeformMat(float percent)
	{
		return default(Matrix4x4);
	}

	public void BuildBoxCrossSection(float width, float height)
	{
	}

	public void BuildRibbonCrossSection(float width)
	{
	}

	private void BuildRibbonMesh()
	{
	}

	private void BuildBoxMesh()
	{
	}

	private void BuildMultiStrandMesh()
	{
	}

	public void ClearMesh()
	{
	}

	public void SetMats()
	{
	}

	public void BuildMesh()
	{
	}

	public static float CurveLength(MegaSpline spline, int knot, float v1, float v2, float size)
	{
		return 0f;
	}

	public void OutlineSpline(MegaShape shape, int poly, float size, bool centered)
	{
	}

	public void OutlineSpline(MegaSpline inSpline, MegaSpline outSpline, float size, bool centered)
	{
	}

	public void SetTarget(GameObject targ)
	{
	}

	private void CalcBounds(Vector3[] verts)
	{
	}

	public void InitConform(Vector3[] verts)
	{
	}

	private void DoConform(Vector3[] verts)
	{
	}

	private void ConformTarget()
	{
	}
}
