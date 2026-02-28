using System;
using Il2CppDummyDll;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x02000178 RID: 376
	[Token(Token = "0x2000120")]
	public sealed class VarInt64 : Variable<long>
	{
		// Token: 0x06000B0B RID: 2827 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009C0")]
		[Address(RVA = "0xEDA370", Offset = "0xED9770", VA = "0x180EDA370")]
		public static implicit operator VarInt64(long value)
		{
			return null;
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00004800 File Offset: 0x00002A00
		[Token(Token = "0x60009C1")]
		[Address(RVA = "0xEDA3E0", Offset = "0xED97E0", VA = "0x180EDA3E0")]
		public static implicit operator long(VarInt64 value)
		{
			return 0L;
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C2")]
		[Address(RVA = "0xEDA330", Offset = "0xED9730", VA = "0x180EDA330")]
		public VarInt64()
		{
		}
	}
}
