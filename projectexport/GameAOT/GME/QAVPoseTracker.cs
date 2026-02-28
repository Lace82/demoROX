using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000E4 RID: 228
	[Token(Token = "0x20000B9")]
	public class QAVPoseTracker : ITMGPoseTracker
	{
		// Token: 0x0600086D RID: 2157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x2E78490", Offset = "0x2E77890", VA = "0x182E78490")]
		public QAVPoseTracker(string bodyModelPath, string bodyModelBinPath, string poseModelPath, string poseModelBinPath, string smootherModePath, string smootherModeBinPath)
		{
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00003ED0 File Offset: 0x000020D0
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x2E78180", Offset = "0x2E77580", VA = "0x182E78180", Slot = "4")]
		public override int Destroy()
		{
			return 0;
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00003EE8 File Offset: 0x000020E8
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x2E78240", Offset = "0x2E77640", VA = "0x182E78240", Slot = "5")]
		public override int SetRenderEngine(string renderEngine)
		{
			return 0;
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00003F00 File Offset: 0x00002100
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x2E78320", Offset = "0x2E77720", VA = "0x182E78320", Slot = "6")]
		public override TMGPoseTrackerPoseInfo TrackPose(byte[] data, ITMG_IMG_FORMAT format, int with, int height, int stride, ITMG_IMG_ORIENTATION rotate)
		{
			return default(TMGPoseTrackerPoseInfo);
		}

		// Token: 0x04000411 RID: 1041
		[Token(Token = "0x4000353")]
		[FieldOffset(Offset = "0x10")]
		private readonly IntPtr _nativeHandle;
	}
}
