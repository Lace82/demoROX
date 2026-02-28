using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YooAsset
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x200002A")]
	internal sealed class WebDownloader : DownloaderBase
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x18191D0", Offset = "0x18185D0", VA = "0x1818191D0")]
		public WebDownloader(BundleInfo bundleInfo, Type requesterType, int failedTryAgain, int timeout)
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x3896750", Offset = "0x3895B50", VA = "0x183896750", Slot = "4")]
		public override void SendRequest(params object[] args)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x3896800", Offset = "0x3895C00", VA = "0x183896800", Slot = "5")]
		public override void Update()
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x3896550", Offset = "0x3895950", VA = "0x183896550", Slot = "6")]
		public override void Abort()
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x38966D0", Offset = "0x3895AD0", VA = "0x1838966D0", Slot = "7")]
		public override void Interrupt(string message)
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x38965D0", Offset = "0x38959D0", VA = "0x1838965D0", Slot = "8")]
		public override AssetBundle GetAssetBundle()
		{
			return null;
		}

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x88")]
		private WebDownloader.ESteps _steps;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x8C")]
		private bool _getAssetBundle;

		// Token: 0x02000036 RID: 54
		[Token(Token = "0x20000B5")]
		private enum ESteps
		{
			// Token: 0x040000D5 RID: 213
			[Token(Token = "0x400029E")]
			None,
			// Token: 0x040000D6 RID: 214
			[Token(Token = "0x400029F")]
			PrepareDownload,
			// Token: 0x040000D7 RID: 215
			[Token(Token = "0x40002A0")]
			CreateDownloader,
			// Token: 0x040000D8 RID: 216
			[Token(Token = "0x40002A1")]
			CheckDownload,
			// Token: 0x040000D9 RID: 217
			[Token(Token = "0x40002A2")]
			TryAgain,
			// Token: 0x040000DA RID: 218
			[Token(Token = "0x40002A3")]
			Done
		}
	}
}
