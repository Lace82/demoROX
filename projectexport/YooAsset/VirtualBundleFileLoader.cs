using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200004D")]
	internal class VirtualBundleFileLoader : BundleLoaderBase
	{
		// Token: 0x060001F1 RID: 497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1809BB0", Offset = "0x1808FB0", VA = "0x181809BB0")]
		public VirtualBundleFileLoader(ResourceManager impl, BundleInfo bundleInfo)
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x3895E50", Offset = "0x3895250", VA = "0x183895E50", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x3895F70", Offset = "0x3895370", VA = "0x183895F70", Slot = "6")]
		public override void WaitForAsyncComplete()
		{
		}

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x70")]
		private VirtualBundleFileLoader.ESteps _steps;

		// Token: 0x02000060 RID: 96
		[Token(Token = "0x20000BC")]
		private enum ESteps
		{
			// Token: 0x0400017B RID: 379
			[Token(Token = "0x40002CB")]
			None,
			// Token: 0x0400017C RID: 380
			[Token(Token = "0x40002CC")]
			CheckFile,
			// Token: 0x0400017D RID: 381
			[Token(Token = "0x40002CD")]
			Done
		}
	}
}
