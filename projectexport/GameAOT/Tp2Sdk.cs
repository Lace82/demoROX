using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using tss;

// Token: 0x0200002E RID: 46
[Token(Token = "0x2000013")]
public static class Tp2Sdk
{
	// Token: 0x0600029A RID: 666 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x13844B0", Offset = "0x13838B0", VA = "0x1813844B0")]
	public static void Tp2RegistTssInfoReceiver(TssInfoReceiver receiver)
	{
	}

	// Token: 0x0600029B RID: 667 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x1383C40", Offset = "0x1383040", VA = "0x181383C40")]
	public static string Tp2DecTssInfo(string info)
	{
		return null;
	}

	// Token: 0x0600029C RID: 668 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x1384520", Offset = "0x1383920", VA = "0x181384520")]
	public static void Tp2SdkInitEx(int gameId, string appKey)
	{
	}

	// Token: 0x0600029D RID: 669 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x1384660", Offset = "0x1383A60", VA = "0x181384660")]
	public static void Tp2UserLogin(int accountType, int worldId, string openId, string roleId)
	{
	}

	// Token: 0x0600029E RID: 670 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x13845C0", Offset = "0x13839C0", VA = "0x1813845C0")]
	public static void Tp2SetGamestatus(Tp2GameStatus status)
	{
	}

