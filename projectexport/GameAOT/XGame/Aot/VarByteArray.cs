using System;
using Il2CppDummyDll;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x0200016D RID: 365
	[Token(Token = "0x2000115")]
	public sealed class VarByteArray : Variable<byte[]>
	{
		// Token: 0x06000AEA RID: 2794 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600099F")]
		[Address(RVA = "0xED9820", Offset = "0xED8C20", VA = "0x180ED9820")]
		public static implicit operator VarByteArray(byte[] value)
		{
			return null;
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009A0")]
		[Address(RVA = "0xED97E0", Offset = "0xED8BE0", VA = "0x180ED97E0")]
		public static implicit operator byte[](VarByteArray value)
		{
			return null;
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A1")]
		[Address(RVA = "0xED97A0", Offset = "0xED8BA0", VA = "0x180ED97A0")]
		public VarByteArray()
		{
		}
	}
}
