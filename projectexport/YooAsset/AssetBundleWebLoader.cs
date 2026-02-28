using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000048")]
	internal sealed class AssetBundleWebLoader : BundleLoaderBase
	{
		// Token: 0x060001BF RID: 447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1809BB0", Offset = "0x1808FB0", VA = "0x181809BB0")]
		public AssetBundleWebLoader(ResourceManager impl, BundleInfo bundleInfo)
		{
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1809BC0", Offset = "0x1808FC0", VA = "0x181809BC0", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x180A020", Offset = "0x1809420", VA = "0x18180A020", Slot = "6")]
		public override void WaitForAsyncComplete()
		{
		}

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x70")]
		private AssetBundleWebLoader.ESteps _steps;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x78")]
		private DownloaderBase _downloader;

		// Token: 0x02000057 RID: 87
		[Token(Token = "0x20000B8")]
		private enum ESteps
		{
			// Token: 0x0400014C RID: 332
			[Token(Token = "0x40002B1")]
			None,
			// Token: 0x0400014D RID: 333
			[Token(Token = "0x40002B2")]
			LoadWebSiteFile,
			// Token: 0x0400014E RID: 334
			[Token(Token = "0x40002B3")]
			LoadRemoteFile,
			// Token: 0x0400014F RID: 335
			[Token(Token = "0x40002B4")]
			CheckLoadFile,
			// Token: 0x04000150 RID: 336
			[Token(Token = "0x40002B5")]
			Done
		}
	}
}
