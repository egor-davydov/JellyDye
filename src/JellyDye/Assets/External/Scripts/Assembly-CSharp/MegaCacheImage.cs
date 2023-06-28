using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

[Serializable]
public class MegaCacheImage : ScriptableObject
{
	public class MegaCacheOBJTaskInfo
	{
		public string name;

		public AutoResetEvent pauseevent;

		public Thread _thread;

		public MegaCacheOBJ objcache;

		public int end;

		public int frame;
	}

	public List<MegaCacheImageFrame> frames;

	public int maxsm;

	public int maxv;

	public int maxtris;

	public int[] smfc;

	public int lastframe;

	public int preloaded;

	public int memoryuse;

	public bool threadupdate;

	public int Cores;

	private static bool isRunning;

	private MegaCacheOBJTaskInfo[] tasks;

	private void MakeThreads(MegaCacheOBJ cache)
	{
	}

	private void DoWork(object info)
	{
	}

	public void GetNextFrame(MegaCacheOBJ cache, int frame)
	{
	}

	private void OnDestroy()
	{
	}

	public void PreLoad(int frame, MegaCacheOBJ cache)
	{
	}

	public void GetMesh(Mesh mesh, int frame, MegaCacheOBJ cache)
	{
	}

	public void GetMeshRef(Mesh mesh, int frame, MegaCacheOBJ cache)
	{
	}

	public void GetMeshPreLoaded(Mesh mesh, int frame, MegaCacheOBJ cache)
	{
	}

	public int CalcMemory()
	{
		return 0;
	}

	public static MegaCacheImageFrame CreateImageFrame(Mesh ms)
	{
		return null;
	}
}
