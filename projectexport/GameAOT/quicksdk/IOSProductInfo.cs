using System;
using Il2CppDummyDll;

namespace quicksdk
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200004C")]
	public class IOSProductInfo
	{
		// Token: 0x06000390 RID: 912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public IOSProductInfo()
		{
		}

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x10")]
		public string productId;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x18")]
		public string productName;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x20")]
		public string productDesc;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x28")]
		public string price;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x30")]
		public string total;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x38")]
		public string extras_params;
	}
}
