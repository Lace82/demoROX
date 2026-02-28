using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000AA RID: 170
	[Token(Token = "0x200007B")]
	internal class OfflinePlayModePreDownloadContentOperation : PreDownloadContentOperation
	{
		// Token: 0x06000347 RID: 839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1BAA7F0", Offset = "0x1BA9BF0", VA = "0x181BAA7F0")]
		public OfflinePlayModePreDownloadContentOperation(OfflinePlayModeImpl impl)
		{
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1817610", Offset = "0x1816A10", VA = "0x181817610", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x18175C0", Offset = "0x18169C0", VA = "0x1818175C0", Slot = "11")]
		public override ResourceDownloaderOperation CreateResourceDownloader(int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1817580", Offset = "0x1816980", VA = "0x181817580", Slot = "12")]
		public override ResourceDownloaderOperation CreateResourceDownloader(string tag, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1817580", Offset = "0x1816980", VA = "0x181817580", Slot = "13")]
		public override ResourceDownloaderOperation CreateResourceDownloader(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1817580", Offset = "0x1816980", VA = "0x181817580", Slot = "14")]
		public override ResourceDownloaderOperation CreateBundleDownloader(string location, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1817580", Offset = "0x1816980", VA = "0x181817580", Slot = "15")]
		public override ResourceDownloaderOperation CreateBundleDownloader(string[] locations, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x48")]
		private readonly OfflinePlayModeImpl _impl;
	}
}
