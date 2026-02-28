using System;
using Il2CppDummyDll;

namespace XGame.Aot
{
	// Token: 0x02000102 RID: 258
	[Token(Token = "0x20000D2")]
	[Serializable]
	public class AppVersion
	{
		// Token: 0x0600093A RID: 2362 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000846")]
		[Address(RVA = "0x1376D10", Offset = "0x1376110", VA = "0x181376D10")]
		public string clientVersion()
		{
			return null;
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000847")]
		[Address(RVA = "0x1376BA0", Offset = "0x1375FA0", VA = "0x181376BA0")]
		private string GetLastVersion()
		{
			return null;
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x000040F8 File Offset: 0x000022F8
		[Token(Token = "0x6000848")]
		[Address(RVA = "0x13769F0", Offset = "0x1375DF0", VA = "0x1813769F0")]
		public static DateTime GetDateTime(string version)
		{
			return default(DateTime);
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000849")]
		[Address(RVA = "0x1376C70", Offset = "0x1376070", VA = "0x181376C70")]
		public AppVersion()
		{
		}

		// Token: 0x0400048E RID: 1166
		[Token(Token = "0x40003BB")]
		[FieldOffset(Offset = "0x10")]
		public string appVersion;

		// Token: 0x0400048F RID: 1167
		[Token(Token = "0x40003BC")]
		[FieldOffset(Offset = "0x18")]
		public string resVersion;

		// Token: 0x04000490 RID: 1168
		[Token(Token = "0x40003BD")]
		[FieldOffset(Offset = "0x20")]
		public string cfgVersion;

		// Token: 0x04000491 RID: 1169
		[Token(Token = "0x40003BE")]
		[FieldOffset(Offset = "0x28")]
		public string clientKey;

		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x40003BF")]
		[FieldOffset(Offset = "0x30")]
		public string branch;

		// Token: 0x04000493 RID: 1171
		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0x38")]
		public uint AotCodeVersion;

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0x3C")]
		public int BuildCode;

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x40003C2")]
		[FieldOffset(Offset = "0x40")]
		public int appAge;
	}
}
