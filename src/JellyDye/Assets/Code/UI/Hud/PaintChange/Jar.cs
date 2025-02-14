using Code.Services;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.UI.Hud.PaintChange
{
  public class Jar : MonoBehaviour
  {
    [SerializeField] private Image _jarPaintImage;
    [SerializeField] private Button _jarButton;
    [SerializeField] private float _selectedScale;
    [SerializeField] private float _scalingTime;

    private JarsContainer _jarsContainer;
    private SyringeService _syringeService;
    private TweenerCore<Vector3, Vector3, VectorOptions> _scaleTween;
    private TweenerCore<Vector3, Vector3, VectorOptions> _unscaleTween;

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
      _jarButton.onClick.AddListener(OnJarClick);
      _scaleTween = transform.DOScale(_selectedScale, _scalingTime)
        .SetLink(gameObject).SetAutoKill(false);
      _unscaleTween = transform.DOScale(transform.localScale, _scalingTime)
        .SetLink(gameObject).SetAutoKill(false);
    }

    public void Select()
    {
      _scaleTween.Restart();
      _syringeService.SetColorAndPlaySound(Color);
    }

    public void Deselect() =>
      _unscaleTween.Restart();

    private void OnJarClick()
    {
      _jarsContainer.DeselectPreviousJarAndSelectCurrent(this);
    }
  }
}