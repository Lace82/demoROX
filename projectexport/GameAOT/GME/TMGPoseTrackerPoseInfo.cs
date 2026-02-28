using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000AA RID: 170
	[Token(Token = "0x200007F")]
	public struct TMGPoseTrackerPoseInfo
	{
		// Token: 0x0400032D RID: 813
		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x0")]
		public bool hasBody;

		// Token: 0x0400032E RID: 814
		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x8")]
		public PoseLM[] lm;

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x10")]
		public float[] bbox;

		// Token: 0x04000330 RID: 816
		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x18")]
		public PoseEuler[] euler;
	}
}
