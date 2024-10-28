using System;
using Code.Services.Providers;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Gameplay.UI.Hud.PaintChange
{
  public class Jar : MonoBehaviour
  {
    [SerializeField] private Image _colorContainerContentImage;
    [SerializeField] private Button _colorChangeButton;
    [SerializeField] private float _selectedScale;
    [SerializeField] private float _scalingTime;

    public float SelectedScale => _selectedScale;
    public float ScalingTime => _scalingTime;
    public Color Color => _color;
    public Vector2 StartScale { get; private set; }

    private Color _color;
    private SyringeProvider _syringeProvider;

    public event Action<Jar> OnColorChange;

    public void Initialize(SyringeProvider syringeProvider, Color color)
    {
      _syringeProvider = syringeProvider;
      _color = color;
      _colorContainerContentImage.color = _color;
    }

    private void Start()
    {
      StartScale = transform.localScale;
      _colorChangeButton.onClick.AddListener(ChangeColorClick);
    }

    private void ChangeColorClick()
    {
      _syringeProvider.SyringeInjection.SyringeReset();
      _syringeProvider.SyringeLiquidColor.ChangeLiquidColor(_color);
      OnColorChange?.Invoke(this);
    }
  }
}