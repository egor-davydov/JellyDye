using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

public class UISkinGallery : UIElement
{
	public Transform Content;

	public UISkin UiSkinPrefab;

	public UISkin UiSkinVIPPrefab;

	public Image NoVideoBackground;

	public Image NoVideoPopup;

	public float _levelSize;

	public float _spacing;

	public float _paddingTop;

	public float _collectionPadding;

	public float _collectionAfterPadding;

	public float _yPaddingItem;

	private float _yPos;

	private float _scrollPosition;

	private Sequence _popupSeq;

	private bool _isOpenedOnce;

	private Sequence _activateSeq;

	private Sequence _animSeq;

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

	public void OnGalleryButton()
	{
	}

	public override void Deactivate()
	{
	}

	private void DestroyGarbage()
	{
	}
}
