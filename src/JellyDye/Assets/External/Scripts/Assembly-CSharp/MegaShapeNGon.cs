public class MegaShapeNGon : MegaShape
{
	public float radius;

	public float fillet;

	public int sides;

	public bool circular;

	public bool scribe;

	private const float CIRCLE_VECTOR_LENGTH = 0.5517862f;

	public override string GetHelpURL()
	{
		return null;
	}

	public override void MakeShape()
	{
	}
}
