using System;
using Il2CppDummyDll;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x02000183 RID: 387
	[Token(Token = "0x200012B")]
	public sealed class VarUInt32 : Variable<uint>
	{
		// Token: 0x06000B2A RID: 2858 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009DF")]
		[Address(RVA = "0xEDAFB0", Offset = "0xEDA3B0", VA = "0x180EDAFB0")]
		public static implicit operator VarUInt32(uint value)
		{
			return null;
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00004890 File Offset: 0x00002A90
		[Token(Token = "0x60009E0")]
		[Address(RVA = "0xEDAF70", Offset = "0xEDA370", VA = "0x180EDAF70")]
		public static implicit operator uint(VarUInt32 value)
		{
			return 0U;
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E1")]
		[Address(RVA = "0xEDAF30", Offset = "0xEDA330", VA = "0x180EDAF30")]
		public VarUInt32()
		{
		}
	}
}
