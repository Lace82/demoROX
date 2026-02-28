using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XGame.Aot
{
	// Token: 0x0200013F RID: 319
	[Token(Token = "0x20000F4")]
	public sealed class StreamingAssetsHelper
	{
		// Token: 0x06000A0B RID: 2571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xECE7D0", Offset = "0xECDBD0", VA = "0x180ECE7D0")]
		public static void Init()
		{
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00004440 File Offset: 0x00002640
		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xECE630", Offset = "0xECDA30", VA = "0x180ECE630")]
		public static bool FileExists(string packageName, string fileName, string fileCRC32)
		{
			return default(bool);
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public StreamingAssetsHelper()
		{
		}

		// Token: 0x040005A1 RID: 1441
		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0x0")]
		private static bool _bInit;

		// Token: 0x040005A2 RID: 1442
		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, StreamingAssetsHelper.PackageQuery> Packages;

		// Token: 0x02000140 RID: 320
		[Token(Token = "0x200017E")]
		private class PackageQuery
		{
			// Token: 0x06000A0F RID: 2575 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B9D")]
			[Address(RVA = "0xEC88F0", Offset = "0xEC7CF0", VA = "0x180EC88F0")]
			public PackageQuery()
			{
			}

			// Token: 0x040005A3 RID: 1443
			[Token(Token = "0x40005FB")]
			[FieldOffset(Offset = "0x10")]
			public readonly Dictionary<string, BuildInFileManifest.Element> Elements;
		}
	}
}
