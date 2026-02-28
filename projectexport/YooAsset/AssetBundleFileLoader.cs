using System;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

namespace YooAsset
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000047")]
	internal sealed class AssetBundleFileLoader : BundleLoaderBase
	{
		// Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1809BB0", Offset = "0x1808FB0", VA = "0x181809BB0")]
		public AssetBundleFileLoader(ResourceManager impl, BundleInfo bundleInfo)
		{
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x18092C0", Offset = "0x18086C0", VA = "0x1818092C0", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1809250", Offset = "0x1808650", VA = "0x181809250", Slot = "5")]
		public override void Destroy()
		{
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1809A90", Offset = "0x1808E90", VA = "0x181809A90", Slot = "6")]
		public override void WaitForAsyncComplete()
		{
		}

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x70")]
		private AssetBundleFileLoader.ESteps _steps;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x74")]
		private bool _isWaitForAsyncComplete;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x75")]
		private bool _isShowWaitForAsyncError;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x78")]
		private DownloaderBase _unpacker;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x80")]
		private DownloaderBase _downloader;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x88")]
		private AssetBundleCreateRequest _createRequest;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x90")]
		private Stream _managedStream;

		// Token: 0x02000055 RID: 85
		[Token(Token = "0x20000B7")]
		private enum ESteps
		{
			// Token: 0x04000140 RID: 320
			[Token(Token = "0x40002A7")]
			None,
			// Token: 0x04000141 RID: 321
			[Token(Token = "0x40002A8")]
			Download,
			// Token: 0x04000142 RID: 322
			[Token(Token = "0x40002A9")]
			CheckDownload,
			// Token: 0x04000143 RID: 323
			[Token(Token = "0x40002AA")]
			Unpack,
			// Token: 0x04000144 RID: 324
			[Token(Token = "0x40002AB")]
			CheckUnpack,
			// Token: 0x04000145 RID: 325
			[Token(Token = "0x40002AC")]
			LoadBundleFile,
			// Token: 0x04000146 RID: 326
			[Token(Token = "0x40002AD")]
			LoadDeliveryFile,
			// Token: 0x04000147 RID: 327
			[Token(Token = "0x40002AE")]
			CheckLoadFile,
			// Token: 0x04000148 RID: 328
			[Token(Token = "0x40002AF")]
			Done
		}
	}
}
