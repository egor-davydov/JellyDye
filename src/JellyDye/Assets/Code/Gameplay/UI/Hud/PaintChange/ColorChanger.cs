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
    private SyringePaintColor _syringePaintColor;

    public event Action<ColorChanger> OnColorChange;

    public void Initialize(SyringePaintColor syringePaintColor, Color color)
    {
      _syringePaintColor = syringePaintColor;
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
      _syringePaintColor.GetComponent<SyringeInjection>().SyringeReset();
      _syringePaintColor.ChangeLiquidColor(_containerColor);
      OnColorChange?.Invoke(this);
    }
  }
}