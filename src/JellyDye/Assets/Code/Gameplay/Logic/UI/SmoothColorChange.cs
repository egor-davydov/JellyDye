using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Gameplay.Logic.UI
{
  public class SmoothColorChange : MonoBehaviour
  {
    [SerializeField] private Image _image;
    [SerializeField] private Color[] _loopColors;
    [SerializeField] private float _changingTime;

    private void Awake()
    {
      LoopColors().Forget();
    }

    private async UniTaskVoid LoopColors()
    {
      while (true)
        foreach (Color color in _loopColors)
        {
          Color startImageColor = _image.color;
          for (float time = 0; time < _changingTime; time += Time.deltaTime)
          {
            _image.color = Color.Lerp(startImageColor, color, time / _changingTime);
            await UniTask.NextFrame(this.GetCancellationTokenOnDestroy());
          }
        }
    }
  }
}