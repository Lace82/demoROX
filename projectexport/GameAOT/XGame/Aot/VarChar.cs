using System;
using Il2CppDummyDll;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x0200016E RID: 366
	[Token(Token = "0x2000116")]
	public sealed class VarChar : Variable<char>
	{
		// Token: 0x06000AED RID: 2797 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009A2")]
		[Address(RVA = "0xED9B10", Offset = "0xED8F10", VA = "0x180ED9B10")]
		public static implicit operator VarChar(char value)
		{
			return null;
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00004740 File Offset: 0x00002940
		[Token(Token = "0x60009A3")]
		[Address(RVA = "0xED9AD0", Offset = "0xED8ED0", VA = "0x180ED9AD0")]
		public static implicit operator char(VarChar value)
		{
			return '\0';
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A4")]
		[Address(RVA = "0xED9A90", Offset = "0xED8E90", VA = "0x180ED9A90")]
		public VarChar()
		{
		}
	}
}
