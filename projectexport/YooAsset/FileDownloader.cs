using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YooAsset
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000029")]
	internal sealed class FileDownloader : DownloaderBase
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x18191D0", Offset = "0x18185D0", VA = "0x1818191D0")]
		public FileDownloader(BundleInfo bundleInfo, Type requesterType, int failedTryAgain, int timeout)
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1818830", Offset = "0x1817C30", VA = "0x181818830", Slot = "4")]
		public override void SendRequest(params object[] args)
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1818850", Offset = "0x1817C50", VA = "0x181818850", Slot = "5")]
		public override void Update()
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1818430", Offset = "0x1817830", VA = "0x181818430", Slot = "6")]
		public override void Abort()
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x18187B0", Offset = "0x1817BB0", VA = "0x1818187B0", Slot = "7")]
		public override void Interrupt(string message)
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1818760", Offset = "0x1817B60", VA = "0x181818760", Slot = "8")]
		public override AssetBundle GetAssetBundle()
		{
			return null;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x18184B0", Offset = "0x18178B0", VA = "0x1818184B0")]
		private void CachingFile()
		{
		}

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x88")]
		private VerifyTempFileOperation _verifyFileOp;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x90")]
		private FileDownloader.ESteps _steps;

		// Token: 0x02000034 RID: 52
		[Token(Token = "0x20000B4")]
		private enum ESteps
		{
			// Token: 0x040000C9 RID: 201
			[Token(Token = "0x4000294")]
			None,
			// Token: 0x040000CA RID: 202
			[Token(Token = "0x4000295")]
			PrepareDownload,
			// Token: 0x040000CB RID: 203
			[Token(Token = "0x4000296")]
			CreateDownloader,
			// Token: 0x040000CC RID: 204
			[Token(Token = "0x4000297")]
			CheckDownload,
			// Token: 0x040000CD RID: 205
			[Token(Token = "0x4000298")]
			VerifyTempFile,
			// Token: 0x040000CE RID: 206
			[Token(Token = "0x4000299")]
			WaitingVerifyTempFile,
			// Token: 0x040000CF RID: 207
			[Token(Token = "0x400029A")]
			CachingFile,
			// Token: 0x040000D0 RID: 208
			[Token(Token = "0x400029B")]
			TryAgain,
			// Token: 0x040000D1 RID: 209
			[Token(Token = "0x400029C")]
			Done
		}
	}
}
