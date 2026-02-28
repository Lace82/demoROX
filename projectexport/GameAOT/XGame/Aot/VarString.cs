using System;
using Il2CppDummyDll;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x0200017F RID: 383
	[Token(Token = "0x2000127")]
	public sealed class VarString : Variable<string>
	{
		// Token: 0x06000B1E RID: 2846 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009D3")]
		[Address(RVA = "0xEDABC0", Offset = "0xED9FC0", VA = "0x180EDABC0")]
		public static implicit operator VarString(string value)
		{
			return null;
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009D4")]
		[Address(RVA = "0xEDAB80", Offset = "0xED9F80", VA = "0x180EDAB80")]
		public static implicit operator string(VarString value)
		{
			return null;
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D5")]
		[Address(RVA = "0xEDAB40", Offset = "0xED9F40", VA = "0x180EDAB40")]
		public VarString()
		{
		}
	}
}
