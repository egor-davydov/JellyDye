using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class UIColorSwatch : UIElement
{
	public GameObject Content;

	public RectTransform ParentBanner;

	public RectTransform CenteredBanner;

	public Image[] RecommendedBackgrounds;

	public Image RecommendedBackgroundsCentered;

	public Image ToolIcon;

	public Image ScrollImage;

	public ScrollRect Scroll;

	public UIColor UiColorPrefab;

	public float Spacing;

	public float Scaling;

	public float Padding;

	public LevelColor FirstLevelColor;

	public Sprite SyringeIcon;

	public Sprite DropperIcon;

	private bool _isDropperSelected;

	private Sequence _toolSequence;

	private void Start()
	{
	}

	public void OnLevelStart(Material[] materials, LevelColor[] levelColors, LevelColor[] nearerColors, LevelColor[] nearestColors)
	{
	}

	public void OnChangeToolButton()
	{
	}
}
