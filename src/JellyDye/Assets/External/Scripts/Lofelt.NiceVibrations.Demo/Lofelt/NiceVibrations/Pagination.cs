using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Lofelt.NiceVibrations
{
	public class Pagination : MonoBehaviour
	{
		public GameObject PaginationDotPrefab;

		public Color ActiveColor;

		public Color InactiveColor;

		protected List<Image> _images;

		public virtual void InitializePagination(int numberOfPages)
		{
		}

		public virtual void SetCurrentPage(int numberOfPages, int currentPage)
		{
		}
	}
}
