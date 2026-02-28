using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000A7 RID: 167
	[Token(Token = "0x200007C")]
	public struct TMGFaceTrackerFaceInfo
	{
		// Token: 0x04000327 RID: 807
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x0")]
		public float[] faceShap;

		// Token: 0x04000328 RID: 808
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x8")]
		public float pitch;

		// Token: 0x04000329 RID: 809
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0xC")]
		public float yaw;

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x10")]
		public float roll;
	}
}
