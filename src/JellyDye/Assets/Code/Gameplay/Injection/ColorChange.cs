using System;
using System.Collections.Generic;
using Fluxy;
using UnityEngine;

namespace Code.Gameplay.Injection
{
    public class ColorChange : MonoBehaviour
    {
        [SerializeField] private FluxyTarget _fluxyTarget;
        [SerializeField] private List<Color> _colors;
        private readonly Dictionary<string, Color> _keyColors = new();

        private void Start()
        {
            for (int i = 0; i < _colors.Count; i++) 
                _keyColors.Add((i + 1).ToString(), _colors[i]);
            _fluxyTarget.color = _keyColors["1"];
        }

        private void Update()
        {
            foreach (KeyValuePair<string,Color> keyColor in _keyColors)
            {
                if (Input.GetKeyDown(keyColor.Key))
                    _fluxyTarget.color = keyColor.Value;
            }
        }
    }
}