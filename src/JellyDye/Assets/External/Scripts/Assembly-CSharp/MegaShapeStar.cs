public class MegaShapeStar : MegaShape
{
	private const float CIRCLE_VECTOR_LENGTH = 0.5517862f;

	private const int MIN_POINTS = 3;

	private const int MAX_POINTS = 100;

	private const float MIN_RADIUS = 0f;

	private const float MAX_RADIUS = float.MaxValue;

	private const float MIN_DIST = -180f;

	private const float MAX_DIST = 180f;

	private const int DEF_POINTS = 6;

	private const float DEF_DIST = 0f;

	private const float PI180 = 0.0174532f;

	public float radius1;

	public float radius2;

	public int points;

	public float distortion;

	public float fillet1;

	public float fillet2;

	public override string GetHelpURL()
	{
		return null;
	}

	public override void MakeShape()
	{
	}
}
