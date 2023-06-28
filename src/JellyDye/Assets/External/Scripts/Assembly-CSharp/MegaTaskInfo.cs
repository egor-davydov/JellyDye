using System.Threading;

public class MegaTaskInfo
{
	public string name;

	public int start;

	public int end;

	public AutoResetEvent pauseevent;

	public Thread _thread;

	public MegaModContext modcontext;

	public int index;

	public int cores;

	public MegaJobType jobtype;
}
