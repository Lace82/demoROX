using System;
using Il2CppDummyDll;

namespace quicksdk
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200004B")]
	public class GoogleSku
	{
		// Token: 0x0600038F RID: 911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public GoogleSku()
		{
		}

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x10")]
		public string productId;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x18")]
		public string type;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x20")]
		public string title;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x30")]
		public string price;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x38")]
		public long price_amount_micros;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x40")]
		public string price_currency_code;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x48")]
		public string description;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x50")]
		public string skuDetailsToken;
	}
}
