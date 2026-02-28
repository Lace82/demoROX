using System;
using Il2CppDummyDll;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x02000177 RID: 375
	[Token(Token = "0x200011F")]
	public sealed class VarInt32 : Variable<int>
	{
		// Token: 0x06000B08 RID: 2824 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009BD")]
		[Address(RVA = "0xEDA280", Offset = "0xED9680", VA = "0x180EDA280")]
		public static implicit operator VarInt32(int value)
		{
			return null;
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x000047E8 File Offset: 0x000029E8
		[Token(Token = "0x60009BE")]
		[Address(RVA = "0xEDA2F0", Offset = "0xED96F0", VA = "0x180EDA2F0")]
		public static implicit operator int(VarInt32 value)
		{
			return 0;
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BF")]
		[Address(RVA = "0xEDA240", Offset = "0xED9640", VA = "0x180EDA240")]
		public VarInt32()
		{
		}
	}
}
