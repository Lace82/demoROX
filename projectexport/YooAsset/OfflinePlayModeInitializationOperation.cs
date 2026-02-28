using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000069")]
	internal sealed class OfflinePlayModeInitializationOperation : InitializationOperation
	{
		// Token: 0x060002EF RID: 751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x12F84B0", Offset = "0x12F78B0", VA = "0x1812F84B0")]
		internal OfflinePlayModeInitializationOperation(OfflinePlayModeImpl impl)
		{
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1BA8410", Offset = "0x1BA7810", VA = "0x181BA8410", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1BAA450", Offset = "0x1BA9850", VA = "0x181BAA450", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x50")]
		private readonly OfflinePlayModeImpl _impl;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x58")]
		private QueryBuildinPackageVersionOperation _queryBuildinPackageVersionOp;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x60")]
		private LoadBuildinManifestOperation _loadBuildinManifestOp;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x68")]
		private PackageCachingOperation _cachingOperation;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x70")]
		private OfflinePlayModeInitializationOperation.ESteps _steps;

		// Token: 0x0200008A RID: 138
		[Token(Token = "0x20000CA")]
		private enum ESteps
		{
			// Token: 0x0400020D RID: 525
			[Token(Token = "0x40002F9")]
			None,
			// Token: 0x0400020E RID: 526
			[Token(Token = "0x40002FA")]
			QueryBuildinPackageVersion,
			// Token: 0x0400020F RID: 527
			[Token(Token = "0x40002FB")]
			LoadBuildinManifest,
			// Token: 0x04000210 RID: 528
			[Token(Token = "0x40002FC")]
			PackageCaching,
			// Token: 0x04000211 RID: 529
			[Token(Token = "0x40002FD")]
			Done
		}
	}
}
