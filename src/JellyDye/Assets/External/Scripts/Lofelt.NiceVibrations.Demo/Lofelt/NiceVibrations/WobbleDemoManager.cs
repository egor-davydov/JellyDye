using System.Collections.Generic;
using UnityEngine;

namespace Lofelt.NiceVibrations
{
	public class WobbleDemoManager : DemoManager
	{
		public Camera ButtonCamera;

		public RectTransform ContentZone;

		public WobbleButton WobbleButtonPrefab;

		public Vector2 PrefabSize;

		public float Margin;

		public float Padding;

		protected List<WobbleButton> Buttons;

		protected Canvas _canvas;

		protected Vector3 _position;

		protected virtual void Start()
		{
		}
	}
}
