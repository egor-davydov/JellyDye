using System;
using Code.Gameplay.Syringe;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Gameplay.UI.Hud.PaintChange
{
  public class ColorChanger : MonoBehaviour
  {
    [SerializeField] private Image _colorContainerContentImage;
    [SerializeField] private Button _colorChangeButton;
    [SerializeField] private float _selectedScale;
    [SerializeField] private float _scalingTime;
    
    public float SelectedScale => _selectedScale;
    public float ScalingTime => _scalingTime;
    public Vector2 StartScale { get; private set; }

    private Color _containerColor;
    private SyringePaint _syringePaint;

    public event Action<ColorChanger> OnColorChange;

    public void Initialize(SyringePaint syringePaint, Color color)
    {
      _syringePaint = syringePaint;
      _containerColor = color;
      _colorContainerContentImage.color = _containerColor;
    }

    private void Start()
    {
      StartScale = transform.localScale;
      _colorChangeButton.onClick.AddListener(ChangeColorClick);
    }


    private void ChangeColorClick()
    {
      _syringePaint.GetComponent<SyringeInjection>().SyringeReset();
      _syringePaint.ChangeLiquidColor(_containerColor);
      OnColorChange?.Invoke(this);
    }
  }
}