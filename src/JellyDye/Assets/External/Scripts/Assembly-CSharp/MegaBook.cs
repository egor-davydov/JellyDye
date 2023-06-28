using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MegaBook : MonoBehaviour
{
	public float dragsensi;

	public float keysensi;

	public GameObject front;

	public GameObject back;

	public GameObject page1;

	public GameObject page2;

	public GameObject page3;

	public List<Texture> pages;

	public float bookalpha;

	public float covergap;

	public float pagespace;

	public bool interactive;

	public bool useMouse;

	public KeyCode prevPageKey;

	public KeyCode nextPageKey;

	private MegaPageFlip pf1;

	private MegaPageFlip pf2;

	private MegaPageFlip pf3;

	private MeshRenderer mrpg1;

	private MeshRenderer mrpg2;

	private MeshRenderer mrpg3;

	private int currentPage;

	private bool pageTurning;

	private MegaModifyObject pobj1;

	private MegaModifyObject pobj2;

	private MegaModifyObject pobj3;

	private float page1turn;

	private float page2turn;

	private float page3turn;

	private void SetPageTexture(MeshRenderer mr, int i, Texture t)
	{
	}

	private void Update()
	{
	}

	private void Interactive()
	{
	}

	private IEnumerator FlipToPage(int page)
	{
		return null;
	}
}
