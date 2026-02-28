using System;
using Il2CppDummyDll;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x02000173 RID: 371
	[Token(Token = "0x200011B")]
	public sealed class VarDecimal : Variable<decimal>
	{
		// Token: 0x06000AFC RID: 2812 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009B1")]
		[Address(RVA = "0xED9EA0", Offset = "0xED92A0", VA = "0x180ED9EA0")]
		public static implicit operator VarDecimal(decimal value)
		{
			return null;
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x000047A0 File Offset: 0x000029A0
		[Token(Token = "0x60009B2")]
		[Address(RVA = "0xED9F10", Offset = "0xED9310", VA = "0x180ED9F10")]
		public static implicit operator decimal(VarDecimal value)
		{
			return 0m;
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B3")]
		[Address(RVA = "0xED9E60", Offset = "0xED9260", VA = "0x180ED9E60")]
		public VarDecimal()
		{
		}
	}
}
