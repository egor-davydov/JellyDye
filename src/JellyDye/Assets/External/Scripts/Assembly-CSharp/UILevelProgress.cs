using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UILevelProgress : MonoBehaviour
{
	public Image FillImage;

	public TextMeshProUGUI FirstLevelText;

	public TextMeshProUGUI SecondLevelText;

	public float StartFill;

	public int TotalStates;

	private Tween _filltween;

	public void SetState(int state)
	{
	}

	public void SetLevelTexts(string first, string second)
	{
	}
}
