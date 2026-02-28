using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x200000D")]
	internal abstract class VerifyTempFileOperation : AsyncOperationBase
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002160 File Offset: 0x00000360
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public EVerifyResult VerifyResult
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x105BC90", Offset = "0x105B090", VA = "0x18105BC90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return EVerifyResult.None;
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x105BEB0", Offset = "0x105B2B0", VA = "0x18105BEB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected set
			{
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x3895A90", Offset = "0x3894E90", VA = "0x183895A90")]
		public static VerifyTempFileOperation CreateOperation(VerifyTempFileElement element)
		{
			return null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002F")]
		[Address(RVA = "0xB9A0F0", Offset = "0xB994F0", VA = "0x180B9A0F0")]
		protected VerifyTempFileOperation()
		{
		}

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private EVerifyResult <VerifyResult>k__BackingField;
	}
}
