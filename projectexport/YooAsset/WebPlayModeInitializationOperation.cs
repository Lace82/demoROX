using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200008D RID: 141
	[Token(Token = "0x200006B")]
	internal sealed class WebPlayModeInitializationOperation : InitializationOperation
	{
		// Token: 0x060002F5 RID: 757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x3898C90", Offset = "0x3898090", VA = "0x183898C90")]
		internal WebPlayModeInitializationOperation(WebPlayModeImpl impl)
		{
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1818200", Offset = "0x1817600", VA = "0x181818200", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x38989E0", Offset = "0x3897DE0", VA = "0x1838989E0", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x50")]
		private readonly WebPlayModeImpl _impl;

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x58")]
		private QueryBuildinPackageVersionOperation _queryWebPackageVersionOp;

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x60")]
		private LoadBuildinManifestOperation _loadWebManifestOp;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x68")]
		private WebPlayModeInitializationOperation.ESteps _steps;

		// Token: 0x0200008E RID: 142
		[Token(Token = "0x20000CC")]
		private enum ESteps
		{
			// Token: 0x04000229 RID: 553
			[Token(Token = "0x4000309")]
			None,
			// Token: 0x0400022A RID: 554
			[Token(Token = "0x400030A")]
			QueryWebPackageVersion,
			// Token: 0x0400022B RID: 555
			[Token(Token = "0x400030B")]
			LoadWebManifest,
			// Token: 0x0400022C RID: 556
			[Token(Token = "0x400030C")]
			Done
		}
	}
}
