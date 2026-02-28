using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200006A")]
	internal sealed class HostPlayModeInitializationOperation : InitializationOperation
	{
		// Token: 0x060002F2 RID: 754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x12F84B0", Offset = "0x12F78B0", VA = "0x1812F84B0")]
		internal HostPlayModeInitializationOperation(HostPlayModeImpl impl)
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1BA5DD0", Offset = "0x1BA51D0", VA = "0x181BA5DD0", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1BA5DE0", Offset = "0x1BA51E0", VA = "0x181BA5DE0", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x50")]
		private readonly HostPlayModeImpl _impl;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x58")]
		private QueryBuildinPackageVersionOperation _queryBuildinPackageVersionOp;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x60")]
		private QueryCachePackageVersionOperation _queryCachePackageVersionOp;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x68")]
		private UnpackBuildinManifestOperation _unpackBuildinManifestOp;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x70")]
		private LoadBuildinManifestOperation _loadBuildinManifestOp;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x78")]
		private LoadCacheManifestOperation _loadCacheManifestOp;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x80")]
		private PackageCachingOperation _cachingOperation;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x88")]
		private HostPlayModeInitializationOperation.ESteps _steps;

		// Token: 0x0200008C RID: 140
		[Token(Token = "0x20000CB")]
		private enum ESteps
		{
			// Token: 0x0400021B RID: 539
			[Token(Token = "0x40002FF")]
			None,
			// Token: 0x0400021C RID: 540
			[Token(Token = "0x4000300")]
			CheckAppFootPrint,
			// Token: 0x0400021D RID: 541
			[Token(Token = "0x4000301")]
			QueryCachePackageVersion,
			// Token: 0x0400021E RID: 542
			[Token(Token = "0x4000302")]
			TryLoadCacheManifest,
			// Token: 0x0400021F RID: 543
			[Token(Token = "0x4000303")]
			QueryBuildinPackageVersion,
			// Token: 0x04000220 RID: 544
			[Token(Token = "0x4000304")]
			UnpackBuildinManifest,
			// Token: 0x04000221 RID: 545
			[Token(Token = "0x4000305")]
			LoadBuildinManifest,
			// Token: 0x04000222 RID: 546
			[Token(Token = "0x4000306")]
			PackageCaching,
			// Token: 0x04000223 RID: 547
			[Token(Token = "0x4000307")]
			Done
		}
	}
}
