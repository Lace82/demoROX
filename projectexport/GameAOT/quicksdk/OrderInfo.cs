using System;
using Il2CppDummyDll;

namespace quicksdk
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x2000049")]
	public class OrderInfo
	{
		// Token: 0x0600038D RID: 909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public OrderInfo()
		{
		}

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x10")]
		public string goodsID;

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x18")]
		public string skuType;

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x20")]
		public string goodsDesc;

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x28")]
		public string gameOrderNo;

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x30")]
		public string cpOrderID;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x38")]
		public string extrasParams;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x40")]
		public double amount;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x48")]
		public string currency;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x50")]
		public string callBackUrl;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x58")]
		public string receiptString;
	}
}
