using System;
using Il2CppDummyDll;

namespace quicksdk
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200004D")]
	public class ErrorMsg
	{
		// Token: 0x06000391 RID: 913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public ErrorMsg()
		{
		}

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x10")]
		public string errMsg;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x18")]
		public int code;
	}
}
