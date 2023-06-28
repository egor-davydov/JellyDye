using UnityEngine;
using UnityEngine.UI;

public class UISkin : MonoBehaviour
{
	public int Id;

	public Image SkinImage;

	public Image RewardedImage;

	public Image CompletedImage;

	public Image LockedImage;

	public Image SelectedImage;

	public Image QuestionMark;

	public bool IsUnlocked;

	public bool IsVIP;

	public bool IsSelected;

	public void SetData(int id, bool isSelected, bool isUnlocked, bool isVIP)
	{
	}

	public void OnSelected()
	{
	}
}
