using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x200000E")]
	internal class VerifyTempFileWithThreadOperation : VerifyTempFileOperation
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x12F84B0", Offset = "0x12F78B0", VA = "0x1812F84B0")]
		public VerifyTempFileWithThreadOperation(VerifyTempFileElement element)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1BAF8F0", Offset = "0x1BAECF0", VA = "0x181BAF8F0", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x3895B70", Offset = "0x3894F70", VA = "0x183895B70", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x3895AF0", Offset = "0x3894EF0", VA = "0x183895AF0")]
		private bool BeginVerifyFileWithThread(VerifyTempFileElement element)
		{
			return default(bool);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x3895CB0", Offset = "0x38950B0", VA = "0x183895CB0")]
		private void VerifyInThread(object obj)
		{
		}

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x50")]
		private readonly VerifyTempFileElement _element;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x58")]
		private VerifyTempFileWithThreadOperation.ESteps _steps;

		// Token: 0x02000015 RID: 21
		[Token(Token = "0x20000B0")]
		private enum ESteps
		{
			// Token: 0x04000057 RID: 87
			[Token(Token = "0x4000282")]
			None,
			// Token: 0x04000058 RID: 88
			[Token(Token = "0x4000283")]
			VerifyFile,
			// Token: 0x04000059 RID: 89
			[Token(Token = "0x4000284")]
			Waiting,
			// Token: 0x0400005A RID: 90
			[Token(Token = "0x4000285")]
			Done
		}
	}
}
