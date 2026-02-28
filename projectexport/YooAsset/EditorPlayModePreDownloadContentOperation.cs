using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000A9 RID: 169
	[Token(Token = "0x200007A")]
	internal class EditorPlayModePreDownloadContentOperation : PreDownloadContentOperation
	{
		// Token: 0x0600033F RID: 831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1817620", Offset = "0x1816A20", VA = "0x181817620")]
		public EditorPlayModePreDownloadContentOperation(EditorSimulateModeImpl impl)
		{
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1817610", Offset = "0x1816A10", VA = "0x181817610", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x06000342 RID: 834 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x18175C0", Offset = "0x18169C0", VA = "0x1818175C0", Slot = "11")]
		public override ResourceDownloaderOperation CreateResourceDownloader(int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1817580", Offset = "0x1816980", VA = "0x181817580", Slot = "12")]
		public override ResourceDownloaderOperation CreateResourceDownloader(string tag, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x1817580", Offset = "0x1816980", VA = "0x181817580", Slot = "13")]
		public override ResourceDownloaderOperation CreateResourceDownloader(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1817580", Offset = "0x1816980", VA = "0x181817580", Slot = "14")]
		public override ResourceDownloaderOperation CreateBundleDownloader(string location, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1817580", Offset = "0x1816980", VA = "0x181817580", Slot = "15")]
		public override ResourceDownloaderOperation CreateBundleDownloader(string[] locations, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x48")]
		private readonly EditorSimulateModeImpl _impl;
	}
}
