using System;
using Il2CppDummyDll;

namespace quicksdk
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000051")]
	public class GoodsInfo
	{
		// Token: 0x06000395 RID: 917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public GoodsInfo()
		{
		}

		// Token: 0x04000264 RID: 612
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x10")]
		public string Id;

		// Token: 0x04000265 RID: 613
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		// Token: 0x04000266 RID: 614
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x20")]
		public string Desc;

		// Token: 0x04000267 RID: 615
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x28")]
		public string Price;

		// Token: 0x04000268 RID: 616
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x30")]
		public string PriceDes;
	}
}
