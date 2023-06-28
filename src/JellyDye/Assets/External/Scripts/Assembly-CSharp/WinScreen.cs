using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;

public class WinScreen : UIElement
{
	public LevelEndConfetti Confetti;

	public CanvasGroup CanvasGroup;

	[SerializeField]
	private RectTransform _emojiContainer;

	[SerializeField]
	private AnimationCurve _emojiShakeCurve;

	[SerializeField]
	private Sprite[] _emojiSprites;

	private Sequence _emojiAnimSequence;

	private Vector3 _initialEmojiScale;

	private Vector3 _initialEmojiRotation;

	private Vector2 _initialEmojiPos;

	private void Awake()
	{
	}

	[Button]
	public override void Activate()
	{
	}

	[Button]
	public override void Deactivate()
	{
	}

	[Button]
	public void AnimateEmoji()
	{
	}
}
