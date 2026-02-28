using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000E2 RID: 226
	[Token(Token = "0x20000B7")]
	public class QAVRoomManager : ITMGRoomManager
	{
		// Token: 0x0600085A RID: 2138 RVA: 0x00003DB0 File Offset: 0x00001FB0
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x2E78EB0", Offset = "0x2E782B0", VA = "0x182E78EB0", Slot = "4")]
		public override int EnableMic(bool enable, string receiverID)
		{
			return 0;
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[Token(Token = "0x6000781")]
		[Address(RVA = "0x2E78FA0", Offset = "0x2E783A0", VA = "0x182E78FA0", Slot = "5")]
		public override int EnableSpeaker(bool enable, string receiverID)
		{
			return 0;
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x2E78AF0", Offset = "0x2E77EF0", VA = "0x182E78AF0", Slot = "6")]
		public override int EnableAudioCaptureDevice(bool enable, string receiverID)
		{
			return 0;
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00003DF8 File Offset: 0x00001FF8
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x2E78BE0", Offset = "0x2E77FE0", VA = "0x182E78BE0", Slot = "7")]
		public override int EnableAudioPlayDevice(bool enable, string receiverID)
		{
			return 0;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00003E10 File Offset: 0x00002010
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x2E78DC0", Offset = "0x2E781C0", VA = "0x182E78DC0", Slot = "8")]
		public override int EnableAudioSend(bool enable, string receiverID)
		{
			return 0;
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00003E28 File Offset: 0x00002028
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x2E78CD0", Offset = "0x2E780D0", VA = "0x182E78CD0", Slot = "9")]
		public override int EnableAudioRecv(bool enable, string receiverID)
		{
			return 0;
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00003E40 File Offset: 0x00002040
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x2E79090", Offset = "0x2E78490", VA = "0x182E79090", Slot = "10")]
		public override int ForbidUserOperation(bool enable, string receiverID)
		{
			return 0;
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00003E58 File Offset: 0x00002058
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x2E792B0", Offset = "0x2E786B0", VA = "0x182E792B0", Slot = "11")]
		public override int GetMicState(string receiverID)
		{
			return 0;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00003E70 File Offset: 0x00002070
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x2E79390", Offset = "0x2E78790", VA = "0x182E79390", Slot = "12")]
		public override int GetSpeakerState(string receiverID)
		{
			return 0;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x2E794D0", Offset = "0x2E788D0", VA = "0x182E794D0")]
		public QAVRoomManager()
		{
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x14C58E0", Offset = "0x14C4CE0", VA = "0x1814C58E0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x2E79180", Offset = "0x2E78580", VA = "0x182E79180")]
		public new static QAVRoomManager GetInstance()
		{
			return null;
		}

		// Token: 0x0400040E RID: 1038
		[Token(Token = "0x4000350")]
		[FieldOffset(Offset = "0x0")]
		private static QAVRoomManager sInstance;

		// Token: 0x0400040F RID: 1039
		[Token(Token = "0x4000351")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object sLock;
	}
}
