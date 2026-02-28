using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000B8")]
	public class QAVFaceTracker : ITMGFaceTracker
	{
		// Token: 0x06000867 RID: 2151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x2E6CC10", Offset = "0x2E6C010", VA = "0x182E6CC10")]
		public QAVFaceTracker(string modelDirPath, string configFileName)
		{
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00003E88 File Offset: 0x00002088
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x2E6C3B0", Offset = "0x2E6B7B0", VA = "0x182E6C3B0", Slot = "4")]
		public override int Destroy()
		{
			return 0;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00003EA0 File Offset: 0x000020A0
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x2E6C620", Offset = "0x2E6BA20", VA = "0x182E6C620", Slot = "5")]
		public override int Reset()
		{
			return 0;
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00003EB8 File Offset: 0x000020B8
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x2E6C470", Offset = "0x2E6B870", VA = "0x182E6C470", Slot = "6")]
		public override TMGFaceTrackerParam GetParam()
		{
			return default(TMGFaceTrackerParam);
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x2E6C6E0", Offset = "0x2E6BAE0", VA = "0x182E6C6E0", Slot = "7")]
		public override void SetParam(TMGFaceTrackerParam param)
		{
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x2E6C850", Offset = "0x2E6BC50", VA = "0x182E6C850", Slot = "8")]
		public override TMGFaceTrackerFaceInfo[] TrackFace(byte[] data, ITMG_IMG_FORMAT format, int with, int height, int stride, ITMG_IMG_ORIENTATION rotate)
		{
			return null;
		}

		// Token: 0x04000410 RID: 1040
		[Token(Token = "0x4000352")]
		[FieldOffset(Offset = "0x10")]
		private readonly IntPtr _nativeHandle;
	}
}
