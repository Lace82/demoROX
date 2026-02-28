using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200004B")]
	internal class RawBundleFileLoader : BundleLoaderBase
	{
		// Token: 0x060001EB RID: 491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1809BB0", Offset = "0x1808FB0", VA = "0x181809BB0")]
		public RawBundleFileLoader(ResourceManager impl, BundleInfo bundleInfo)
		{
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1BB05D0", Offset = "0x1BAF9D0", VA = "0x181BB05D0", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1BB09D0", Offset = "0x1BAFDD0", VA = "0x181BB09D0", Slot = "6")]
		public override void WaitForAsyncComplete()
		{
		}

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x70")]
		private RawBundleFileLoader.ESteps _steps;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x78")]
		private DownloaderBase _unpacker;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x80")]
		private DownloaderBase _downloader;

		// Token: 0x0200005C RID: 92
		[Token(Token = "0x20000BA")]
		private enum ESteps
		{
			// Token: 0x04000167 RID: 359
			[Token(Token = "0x40002BB")]
			None,
			// Token: 0x04000168 RID: 360
			[Token(Token = "0x40002BC")]
			Download,
			// Token: 0x04000169 RID: 361
			[Token(Token = "0x40002BD")]
			CheckDownload,
			// Token: 0x0400016A RID: 362
			[Token(Token = "0x40002BE")]
			Unpack,
			// Token: 0x0400016B RID: 363
			[Token(Token = "0x40002BF")]
			CheckUnpack,
			// Token: 0x0400016C RID: 364
			[Token(Token = "0x40002C0")]
			CheckFile,
			// Token: 0x0400016D RID: 365
			[Token(Token = "0x40002C1")]
			Done
		}
	}
}
