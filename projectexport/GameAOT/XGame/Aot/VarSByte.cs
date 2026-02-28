using System;
using Il2CppDummyDll;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x0200017D RID: 381
	[Token(Token = "0x2000125")]
	public sealed class VarSByte : Variable<sbyte>
	{
		// Token: 0x06000B18 RID: 2840 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009CD")]
		[Address(RVA = "0xEDA9E0", Offset = "0xED9DE0", VA = "0x180EDA9E0")]
		public static implicit operator VarSByte(sbyte value)
		{
			return null;
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00004848 File Offset: 0x00002A48
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0xEDA9A0", Offset = "0xED9DA0", VA = "0x180EDA9A0")]
		public static implicit operator sbyte(VarSByte value)
		{
			return 0;
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CF")]
		[Address(RVA = "0xEDA960", Offset = "0xED9D60", VA = "0x180EDA960")]
		public VarSByte()
		{
		}
	}
}
