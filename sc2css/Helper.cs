using System.IO;

namespace sc2css;

internal class Helper
{
	public enum Endian : byte
	{
		Big,
		Little
	}

	public static void writeInt32B(BinaryWriter bw, int Value)
	{
		uint num = (uint)Value;
		uint num2 = (num & 0xFF) << 24;
		uint num3 = (num & 0xFF00) << 8;
		uint num4 = (num & 0xFF0000) >> 8;
		uint num5 = (num & 0xFF000000u) >> 24;
		num = num2 | num3 | num4 | num5;
		bw.Write(num);
	}

	public static void writeUInt32B(BinaryWriter bw, uint Value)
	{
		uint num = Value;
		uint num2 = (num & 0xFF) << 24;
		uint num3 = (num & 0xFF00) << 8;
		uint num4 = (num & 0xFF0000) >> 8;
		uint num5 = (num & 0xFF000000u) >> 24;
		num = num2 | num3 | num4 | num5;
		bw.Write(num);
	}

	public static void writeUInt16B(BinaryWriter bw, ushort Value)
	{
		ushort num = Value;
		ushort num2 = (ushort)((num & 0xFF) << 8);
		ushort num3 = (ushort)((num & 0xFF00) >> 8);
		num = (ushort)(num2 | num3);
		bw.Write(num);
	}

	public static void writeInt16B(BinaryWriter bw, short Value)
	{
		short num = Value;
		ushort num2 = (ushort)((num & 0xFF) << 8);
		ushort num3 = (ushort)((num & 0xFF00) >> 8);
		num = (short)(num2 | num3);
		bw.Write(num);
	}

	public static byte swapByte(BinaryReader br)
	{
		int num = br.ReadByte();
		int num2 = ((num & 0x33) << 2) | ((num & 0xCC) >> 2);
		return (byte)((uint)(((num2 & 0xF) << 4) | ((num2 & 0xF0) >> 4)) & 0xFFu);
	}

	public static uint swap32(uint val)
	{
		uint num = (val & 0xFF) << 24;
		uint num2 = (val & 0xFF00) << 8;
		uint num3 = (val & 0xFF0000) >> 8;
		uint num4 = (val & 0xFF000000u) >> 24;
		return num | num2 | num3 | num4;
	}

	public static ushort swap16(ushort val)
	{
		ushort num = (ushort)((val & 0xFF) << 8);
		ushort num2 = (ushort)((val & 0xFF00) >> 8);
		return (ushort)(num | num2);
	}

	public static short readInt16B(BinaryReader br)
	{
		ushort num = br.ReadUInt16();
		ushort num2 = (ushort)((num & 0xFF) << 8);
		ushort num3 = (ushort)((num & 0xFF00) >> 8);
		return (short)(ushort)(num2 | num3);
	}

	public static ushort readUInt16B(BinaryReader br)
	{
		ushort num = br.ReadUInt16();
		ushort num2 = (ushort)((num & 0xFF) << 8);
		ushort num3 = (ushort)((num & 0xFF00) >> 8);
		return (ushort)(num2 | num3);
	}

	public static int readInt32B(BinaryReader br)
	{
		uint num = br.ReadUInt32();
		uint num2 = (num & 0xFF) << 24;
		uint num3 = (num & 0xFF00) << 8;
		uint num4 = (num & 0xFF0000) >> 8;
		uint num5 = (num & 0xFF000000u) >> 24;
		return (int)(num2 | num3 | num4 | num5);
	}

	public static uint readUInt32B(BinaryReader br)
	{
		uint num = br.ReadUInt32();
		uint num2 = (num & 0xFF) << 24;
		uint num3 = (num & 0xFF00) << 8;
		uint num4 = (num & 0xFF0000) >> 8;
		uint num5 = (num & 0xFF000000u) >> 24;
		return num2 | num3 | num4 | num5;
	}

	public static double readDoubleL(BinaryReader br)
	{
		return br.ReadDouble();
	}

	public static float readFloatL(BinaryReader br)
	{
		return br.ReadSingle();
	}

	public static uint readUInt32L(BinaryReader br)
	{
		return br.ReadUInt32();
	}

	public static int readInt32L(BinaryReader br)
	{
		return br.ReadInt32();
	}

	public static uint readUInt32(BinaryReader br, Endian e)
	{
		uint num = 0u;
		if (e == Endian.Big)
		{
			return readUInt32B(br);
		}
		return readUInt32L(br);
	}

	public static int readInt32(BinaryReader br, Endian e)
	{
		int num = 0;
		if (e == Endian.Big)
		{
			return readInt32B(br);
		}
		return readInt32L(br);
	}

	public static ushort readUInt16(BinaryReader br, Endian e)
	{
		ushort num = 0;
		if (e == Endian.Big)
		{
			return readUInt16B(br);
		}
		return br.ReadUInt16();
	}

	public static short readInt16(BinaryReader br, Endian e)
	{
		short num = 0;
		if (e == Endian.Big)
		{
			return readInt16B(br);
		}
		return br.ReadInt16();
	}

	public static void writeUInt32(BinaryWriter bw, uint val, Endian e)
	{
		if (e == Endian.Big)
		{
			uint value = swap32(val);
			bw.Write(value);
		}
		else
		{
			bw.Write(val);
		}
	}

	public static void writeInt32(BinaryWriter bw, int val, Endian e)
	{
		if (e == Endian.Big)
		{
			uint value = swap32((uint)val);
			bw.Write(value);
		}
		else
		{
			bw.Write(val);
		}
	}

	public static void writeUInt16(BinaryWriter bw, ushort val, Endian e)
	{
		if (e == Endian.Big)
		{
			ushort value = swap16(val);
			bw.Write(value);
		}
		else
		{
			bw.Write(val);
		}
	}

	public static void writeInt16(BinaryWriter bw, short val, Endian e)
	{
		if (e == Endian.Big)
		{
			ushort value = swap16((ushort)val);
			bw.Write(value);
		}
		else
		{
			bw.Write(val);
		}
	}
}
