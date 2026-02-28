using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x200000C")]
	internal class VerifyCacheFilesWithoutThreadOperation : VerifyCacheFilesOperation
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1BA82D0", Offset = "0x1BA76D0", VA = "0x181BA82D0")]
		public VerifyCacheFilesWithoutThreadOperation(CacheManager cache, List<VerifyCacheFileElement> elements)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x3895850", Offset = "0x3894C50", VA = "0x183895850", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x3895880", Offset = "0x3894C80", VA = "0x183895880", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x3895820", Offset = "0x3894C20", VA = "0x183895820")]
		private float GetProgress()
		{
			return 0f;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x38956B0", Offset = "0x3894AB0", VA = "0x1838956B0")]
		private void BeginVerifyFileWithoutThread(VerifyCacheFileElement element)
		{
		}

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x48")]
		private readonly CacheManager _cache;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x50")]
		private List<VerifyCacheFileElement> _waitingList;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x58")]
		private List<VerifyCacheFileElement> _verifyingList;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x60")]
		private int _verifyMaxNum;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x64")]
		private int _verifyTotalCount;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x68")]
		private float _verifyStartTime;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x6C")]
		private int _succeedCount;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x70")]
		private int _failedCount;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x74")]
		private VerifyCacheFilesWithoutThreadOperation.ESteps _steps;

		// Token: 0x02000012 RID: 18
		[Token(Token = "0x20000AF")]
		private enum ESteps
		{
			// Token: 0x0400004F RID: 79
			[Token(Token = "0x400027D")]
			None,
			// Token: 0x04000050 RID: 80
			[Token(Token = "0x400027E")]
			InitVerify,
			// Token: 0x04000051 RID: 81
			[Token(Token = "0x400027F")]
			UpdateVerify,
			// Token: 0x04000052 RID: 82
			[Token(Token = "0x4000280")]
			Done
		}
	}
}
