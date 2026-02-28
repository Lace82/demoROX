using System;
using Il2CppDummyDll;
using LitJson;

namespace Code.GameAot.SDK
{
	// Token: 0x0200008D RID: 141
	[Token(Token = "0x2000063")]
	public class LoginResultData
	{
		// Token: 0x06000474 RID: 1140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public LoginResultData()
		{
		}

		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x10")]
		public int code;

		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x18")]
		public JsonData json;
	}
}
