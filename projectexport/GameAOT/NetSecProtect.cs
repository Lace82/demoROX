using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using NetEase;
using UnityEngine;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000008")]
public static class NetSecProtect
{
	// Token: 0x06000050 RID: 80 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1D32680", Offset = "0x1D31A80", VA = "0x181D32680")]
	public static string exportHeartBeat(HeartBeatCmdID request)
	{
		return null;
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1D330D0", Offset = "0x1D324D0", VA = "0x181D330D0")]
	public static string exportIoctl(RequestCmdID request, string data)
	{
		return null;
	}

	// Token: 0x06000052 RID: 82
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1D32F90", Offset = "0x1D32390", VA = "0x181D32F90")]
	[PreserveSig]
	private static extern int OoO0oO0000Oo0OoO(int request, ref IntPtr ptr);

	// Token: 0x06000053 RID: 83
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1D33020", Offset = "0x1D32420", VA = "0x181D33020")]
	[PreserveSig]
	private static extern int OoO0oo0o00Oo0OoO(int request, string data, ref IntPtr ptr);

	// Token: 0x06000054 RID: 84
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1D32F10", Offset = "0x1D32310", VA = "0x181D32F10")]
	[PreserveSig]
	private static extern void O0O00ooo0o000OOo(IntPtr ptr);

	// Token: 0x06000055 RID: 85
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1D33800", Offset = "0x1D32C00", VA = "0x181D33800")]
	[PreserveSig]
	private static extern void oOOOoooo0000o00O();

	// Token: 0x06000056 RID: 86
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1D33720", Offset = "0x1D32B20", VA = "0x181D33720")]
	[PreserveSig]
	private static extern int oOOO00Oo0000o0OO(int version, bool encode, bool isCrucial, int alg, byte[] data, int len, ref IntPtr ptr);

	// Token: 0x06000057 RID: 87
	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1D33870", Offset = "0x1D32C70", VA = "0x181D33870")]
	[PreserveSig]
	private static extern int oOOoo0Oo0000000O(int alg, int timeout, byte[] data, int len, ref IntPtr ptr);

	// Token: 0x06000058 RID: 88
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1D32E90", Offset = "0x1D32290", VA = "0x181D32E90")]
	[PreserveSig]
	private static extern void O0O00o0o0o000OOo(IntPtr ptr);

	// Token: 0x06000059 RID: 89 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1D331F0", Offset = "0x1D325F0", VA = "0x181D331F0")]
	private static string initDecrypt(string cipherText)
	{
		return null;
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000056")]
	[Address(RVA = "0xBA6AF0", Offset = "0xBA5EF0", VA = "0x180BA6AF0")]
	private static AndroidJavaObject getAndroidConfig(HTProtectConfig hTProtectConfig)
	{
		return null;
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1D335F0", Offset = "0x1D329F0", VA = "0x181D335F0")]
	public static void init(string productId, HTPCallback cb, HTProtectConfig hTProtectConfig)
	{
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1D33100", Offset = "0x1D32500", VA = "0x181D33100")]
	public static string getDataSign(string inputData, int algIndex)
	{
		return null;
	}

	// Token: 0x0600005D RID: 93 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x6000059")]
	[Address(RVA = "0xBA6AF0", Offset = "0xBA5EF0", VA = "0x180BA6AF0")]
	public static int setRoleInfo(string businessId, string roleId, string roleName, string roleAccount, string roleServer, int serverId, string gameJson)
	{
		return 0;
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public static void logOut()
	{
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1D336F0", Offset = "0x1D32AF0", VA = "0x181D336F0")]
	public static string localSaveEncode(string inputData, int algIndex)
	{
		return null;
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1D336C0", Offset = "0x1D32AC0", VA = "0x181D336C0")]
	public static string localSaveDecode(string inputData, int algIndex)
	{
		return null;
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1D33690", Offset = "0x1D32A90", VA = "0x181D33690")]
	public static string localSaveBytesEncode(byte[] inputData, int algIndex)
	{
		return null;
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1D33650", Offset = "0x1D32A50", VA = "0x181D33650")]
	public static byte[] localSaveBytesDecode(string inputData, int algIndex)
	{
		return null;
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1D33620", Offset = "0x1D32A20", VA = "0x181D33620")]
	public static string ioctl(RequestCmdID request, string data)
	{
		return null;
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1D33930", Offset = "0x1D32D30", VA = "0x181D33930")]
	public static void registInfoReceiver(InfoReceiver receiver)
	{
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000061")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public static void registerTouchEvent(int gameplayId, int sceneId)
	{
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000062")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public static void unregisterTouchEvent()
	{
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1D33BA0", Offset = "0x1D32FA0", VA = "0x181D33BA0")]
	public static SafeCommResult safeCommToServerByteV30(int version, int alg, byte[] inputData, bool isCrucial)
	{
		return null;
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1D33D20", Offset = "0x1D33120", VA = "0x181D33D20")]
	public static SafeCommResult safeCommToServerV30(int version, int alg, byte[] inputData, bool isCrucial)
	{
		return null;
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000065")]
	[Address(RVA = "0x1D33C40", Offset = "0x1D33040", VA = "0x181D33C40")]
	public static SafeCommResult safeCommToServerByte(int alg, byte[] inputData)
	{
		return null;
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1D33DC0", Offset = "0x1D331C0", VA = "0x181D33DC0")]
	public static SafeCommResult safeCommToServer(int alg, byte[] inputData)
	{
		return null;
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1D339B0", Offset = "0x1D32DB0", VA = "0x181D339B0")]
	public static SafeCommResult safeCommFromServerByte(int alg, int timeout, byte[] inputData)
	{
		return null;
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x1D33A90", Offset = "0x1D32E90", VA = "0x181D33A90")]
	public static SafeCommResult safeCommFromServer(int alg, int timeout, string inputData)
	{
		return null;
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1D33EA0", Offset = "0x1D332A0", VA = "0x181D33EA0")]
	public static string safeComm(string inputData, int algType, bool dec)
	{
		return null;
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x600006A")]
	[Address(RVA = "0xCB9160", Offset = "0xCB8560", VA = "0x180CB9160")]
	public static bool isHtpExist()
	{
		return default(bool);
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1D33130", Offset = "0x1D32530", VA = "0x181D33130")]
	public static AntiCheatResult getToken(int timeout, string businessId)
	{
		return null;
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006C")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public static void getTokenAsync(int timeout, string businessId, GetTokenCallback callback)
	{
	}

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4FF03")]
	private static bool isInitialized;
}
