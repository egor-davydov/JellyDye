using System.Collections;
using TMPro;
using UnityEngine;

namespace Code.Gameplay.Logic.UI
{
  public class LoopLanguages : MonoBehaviour
  {
    [SerializeField] private float _languageChangeTime;
    [SerializeField] private TextMeshProUGUI _textMeshPro;
    
    [SerializeField] private string[] _texts;
    private WaitForSeconds _waitForChange;

    private void Awake()
    {
      _waitForChange = new WaitForSeconds(_languageChangeTime);
      StartCoroutine(LoopLanguagesRoutine());
    }

    private IEnumerator LoopLanguagesRoutine()
    {
      while (true)
        foreach (string text in _texts)
        {
          _textMeshPro.text = text;
          yield return _waitForChange;
        }
    }
  }
}