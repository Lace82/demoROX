using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x200007B")]
	public struct TMGFaceTrackerParam
	{
		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x0")]
		public int minFaceSize;

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x4")]
		public int maxFaceSize;

		// Token: 0x04000323 RID: 803
		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x8")]
		public int biggerFaceMode;

		// Token: 0x04000324 RID: 804
		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0xC")]
		public bool nonSquareRect;

		// Token: 0x04000325 RID: 805
		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x10")]
		public float threshold;

		// Token: 0x04000326 RID: 806
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x14")]
		public int detectInterval;
	}
}
