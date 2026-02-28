using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000A8 RID: 168
	[Token(Token = "0x2000079")]
	public abstract class PreDownloadContentOperation : AsyncOperationBase
	{
		// Token: 0x06000339 RID: 825
		[Token(Token = "0x600031B")]
		public abstract ResourceDownloaderOperation CreateResourceDownloader(int downloadingMaxNumber, int failedTryAgain, int timeout = 60);

		// Token: 0x0600033A RID: 826
		[Token(Token = "0x600031C")]
		public abstract ResourceDownloaderOperation CreateResourceDownloader(string tag, int downloadingMaxNumber, int failedTryAgain, int timeout = 60);

		// Token: 0x0600033B RID: 827
		[Token(Token = "0x600031D")]
		public abstract ResourceDownloaderOperation CreateResourceDownloader(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout = 60);

		// Token: 0x0600033C RID: 828
		[Token(Token = "0x600031E")]
		public abstract ResourceDownloaderOperation CreateBundleDownloader(string location, int downloadingMaxNumber, int failedTryAgain, int timeout = 60);

		// Token: 0x0600033D RID: 829
		[Token(Token = "0x600031F")]
		public abstract ResourceDownloaderOperation CreateBundleDownloader(string[] locations, int downloadingMaxNumber, int failedTryAgain, int timeout = 60);

		// Token: 0x0600033E RID: 830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000320")]
		[Address(RVA = "0xB9A0F0", Offset = "0xB994F0", VA = "0x180B9A0F0")]
		protected PreDownloadContentOperation()
		{
		}
	}
}
