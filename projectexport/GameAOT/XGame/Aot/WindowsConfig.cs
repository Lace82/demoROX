using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XGame.Aot
{
	// Token: 0x0200010C RID: 268
	[Token(Token = "0x20000DB")]
	public static class WindowsConfig
	{
		// Token: 0x0600095E RID: 2398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000869")]
		[Address(RVA = "0x3892C40", Offset = "0x3892040", VA = "0x183892C40")]
		public static void InitializeWindowsSettings()
		{
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x3892D80", Offset = "0x3892180", VA = "0x183892D80")]
		private static void SetWindowsParam(string result)
		{
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x3892CC0", Offset = "0x38920C0", VA = "0x183892CC0")]
		public static void RefreshInitWindow(string projectName)
		{
		}

		// Token: 0x040004F7 RID: 1271
		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x50150")]
		public static Dictionary<string, string> WindowsSettings;
	}
}
