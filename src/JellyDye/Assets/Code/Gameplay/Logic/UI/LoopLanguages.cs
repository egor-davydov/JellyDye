using System;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;

namespace Code.Gameplay.Logic.UI
{
  public class LoopLanguages : MonoBehaviour
  {
    [SerializeField] private TextMeshProUGUI _textMeshPro;
    [SerializeField] private float _languageChangeTime;
    [SerializeField] private float _languageStayTime;
    [SerializeField] private string[] _texts;

    private void Awake()
    {
      LoopLanguagesRoutine().Forget();
    }

    private async UniTaskVoid LoopLanguagesRoutine()
    {
      while (true)
        foreach (string text in _texts)
        {
          _textMeshPro.text = text;
          await UniTask.Delay(TimeSpan.FromSeconds(_languageStayTime), ignoreTimeScale: false, PlayerLoopTiming.Update,
            this.GetCancellationTokenOnDestroy());
          Color startTextColor = _textMeshPro.color;
          for (float time = 0; time < _languageChangeTime; time += Time.deltaTime)
          {
            Color color = _textMeshPro.color;
            color.a = Mathf.Lerp(startTextColor.a, 0, time / _languageChangeTime);
            _textMeshPro.color = color;
            await UniTask.NextFrame(this.GetCancellationTokenOnDestroy());
          }

          _textMeshPro.color = startTextColor;
        }
    }
  }
}