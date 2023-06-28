using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

public class UIGallery : UIElement
{
	public Transform Content;

	public ScrollRect Scroll;

	public Image LightEffect;

	public UICollection UiCollectionPrefab;

	public UICollectionTitle UiCollectionTitlePrefab;

	public ParticleSystem Confetti;

	public Image NoVideoBackground;

	public Image NoVideoPopup;

	public Sprite[] BannerSprites;

	public Sprite UnlockBaseSprite;

	public float _levelSize;

	public float _spacing;

	public float _paddingTop;

	public float _collectionPadding;

	public float _collectionAfterPadding;

	public float _yPaddingItem;

	public float ScrollOffset;

	private float _yPos;

	private float _scrollPosition;

	private Sequence _popupSeq;

	private bool _isOpenedOnce;

	private CanvasGroup _canvasGroup;

	private Sequence _activateSeq;

	private Sequence _animSeq;

	private void Awake()
	{
	}

	public void ShowNoVideo()
	{
	}

	public void CloseNoVideo()
	{
	}

	[Button]
	public override void Activate()
	{
	}

	[Button]
	private void AnimateLightEffect()
	{
	}

	public override void Deactivate()
	{
	}

	public void OnSkinButton()
	{
	}

	private void DestroyGarbage()
	{
	}

	public void ActivateWithoutAnim()
	{
	}
}
