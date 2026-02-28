using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YooAsset
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000027")]
	internal sealed class CompletedDownloader : DownloaderBase
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x18120D0", Offset = "0x18114D0", VA = "0x1818120D0")]
		public CompletedDownloader(BundleInfo bundleInfo)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "4")]
		public override void SendRequest(params object[] param)
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "5")]
		public override void Update()
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "6")]
		public override void Abort()
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "7")]
		public override void Interrupt(string message)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1812080", Offset = "0x1811480", VA = "0x181812080", Slot = "8")]
		public override AssetBundle GetAssetBundle()
		{
			return null;
		}
	}
}
