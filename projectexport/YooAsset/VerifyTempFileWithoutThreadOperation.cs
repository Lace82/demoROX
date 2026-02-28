using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x200000F")]
	internal class VerifyTempFileWithoutThreadOperation : VerifyTempFileOperation
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x12F84B0", Offset = "0x12F78B0", VA = "0x1812F84B0")]
		public VerifyTempFileWithoutThreadOperation(VerifyTempFileElement element)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1BAF8F0", Offset = "0x1BAECF0", VA = "0x181BAF8F0", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x3895D50", Offset = "0x3895150", VA = "0x183895D50", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x50")]
		private readonly VerifyTempFileElement _element;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x58")]
		private VerifyTempFileWithoutThreadOperation.ESteps _steps;

		// Token: 0x02000017 RID: 23
		[Token(Token = "0x20000B1")]
		private enum ESteps
		{
			// Token: 0x0400005E RID: 94
			[Token(Token = "0x4000287")]
			None,
			// Token: 0x0400005F RID: 95
			[Token(Token = "0x4000288")]
			VerifyFile,
			// Token: 0x04000060 RID: 96
			[Token(Token = "0x4000289")]
			Done
		}
	}
}
