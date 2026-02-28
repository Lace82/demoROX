using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

// Token: 0x02000008 RID: 8
[Token(Token = "0x2000007")]
public class SDKUtils
{
	// Token: 0x06000045 RID: 69 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x13835B0", Offset = "0x13829B0", VA = "0x1813835B0")]
	public static string dictToString(Dictionary<string, string> dict)
	{
		return null;
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1383790", Offset = "0x1382B90", VA = "0x181383790")]
	public static Dictionary<string, string> stringToDict(string info)
	{
		return null;
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000043")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public static void CallSDKMethod(string methodName, [Optional] string param)
	{
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1383440", Offset = "0x1382840", VA = "0x181383440")]
	public static string CallSDKMethodWithResult(string methodName, [Optional] string param)
	{
		return null;
	}

	// Token: 0x06000049 RID: 73 RVA: 0x000020A0 File Offset: 0x000002A0
	[Token(Token = "0x6000045")]
	[Address(RVA = "0xCB9160", Offset = "0xCB8560", VA = "0x180CB9160")]
	public static bool CallSDKMethodWithBoolResult(string methodName, [Optional] string param)
	{
		return default(bool);
	}

	// Token: 0x0600004A RID: 74 RVA: 0x000020B8 File Offset: 0x000002B8
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x10EE610", Offset = "0x10EDA10", VA = "0x1810EE610")]
	public static float _CallSDKMethodWithFloatResult(string methodName, [Optional] string param)
	{
		return 0f;
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public static void CallSDKMethod(string methodName, Dictionary<string, string> dictionary)
	{
	}

	// Token: 0x0600004C RID: 76 RVA: 0x000020D0 File Offset: 0x000002D0
	[Token(Token = "0x6000048")]
	[Address(RVA = "0xCB9160", Offset = "0xCB8560", VA = "0x180CB9160")]
	public static bool IsGooglePC()
	{
		return default(bool);
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1383480", Offset = "0x1382880", VA = "0x181383480")]
	public static string GetBuildVersionCode()
	{
		return null;
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004A")]
	[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
	public SDKUtils()
	{
	}

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string SplitSymbol;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<string, string> EmptyDict;
}
