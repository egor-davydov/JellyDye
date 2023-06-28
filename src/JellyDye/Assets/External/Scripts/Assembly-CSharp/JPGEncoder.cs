using UnityEngine;

public class JPGEncoder
{
	public int[] ZigZag;

	private int[] YTable;

	private int[] UVTable;

	private float[] fdtbl_Y;

	private float[] fdtbl_UV;

	private BitString[] YDC_HT;

	private BitString[] UVDC_HT;

	private BitString[] YAC_HT;

	private BitString[] UVAC_HT;

	private int[] std_dc_luminance_nrcodes;

	private int[] std_dc_luminance_values;

	private int[] std_ac_luminance_nrcodes;

	private int[] std_ac_luminance_values;

	private int[] std_dc_chrominance_nrcodes;

	private int[] std_dc_chrominance_values;

	private int[] std_ac_chrominance_nrcodes;

	private int[] std_ac_chrominance_values;

	private BitString[] bitcode;

	private int[] category;

	private int bytenew;

	private int bytepos;

	public ByteArray byteout;

	private int[] DU;

	private float[] YDU;

	private float[] UDU;

	private float[] VDU;

	public bool isDone;

	private BitmapData image;

	private int sf;

	private void initQuantTables(int sf)
	{
	}

	private BitString[] computeHuffmanTbl(int[] nrcodes, int[] std_table)
	{
		return null;
	}

	private void initHuffmanTbl()
	{
	}

	private void initCategoryfloat()
	{
	}

	public byte[] GetBytes()
	{
		return null;
	}

	private void writeBits(BitString bs)
	{
	}

	private void writeByte(byte value)
	{
	}

	private void writeWord(int value)
	{
	}

	private float[] fDCTQuant(float[] data, float[] fdtbl)
	{
		return null;
	}

	private void writeAPP0()
	{
	}

	private void writeSOF0(int width, int height)
	{
	}

	private void writeDQT()
	{
	}

	private void writeDHT()
	{
	}

	private void writeSOS()
	{
	}

	private float processDU(float[] CDU, float[] fdtbl, float DC, BitString[] HTDC, BitString[] HTAC)
	{
		return 0f;
	}

	private void RGB2YUV(BitmapData img, int xpos, int ypos)
	{
	}

	public JPGEncoder(Color[] pixels, int width, int height, float quality)
	{
	}

	public void doEncoding()
	{
	}

	private void encode()
	{
	}
}
