using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200004C")]
	internal class RawBundleWebLoader : BundleLoaderBase
	{
		// Token: 0x060001EE RID: 494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1809BB0", Offset = "0x1808FB0", VA = "0x181809BB0")]
		public RawBundleWebLoader(ResourceManager impl, BundleInfo bundleInfo)
		{
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1BB0B10", Offset = "0x1BAFF10", VA = "0x181BB0B10", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1BB0EA0", Offset = "0x1BB02A0", VA = "0x181BB0EA0", Slot = "6")]
		public override void WaitForAsyncComplete()
		{
		}

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x70")]
		private RawBundleWebLoader.ESteps _steps;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x78")]
		private DownloaderBase _website;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x80")]
		private DownloaderBase _downloader;

		// Token: 0x0200005E RID: 94
		[Token(Token = "0x20000BB")]
		private enum ESteps
		{
			// Token: 0x04000172 RID: 370
			[Token(Token = "0x40002C3")]
			None,
			// Token: 0x04000173 RID: 371
			[Token(Token = "0x40002C4")]
			Download,
			// Token: 0x04000174 RID: 372
			[Token(Token = "0x40002C5")]
			CheckDownload,
			// Token: 0x04000175 RID: 373
			[Token(Token = "0x40002C6")]
			Website,
			// Token: 0x04000176 RID: 374
			[Token(Token = "0x40002C7")]
			CheckWebsite,
			// Token: 0x04000177 RID: 375
			[Token(Token = "0x40002C8")]
			CheckFile,
			// Token: 0x04000178 RID: 376
			[Token(Token = "0x40002C9")]
			Done
		}
	}
}
