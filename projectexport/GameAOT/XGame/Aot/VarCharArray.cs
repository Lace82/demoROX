using System;
using Il2CppDummyDll;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x0200016F RID: 367
	[Token(Token = "0x2000117")]
	public sealed class VarCharArray : Variable<char[]>
	{
		// Token: 0x06000AF0 RID: 2800 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009A5")]
		[Address(RVA = "0xED99D0", Offset = "0xED8DD0", VA = "0x180ED99D0")]
		public static implicit operator VarCharArray(char[] value)
		{
			return null;
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009A6")]
		[Address(RVA = "0xED9A50", Offset = "0xED8E50", VA = "0x180ED9A50")]
		public static implicit operator char[](VarCharArray value)
		{
			return null;
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A7")]
		[Address(RVA = "0xED9990", Offset = "0xED8D90", VA = "0x180ED9990")]
		public VarCharArray()
		{
		}
	}
}
