using Fluxy;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Gameplay.Injection
{
  public class ColorChanger : MonoBehaviour
  {
    [SerializeField] private Image _colorContainerContentImage;
    [SerializeField] private Button _colorChangeButton;

    private FluxyTarget _fluxyTarget;
    private Color _containerColor;

    public void Initialize(FluxyTarget fluxyTarget, Color color)
    {
      _fluxyTarget = fluxyTarget;
      _containerColor = color;
      _colorContainerContentImage.color = _containerColor;
    }

    private void Start()
    {
      _colorChangeButton.onClick.AddListener(ChangeColorClick);
    }

    private void ChangeColorClick()
    {
      PaintInjection paintInjection = _fluxyTarget.transform.parent.GetComponent<PaintInjection>();
      paintInjection.SyringeReset();
      paintInjection.ChangeLiquidColor(_containerColor);
      _fluxyTarget.color = _containerColor;
    }
  }
}