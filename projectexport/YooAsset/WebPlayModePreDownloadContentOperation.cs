using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000AD RID: 173
	[Token(Token = "0x200007D")]
	internal class WebPlayModePreDownloadContentOperation : PreDownloadContentOperation
	{
		// Token: 0x06000357 RID: 855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1817620", Offset = "0x1816A20", VA = "0x181817620")]
		public WebPlayModePreDownloadContentOperation(WebPlayModeImpl impl)
		{
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1817610", Offset = "0x1816A10", VA = "0x181817610", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x0600035A RID: 858 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x3898D00", Offset = "0x3898100", VA = "0x183898D00", Slot = "11")]
		public override ResourceDownloaderOperation CreateResourceDownloader(int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x3898CC0", Offset = "0x38980C0", VA = "0x183898CC0", Slot = "12")]
		public override ResourceDownloaderOperation CreateResourceDownloader(string tag, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x3898CC0", Offset = "0x38980C0", VA = "0x183898CC0", Slot = "13")]
		public override ResourceDownloaderOperation CreateResourceDownloader(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x3898CC0", Offset = "0x38980C0", VA = "0x183898CC0", Slot = "14")]
		public override ResourceDownloaderOperation CreateBundleDownloader(string location, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x3898CC0", Offset = "0x38980C0", VA = "0x183898CC0", Slot = "15")]
		public override ResourceDownloaderOperation CreateBundleDownloader(string[] locations, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x48")]
		private readonly WebPlayModeImpl _impl;
	}
}
