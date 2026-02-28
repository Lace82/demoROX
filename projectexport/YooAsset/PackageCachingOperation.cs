using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000010")]
	internal class PackageCachingOperation : AsyncOperationBase
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1BA82D0", Offset = "0x1BA76D0", VA = "0x181BA82D0")]
		public PackageCachingOperation(PersistentManager persistent, CacheManager cache)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1818200", Offset = "0x1817600", VA = "0x181818200", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1BABAC0", Offset = "0x1BAAEC0", VA = "0x181BABAC0", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x48")]
		private readonly PersistentManager _persistent;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x50")]
		private readonly CacheManager _cache;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x58")]
		private FindCacheFilesOperation _findCacheFilesOp;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x60")]
		private VerifyCacheFilesOperation _verifyCacheFilesOp;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x68")]
		private PackageCachingOperation.ESteps _steps;

		// Token: 0x02000019 RID: 25
		[Token(Token = "0x20000B2")]
		private enum ESteps
		{
			// Token: 0x04000067 RID: 103
			[Token(Token = "0x400028B")]
			None,
			// Token: 0x04000068 RID: 104
			[Token(Token = "0x400028C")]
			FindCacheFiles,
			// Token: 0x04000069 RID: 105
			[Token(Token = "0x400028D")]
			VerifyCacheFiles,
			// Token: 0x0400006A RID: 106
			[Token(Token = "0x400028E")]
			Done
		}
	}
}
