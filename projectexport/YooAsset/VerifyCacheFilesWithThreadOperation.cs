using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000B")]
	internal class VerifyCacheFilesWithThreadOperation : VerifyCacheFilesOperation
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x3895610", Offset = "0x3894A10", VA = "0x183895610")]
		public VerifyCacheFilesWithThreadOperation(CacheManager cache, List<VerifyCacheFileElement> elements)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x3895090", Offset = "0x3894490", VA = "0x183895090", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x38950C0", Offset = "0x38944C0", VA = "0x1838950C0", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x3895060", Offset = "0x3894460", VA = "0x183895060")]
		private float GetProgress()
		{
			return 0f;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x3894FE0", Offset = "0x38943E0", VA = "0x183894FE0")]
		private bool BeginVerifyFileWithThread(VerifyCacheFileElement element)
		{
			return default(bool);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x38954F0", Offset = "0x38948F0", VA = "0x1838954F0")]
		private void VerifyInThread(object obj)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x3895360", Offset = "0x3894760", VA = "0x183895360")]
		private void VerifyCallback(object obj)
		{
		}

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x48")]
		private readonly ThreadSyncContext _syncContext;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x50")]
		private readonly CacheManager _cache;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x58")]
		private List<VerifyCacheFileElement> _waitingList;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x60")]
		private List<VerifyCacheFileElement> _verifyingList;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x68")]
		private int _verifyMaxNum;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x6C")]
		private int _verifyTotalCount;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x70")]
		private float _verifyStartTime;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x74")]
		private int _succeedCount;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x78")]
		private int _failedCount;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x7C")]
		private VerifyCacheFilesWithThreadOperation.ESteps _steps;

		// Token: 0x02000010 RID: 16
		[Token(Token = "0x20000AE")]
		private enum ESteps
		{
			// Token: 0x04000041 RID: 65
			[Token(Token = "0x4000278")]
			None,
			// Token: 0x04000042 RID: 66
			[Token(Token = "0x4000279")]
			InitVerify,
			// Token: 0x04000043 RID: 67
			[Token(Token = "0x400027A")]
			UpdateVerify,
			// Token: 0x04000044 RID: 68
			[Token(Token = "0x400027B")]
			Done
		}
	}
}
