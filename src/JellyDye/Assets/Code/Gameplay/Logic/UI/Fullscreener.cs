using UnityEngine;
using UnityEngine.UI;

namespace Code.Gameplay.Logic.UI
{
  public class Fullscreener : MonoBehaviour
  {
    [SerializeField] private Image _image;
    
    private void Awake()
    {
      int screenWidth = Screen.width;
      int screenHeight = Screen.height;
      RectTransform imageRectTransform = _image.rectTransform;
      if (screenHeight >= screenWidth)
        imageRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, screenHeight);
      else
        imageRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, screenWidth);
    }
  }
}