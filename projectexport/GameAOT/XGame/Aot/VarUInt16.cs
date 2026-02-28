using System;
using Il2CppDummyDll;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x02000182 RID: 386
	[Token(Token = "0x200012A")]
	public sealed class VarUInt16 : Variable<ushort>
	{
		// Token: 0x06000B27 RID: 2855 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009DC")]
		[Address(RVA = "0xEDAE80", Offset = "0xEDA280", VA = "0x180EDAE80")]
		public static implicit operator VarUInt16(ushort value)
		{
			return null;
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00004878 File Offset: 0x00002A78
		[Token(Token = "0x60009DD")]
		[Address(RVA = "0xEDAEF0", Offset = "0xEDA2F0", VA = "0x180EDAEF0")]
		public static implicit operator ushort(VarUInt16 value)
		{
			return 0;
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009DE")]
		[Address(RVA = "0xEDAE40", Offset = "0xEDA240", VA = "0x180EDAE40")]
		public VarUInt16()
		{
		}
	}
}
