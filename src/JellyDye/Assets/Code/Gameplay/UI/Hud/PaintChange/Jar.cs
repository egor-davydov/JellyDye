using Code.Services;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.Hud.PaintChange
{
  public class Jar : MonoBehaviour
  {
    [SerializeField] private Image _jarPaintImage;
    [SerializeField] private Button _jarButton;
    [SerializeField] private float _selectedScale;
    [SerializeField] private float _scalingTime;

    private Tween _scaleTween;
    private JarsContainer _jarsContainer;
    private Tween _unscaleTween;
    private SyringeService _syringeService;

    [Inject]
    public void Construct(SyringeService syringeService)
    {
      _syringeService = syringeService;
    }

    public Color Color { get; private set; }

    public void Initialize(Color color, JarsContainer jarsContainer)
    {
      _jarsContainer = jarsContainer;
      Color = color;
      _jarPaintImage.color = Color;
    }

    private void Awake()
    {
      _jarButton.onClick.AddListener(Select);
      _scaleTween = transform.DOScale(_selectedScale, _scalingTime)
        .SetLink(gameObject).SetAutoKill(false);
      _unscaleTween = transform.DOScale(transform.localScale, _scalingTime)
        .SetLink(gameObject).SetAutoKill(false);
    }

    public void Select()
    {
      _jarButton.interactable = false;
      _scaleTween.Restart();
      _jarsContainer.DeselectPreviousJarAndSetCurrent(this);
      _syringeService.ResetPistonAndLiquid();
      _syringeService.SetCurrentJarColor();
    }

    public void Deselect()
    {
      _jarButton.interactable = true;
      _unscaleTween.Restart();
    }
  }
}