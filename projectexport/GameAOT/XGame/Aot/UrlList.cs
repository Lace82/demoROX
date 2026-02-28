using System;
using Il2CppDummyDll;

namespace XGame.Aot
{
	// Token: 0x02000107 RID: 263
	[Token(Token = "0x20000D7")]
	public class UrlList
	{
		// Token: 0x06000944 RID: 2372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000850")]
		[Address(RVA = "0xED9560", Offset = "0xED8960", VA = "0x180ED9560")]
		public UrlList(string urlList, string tag = "")
		{
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000851")]
		[Address(RVA = "0xED9380", Offset = "0xED8780", VA = "0x180ED9380")]
		public void SetUrlList(string urlList)
		{
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000852")]
		[Address(RVA = "0xED8F80", Offset = "0xED8380", VA = "0x180ED8F80")]
		public string GetCurrentURL()
		{
			return null;
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00004110 File Offset: 0x00002310
		[Token(Token = "0x6000853")]
		[Address(RVA = "0xED8FF0", Offset = "0xED83F0", VA = "0x180ED8FF0")]
		public bool HasURL()
		{
			return default(bool);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000854")]
		[Address(RVA = "0xED8D40", Offset = "0xED8140", VA = "0x180ED8D40")]
		public UrlList.Host GetCurrentHost()
		{
			return null;
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x00004128 File Offset: 0x00002328
		[Token(Token = "0x17000054")]
		public int Count
		{
			[Token(Token = "0x6000855")]
			[Address(RVA = "0xED96A0", Offset = "0xED8AA0", VA = "0x180ED96A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00004140 File Offset: 0x00002340
		[Token(Token = "0x6000856")]
		[Address(RVA = "0xED9010", Offset = "0xED8410", VA = "0x180ED9010")]
		public bool IsLastUrl()
		{
			return default(bool);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000857")]
		[Address(RVA = "0xED9030", Offset = "0xED8430", VA = "0x180ED9030")]
		public void NextURL()
		{
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000858")]
		[Address(RVA = "0xB9A940", Offset = "0xB99D40", VA = "0x180B9A940")]
		public string GetOriginURL()
		{
			return null;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000859")]
		[Address(RVA = "0xED8C20", Offset = "0xED8020", VA = "0x180ED8C20")]
		public void AddPath(string subPath)
		{
		}

		// Token: 0x040004C9 RID: 1225
		[Token(Token = "0x40003F6")]
		[FieldOffset(Offset = "0x10")]
		private string[] _mUrlArr;

		// Token: 0x040004CA RID: 1226
		[Token(Token = "0x40003F7")]
		[FieldOffset(Offset = "0x18")]
		private UrlList.Host[] _mHostArr;

		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0x20")]
		private readonly string _mTag;

		// Token: 0x040004CC RID: 1228
		[Token(Token = "0x40003F9")]
		[FieldOffset(Offset = "0x28")]
		private string _mOriginUrl;

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0x30")]
		private int _mCurrentIndex;

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40003FB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] ListSplitSymbol;

		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x8")]
		private static readonly char[] HostSplitSymbol;

		// Token: 0x02000108 RID: 264
		[Token(Token = "0x2000163")]
		public class Host
		{
			// Token: 0x0600094F RID: 2383 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B68")]
			[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
			public Host()
			{
			}

			// Token: 0x040004D0 RID: 1232
			[Token(Token = "0x4000580")]
			[FieldOffset(Offset = "0x10")]
			public string hostName;

			// Token: 0x040004D1 RID: 1233
			[Token(Token = "0x4000581")]
			[FieldOffset(Offset = "0x18")]
			public int port;
		}
	}
}
