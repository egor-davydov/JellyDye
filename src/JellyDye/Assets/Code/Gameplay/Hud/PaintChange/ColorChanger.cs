using Code.Gameplay.Syringe;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Gameplay.Hud.PaintChange
{
  public class ColorChanger : MonoBehaviour
  {
    [SerializeField] private Image _colorContainerContentImage;
    [SerializeField] private Button _colorChangeButton;

    private Color _containerColor;
    private SyringePaint _syringePaint;

    public void Initialize(SyringePaint syringePaint, Color color)
    {
      _syringePaint = syringePaint;
      _containerColor = color;
      _colorContainerContentImage.color = _containerColor;
    }

    private void Start()
    {
      _colorChangeButton.onClick.AddListener(ChangeColorClick);
    }

    private void ChangeColorClick()
    {
      _syringePaint.GetComponent<PaintInjection>().SyringeReset();
      _syringePaint.ChangeLiquidColor(_containerColor);
    }
  }
}