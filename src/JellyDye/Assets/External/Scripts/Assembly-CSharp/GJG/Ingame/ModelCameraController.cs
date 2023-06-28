using UnityEngine;
using UnityEngine.UI;

namespace GJG.Ingame
{
	public class ModelCameraController : MonoSingleton<ModelCameraController>
	{
		[SerializeField]
		private DisplayModel[] models;

		public string ModelName;

		[SerializeField]
		private Text modelNameHolder;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnNewModelLevelReached()
		{
		}

		public void Activate(int modelIndex)
		{
		}

		public void Deactivate()
		{
		}

		public int GetNewModelIndex()
		{
			return 0;
		}

		public ModelCameraController()
		{
			((MonoSingleton<>)(object)this)._002Ector();
		}
	}
}
