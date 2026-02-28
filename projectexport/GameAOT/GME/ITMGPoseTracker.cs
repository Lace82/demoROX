using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000B4 RID: 180
	[Token(Token = "0x2000089")]
	public abstract class ITMGPoseTracker
	{
		// Token: 0x060005DC RID: 1500
		[Token(Token = "0x6000502")]
		public abstract int Destroy();

		// Token: 0x060005DD RID: 1501
		[Token(Token = "0x6000503")]
		public abstract int SetRenderEngine(string renderEngine);

		// Token: 0x060005DE RID: 1502
		[Token(Token = "0x6000504")]
		public abstract TMGPoseTrackerPoseInfo TrackPose(byte[] data, ITMG_IMG_FORMAT format, int with, int height, int stride, ITMG_IMG_ORIENTATION rotate);

		// Token: 0x060005DF RID: 1503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		protected ITMGPoseTracker()
		{
		}
	}
}
