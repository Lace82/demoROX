using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000B3 RID: 179
	[Token(Token = "0x2000082")]
	internal sealed class WebPlayModeUpdatePackageManifestOperation : UpdatePackageManifestOperation
	{
		// Token: 0x0600036B RID: 875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x3898F70", Offset = "0x3898370", VA = "0x183898F70")]
		internal WebPlayModeUpdatePackageManifestOperation(WebPlayModeImpl impl, string packageVersion, int timeout)
		{
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1818200", Offset = "0x1817600", VA = "0x181818200", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x3898D50", Offset = "0x3898150", VA = "0x183898D50", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x48")]
		private readonly WebPlayModeImpl _impl;

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x50")]
		private readonly string _packageVersion;

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x58")]
		private readonly int _timeout;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x60")]
		private LoadRemoteManifestOperation _loadCacheManifestOp;

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x68")]
		private WebPlayModeUpdatePackageManifestOperation.ESteps _steps;

		// Token: 0x020000B4 RID: 180
		[Token(Token = "0x20000DB")]
		private enum ESteps
		{
			// Token: 0x040002E2 RID: 738
			[Token(Token = "0x400035D")]
			None,
			// Token: 0x040002E3 RID: 739
			[Token(Token = "0x400035E")]
			CheckParams,
			// Token: 0x040002E4 RID: 740
			[Token(Token = "0x400035F")]
			CheckActiveManifest,
			// Token: 0x040002E5 RID: 741
			[Token(Token = "0x4000360")]
			LoadRemoteManifest,
			// Token: 0x040002E6 RID: 742
			[Token(Token = "0x4000361")]
			Done
		}
	}
}
