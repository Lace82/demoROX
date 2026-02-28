using System;
using Il2CppDummyDll;

namespace quicksdk
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x200004E")]
	public class UserInfo : ErrorMsg
	{
		// Token: 0x06000392 RID: 914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public UserInfo()
		{
		}

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x20")]
		public string uid;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x28")]
		public string userName;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x30")]
		public string token;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x38")]
		public string openType;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x40")]
		public bool isGuest;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x44")]
		public int loginType;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x48")]
		public bool isNewUser;
	}
}
