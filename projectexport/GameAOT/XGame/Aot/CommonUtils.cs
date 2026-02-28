using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace XGame.Aot
{
	// Token: 0x0200015A RID: 346
	[Token(Token = "0x2000106")]
	public static class CommonUtils
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000064")]
		public static Action LuaFullGc
		{
			[Token(Token = "0x6000942")]
			[Address(RVA = "0x1378A30", Offset = "0x1377E30", VA = "0x181378A30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000943")]
			[Address(RVA = "0x1378B20", Offset = "0x1377F20", VA = "0x181378B20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000A81 RID: 2689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000065")]
		public static Func<string, int, string> LuaDebugTraceback
		{
			[Token(Token = "0x6000944")]
			[Address(RVA = "0x13789D0", Offset = "0x1377DD0", VA = "0x1813789D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000945")]
			[Address(RVA = "0x1378AB0", Offset = "0x1377EB0", VA = "0x181378AB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00004578 File Offset: 0x00002778
		[Token(Token = "0x6000946")]
		[Address(RVA = "0x1377C50", Offset = "0x1377050", VA = "0x181377C50")]
		public static float GetLastLowestUnityMemory()
		{
			return 0f;
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00004590 File Offset: 0x00002790
		[Token(Token = "0x6000947")]
		[Address(RVA = "0x1377C30", Offset = "0x1377030", VA = "0x181377C30")]
		public static float GetCurrentUnityMemory()
		{
			return 0f;
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000948")]
		[Address(RVA = "0x13788D0", Offset = "0x1377CD0", VA = "0x1813788D0")]
		public static void UpdateLowestUnityMemory()
		{
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000949")]
		[Address(RVA = "0x1377AC0", Offset = "0x1376EC0", VA = "0x181377AC0")]
		public static void ClearMemory()
		{
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094A")]
		[Address(RVA = "0x1377970", Offset = "0x1376D70", VA = "0x181377970")]
		public static void ClearClrMemory()
		{
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094B")]
		[Address(RVA = "0x1377A10", Offset = "0x1376E10", VA = "0x181377A10")]
		public static void ClearLuaMemory()
		{
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x000045A8 File Offset: 0x000027A8
		[Token(Token = "0x17000066")]
		public static bool NetAvailable
		{
			[Token(Token = "0x600094C")]
			[Address(RVA = "0x1378A90", Offset = "0x1377E90", VA = "0x181378A90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600094D")]
		[Address(RVA = "0x1377CF0", Offset = "0x13770F0", VA = "0x181377CF0")]
		public static string GetLuaTraceback([Optional] string msg, int level = 1)
		{
			return null;
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x1377DD0", Offset = "0x13771D0", VA = "0x181377DD0")]
		public static void RestartGame()
		{
		}

		// Token: 0x0400060F RID: 1551
		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private static Action <LuaFullGc>k__BackingField;

		// Token: 0x04000610 RID: 1552
		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private static Func<string, int, string> <LuaDebugTraceback>k__BackingField;

		// Token: 0x04000611 RID: 1553
		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static float _lastLowestUnityMemory;
	}
}
