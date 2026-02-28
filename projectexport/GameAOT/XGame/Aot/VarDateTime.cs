using System;
using Il2CppDummyDll;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x02000172 RID: 370
	[Token(Token = "0x200011A")]
	public sealed class VarDateTime : Variable<DateTime>
	{
		// Token: 0x06000AF9 RID: 2809 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009AE")]
		[Address(RVA = "0xED9DF0", Offset = "0xED91F0", VA = "0x180ED9DF0")]
		public static implicit operator VarDateTime(DateTime value)
		{
			return null;
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00004788 File Offset: 0x00002988
		[Token(Token = "0x60009AF")]
		[Address(RVA = "0xED9DB0", Offset = "0xED91B0", VA = "0x180ED9DB0")]
		public static implicit operator DateTime(VarDateTime value)
		{
			return default(DateTime);
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B0")]
		[Address(RVA = "0xED9D70", Offset = "0xED9170", VA = "0x180ED9D70")]
		public VarDateTime()
		{
		}
	}
}
