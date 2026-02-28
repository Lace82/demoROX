using System;
using Il2CppDummyDll;

namespace quicksdk
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000050")]
	public class PayResult
	{
		// Token: 0x06000394 RID: 916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public PayResult()
		{
		}

		// Token: 0x04000262 RID: 610
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x10")]
		public string orderId;

		// Token: 0x04000263 RID: 611
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x18")]
		public string extraParam;
	}
}
