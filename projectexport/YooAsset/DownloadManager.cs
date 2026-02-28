using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x2000025")]
	internal class DownloadManager
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1814CF0", Offset = "0x18140F0", VA = "0x181814CF0")]
		public DownloadManager(string packageName)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x123B510", Offset = "0x123A910", VA = "0x18123B510")]
		public void Initialize(uint breakpointResumeFileSize)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1814A80", Offset = "0x1813E80", VA = "0x181814A80")]
		public void Update()
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1814920", Offset = "0x1813D20", VA = "0x181814920")]
		public void DestroyAll()
		{
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1814540", Offset = "0x1813940", VA = "0x181814540")]
		public DownloaderBase CreateDownload(BundleInfo bundleInfo, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1814420", Offset = "0x1813820", VA = "0x181814420")]
		public void AbortUnusedDownloader()
		{
		}

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, DownloaderBase> _downloaders;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<string> _removeList;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x20")]
		private uint _breakpointResumeFileSize;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x28")]
		public readonly string PackageName;
	}
}
