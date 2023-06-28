public class MegaShapeHelix : MegaShape
{
	public float radius1;

	public float radius2;

	public float height;

	public float turns;

	public float bias;

	public float adjust;

	public bool clockwise;

	public int PointsPerTurn;

	private const float CIRCLE_VECTOR_LENGTH = 0.5517862f;

	public override void MakeShape()
	{
	}
}
