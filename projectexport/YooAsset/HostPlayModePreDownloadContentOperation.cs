using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000AB RID: 171
	[Token(Token = "0x200007C")]
	internal class HostPlayModePreDownloadContentOperation : PreDownloadContentOperation
	{
		// Token: 0x0600034F RID: 847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1BA72D0", Offset = "0x1BA66D0", VA = "0x181BA72D0")]
		internal HostPlayModePreDownloadContentOperation(HostPlayModeImpl impl, string packageVersion, int timeout)
		{
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1BA6EA0", Offset = "0x1BA62A0", VA = "0x181BA6EA0", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1BA6EB0", Offset = "0x1BA62B0", VA = "0x181BA6EB0", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x06000352 RID: 850 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1BA6D40", Offset = "0x1BA6140", VA = "0x181BA6D40", Slot = "11")]
		public override ResourceDownloaderOperation CreateResourceDownloader(int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1BA6B50", Offset = "0x1BA5F50", VA = "0x181BA6B50", Slot = "12")]
		public override ResourceDownloaderOperation CreateResourceDownloader(string tag, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1BA69F0", Offset = "0x1BA5DF0", VA = "0x181BA69F0", Slot = "13")]
		public override ResourceDownloaderOperation CreateResourceDownloader(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1BA65C0", Offset = "0x1BA59C0", VA = "0x181BA65C0", Slot = "14")]
		public override ResourceDownloaderOperation CreateBundleDownloader(string location, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1BA6790", Offset = "0x1BA5B90", VA = "0x181BA6790", Slot = "15")]
		public override ResourceDownloaderOperation CreateBundleDownloader(string[] locations, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x48")]
		private readonly HostPlayModeImpl _impl;

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x50")]
		private readonly string _packageVersion;

		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x58")]
		private readonly int _timeout;

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x60")]
		private LoadCacheManifestOperation _tryLoadCacheManifestOp;

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x68")]
		private LoadCacheManifestOperation _loadCacheManifestOp;

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x70")]
		private DownloadManifestOperation _downloadManifestOp;

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x78")]
		private PackageManifest _manifest;

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x80")]
		private HostPlayModePreDownloadContentOperation.ESteps _steps;

		// Token: 0x020000AC RID: 172
		[Token(Token = "0x20000D9")]
		private enum ESteps
		{
			// Token: 0x040002C3 RID: 707
			[Token(Token = "0x400034C")]
			None,
			// Token: 0x040002C4 RID: 708
			[Token(Token = "0x400034D")]
			CheckActiveManifest,
			// Token: 0x040002C5 RID: 709
			[Token(Token = "0x400034E")]
			TryLoadCacheManifest,
			// Token: 0x040002C6 RID: 710
			[Token(Token = "0x400034F")]
			DownloadManifest,
			// Token: 0x040002C7 RID: 711
			[Token(Token = "0x4000350")]
			LoadCacheManifest,
			// Token: 0x040002C8 RID: 712
			[Token(Token = "0x4000351")]
			CheckDeserializeManifest,
			// Token: 0x040002C9 RID: 713
			[Token(Token = "0x4000352")]
			Done
		}
	}
}