	// Token: 0x0600029F RID: 671 RVA: 0x00002430 File Offset: 0x00000630
	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x13845F0", Offset = "0x13839F0", VA = "0x1813845F0")]
	public static int Tp2SetLocale(int locale_id)
	{
		return 0;
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x13839B0", Offset = "0x1382DB0", VA = "0x1813839B0")]
	public static void EnableGameReport()
	{
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000200")]
	[Address(RVA = "0x13839F0", Offset = "0x1382DF0", VA = "0x1813839F0")]
	public static string Ioctl(int request, string cmd)
	{
		return null;
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000201")]
	[Address(RVA = "0x13842A0", Offset = "0x13836A0", VA = "0x1813842A0")]
	public static string Tp2Ioctl(string cmd)
	{
		return null;
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x00002448 File Offset: 0x00000648
	[Token(Token = "0x6000202")]
	[Address(RVA = "0x1383B50", Offset = "0x1382F50", VA = "0x181383B50")]
	private static bool Is64bit()
	{
		return default(bool);
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x00002460 File Offset: 0x00000660
	[Token(Token = "0x6000203")]
	[Address(RVA = "0x1383B30", Offset = "0x1382F30", VA = "0x181383B30")]
	private static bool Is32bit()
	{
		return default(bool);
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x00002478 File Offset: 0x00000678
	[Token(Token = "0x6000204")]
	[Address(RVA = "0x1383B70", Offset = "0x1382F70", VA = "0x181383B70")]
	private static IntPtr ReadIntPtr(IntPtr addr, int off)
	{
		return 0;
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000205")]
	[Address(RVA = "0x1384100", Offset = "0x1383500", VA = "0x181384100")]
	public static byte[] Tp2GetReportData()
	{
		return null;
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000206")]
	[Address(RVA = "0x1383DB0", Offset = "0x13831B0", VA = "0x181383DB0")]
	public static byte[] Tp2GetReportData2()
	{
		return null;
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x00002490 File Offset: 0x00000690
	[Token(Token = "0x6000207")]
	[Address(RVA = "0x1383F20", Offset = "0x1383320", VA = "0x181383F20")]
	public static int Tp2GetReportData4Status(uint token)
	{
		return 0;
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000208")]
	[Address(RVA = "0x1383FC0", Offset = "0x13833C0", VA = "0x181383FC0")]
	public static byte[] Tp2GetReportData4(uint token)
	{
		return null;
	}

	// Token: 0x060002AA RID: 682 RVA: 0x000024A8 File Offset: 0x000006A8
	[Token(Token = "0x6000209")]
	[Address(RVA = "0x13843E0", Offset = "0x13837E0", VA = "0x1813843E0")]
	public static int Tp2RecvSecSignature(string name, byte[] buf, uint buf_len, uint crc)
	{
		return 0;
	}

	// Token: 0x060002AB RID: 683
	[Token(Token = "0x600020A")]
	[Address(RVA = "0x13847B0", Offset = "0x1383BB0", VA = "0x1813847B0")]
	[PreserveSig]
	private static extern int tp2_sdk_init_ex(int gameId, string appKey);

	// Token: 0x060002AC RID: 684
	[Token(Token = "0x600020B")]
	[Address(RVA = "0x1384990", Offset = "0x1383D90", VA = "0x181384990")]
	[PreserveSig]
	private static extern int tp2_setuserinfo(int accountType, int worldId, string openId, string roleId);

	// Token: 0x060002AD RID: 685
	[Token(Token = "0x600020C")]
	[Address(RVA = "0x1384910", Offset = "0x1383D10", VA = "0x181384910")]
	[PreserveSig]
	private static extern int tp2_setoptions(int options);

	// Token: 0x060002AE RID: 686
	[Token(Token = "0x600020D")]
	[Address(RVA = "0x1384860", Offset = "0x1383C60", VA = "0x181384860")]
	[PreserveSig]
	private static extern IntPtr tp2_sdk_ioctl(int request, string param);

	// Token: 0x060002AF RID: 687
	[Token(Token = "0x600020E")]
	[Address(RVA = "0x1384730", Offset = "0x1383B30", VA = "0x181384730")]
	[PreserveSig]
	private static extern int tp2_free_anti_data(IntPtr info);

	// Token: 0x060002B0 RID: 688
	[Token(Token = "0x600020F")]
	[Address(RVA = "0x1384C60", Offset = "0x1384060", VA = "0x181384C60")]
	[PreserveSig]
	private static extern IntPtr tss_get_report_data();

	// Token: 0x060002B1 RID: 689
	[Token(Token = "0x6000210")]
	[Address(RVA = "0x1384AF0", Offset = "0x1383EF0", VA = "0x181384AF0")]
	[PreserveSig]
	public static extern void tss_del_report_data(IntPtr info);

	// Token: 0x060002B2 RID: 690
	[Token(Token = "0x6000211")]
	[Address(RVA = "0x1384B70", Offset = "0x1383F70", VA = "0x181384B70")]
	[PreserveSig]
	private static extern IntPtr tss_get_report_data2();

	// Token: 0x060002B3 RID: 691
	[Token(Token = "0x6000212")]
	[Address(RVA = "0x1384BE0", Offset = "0x1383FE0", VA = "0x181384BE0")]
	[PreserveSig]
	private static extern IntPtr tss_get_report_data4(uint token);

	// Token: 0x060002B4 RID: 692
	[Token(Token = "0x6000213")]
	[Address(RVA = "0x1384A70", Offset = "0x1383E70", VA = "0x181384A70")]
	[PreserveSig]
	private static extern void tss_del_report_data4(IntPtr info);

	// Token: 0x060002B5 RID: 693
	[Token(Token = "0x6000214")]
	[Address(RVA = "0x13843E0", Offset = "0x13837E0", VA = "0x1813843E0")]
	[PreserveSig]
	public static extern int tss_recv_sec_signature(string name, byte[] data, uint data_len, uint crc);

	// Token: 0x0400010F RID: 271
	[Token(Token = "0x4000091")]
	public const int TssSDKCmd_IsEmulator = 10;

	// Token: 0x04000110 RID: 272
	[Token(Token = "0x4000092")]
	private const int TssSDKCmd_CommQuery = 18;

	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200014F")]
	[StructLayout(LayoutKind.Sequential)]
	private class AntiDataInfo
	{
		// Token: 0x060002B6 RID: 694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public AntiDataInfo()
		{
		}

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ushort anti_data_len;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr anti_data;
	}

	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000150")]
	[StructLayout(LayoutKind.Sequential)]
	private class SecScanInfo
	{
		// Token: 0x060002B7 RID: 695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public SecScanInfo()
		{
		}

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int sec_scan_status;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ushort scan_data_len;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr scan_data;
	}
}
