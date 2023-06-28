using System.Collections.Generic;
using UnityEngine;

namespace Lofelt.NiceVibrations
{
	public class HapticCurve : MonoBehaviour
	{
		public float Amplitude;

		public float Frequency;

		public int PointsCount;

		public float AmplitudeFactor;

		private float Period;

		public RectTransform StartPoint;

		public RectTransform EndPoint;

		public bool Move;

		public float MovementSpeed;

		protected LineRenderer _targetLineRenderer;

		protected List<Vector3> Points;

		protected Canvas _canvas;

		protected Camera _camera;

		protected Vector3 _startPosition;

		protected Vector3 _endPosition;

		protected Vector3 _workPoint;

		protected virtual void Awake()
		{
		}

		protected virtual void Initialization()
		{
		}

		protected virtual void DrawCurve()
		{
		}

		protected virtual void Update()
		{
		}

		public virtual void UpdateCurve(float amplitude, float frequency)
		{
		}
	}
}
