using System;
using Il2CppDummyDll;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x02000184 RID: 388
	[Token(Token = "0x200012C")]
	public sealed class VarUInt64 : Variable<ulong>
	{
		// Token: 0x06000B2D RID: 2861 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x38927B0", Offset = "0x3891BB0", VA = "0x1838927B0")]
		public static implicit operator VarUInt64(ulong value)
		{
			return null;
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x000048A8 File Offset: 0x00002AA8
		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x3892770", Offset = "0x3891B70", VA = "0x183892770")]
		public static implicit operator ulong(VarUInt64 value)
		{
			return 0UL;
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x3892730", Offset = "0x3891B30", VA = "0x183892730")]
		public VarUInt64()
		{
		}
	}
}
