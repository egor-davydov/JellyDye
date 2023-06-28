using System.Collections.Generic;
using Coffee.UIExtensions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UICollection : MonoBehaviour
{
	public int Id;

	private int LevelId;

	public UIShiny ShineEffect;

	public Image RewardedImage;

	public Image CompletedImage;

	public Image NotCompletedImage;

	public Image LockImage;

	public Image CompletedParent;

	public TextMeshProUGUI LevelText;

	public bool IsRewarded;

	public bool IsPassed;

	public bool IsLocked;

	public void SetData(int id, int levelId, bool isLocked, bool isRewarded, bool isPassed, Sprite unlockedSprite)
	{
	}

	public void OnSelected()
	{
	}

	private IEnumerator<float> GetImage(int id)
	{
		return null;
	}
}
