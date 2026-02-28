using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000B3 RID: 179
	[Token(Token = "0x2000088")]
	public abstract class ITMGFaceTracker
	{
		// Token: 0x060005D6 RID: 1494
		[Token(Token = "0x60004FC")]
		public abstract int Destroy();

		// Token: 0x060005D7 RID: 1495
		[Token(Token = "0x60004FD")]
		public abstract int Reset();

		// Token: 0x060005D8 RID: 1496
		[Token(Token = "0x60004FE")]
		public abstract TMGFaceTrackerParam GetParam();

		// Token: 0x060005D9 RID: 1497
		[Token(Token = "0x60004FF")]
		public abstract void SetParam(TMGFaceTrackerParam param);

		// Token: 0x060005DA RID: 1498
		[Token(Token = "0x6000500")]
		public abstract TMGFaceTrackerFaceInfo[] TrackFace(byte[] data, ITMG_IMG_FORMAT format, int with, int height, int stride, ITMG_IMG_ORIENTATION rotate);

		// Token: 0x060005DB RID: 1499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		protected ITMGFaceTracker()
		{
		}
	}
}
