using System;
using Il2CppDummyDll;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x02000176 RID: 374
	[Token(Token = "0x200011E")]
	public sealed class VarInt16 : Variable<short>
	{
		// Token: 0x06000B05 RID: 2821 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009BA")]
		[Address(RVA = "0xEDA190", Offset = "0xED9590", VA = "0x180EDA190")]
		public static implicit operator VarInt16(short value)
		{
			return null;
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x000047D0 File Offset: 0x000029D0
		[Token(Token = "0x60009BB")]
		[Address(RVA = "0xEDA200", Offset = "0xED9600", VA = "0x180EDA200")]
		public static implicit operator short(VarInt16 value)
		{
			return 0;
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BC")]
		[Address(RVA = "0xEDA150", Offset = "0xED9550", VA = "0x180EDA150")]
		public VarInt16()
		{
		}
	}
}
