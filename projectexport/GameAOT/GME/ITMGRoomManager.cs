using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000B2 RID: 178
	[Token(Token = "0x2000087")]
	public abstract class ITMGRoomManager
	{
		// Token: 0x060005CB RID: 1483 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x2761130", Offset = "0x2760530", VA = "0x182761130")]
		public static ITMGRoomManager GetInstance()
		{
			return null;
		}

		// Token: 0x060005CC RID: 1484
		[Token(Token = "0x60004F2")]
		public abstract int EnableMic(bool enable, string receiverID);

		// Token: 0x060005CD RID: 1485
		[Token(Token = "0x60004F3")]
		public abstract int EnableSpeaker(bool enable, string receiverID);

		// Token: 0x060005CE RID: 1486
		[Token(Token = "0x60004F4")]
		public abstract int EnableAudioCaptureDevice(bool enable, string receiverID);

		// Token: 0x060005CF RID: 1487
		[Token(Token = "0x60004F5")]
		public abstract int EnableAudioPlayDevice(bool enable, string receiverID);

		// Token: 0x060005D0 RID: 1488
		[Token(Token = "0x60004F6")]
		public abstract int EnableAudioSend(bool enable, string receiverID);

		// Token: 0x060005D1 RID: 1489
		[Token(Token = "0x60004F7")]
		public abstract int EnableAudioRecv(bool enable, string receiverID);

		// Token: 0x060005D2 RID: 1490
		[Token(Token = "0x60004F8")]
		public abstract int ForbidUserOperation(bool enable, string receiverID);

		// Token: 0x060005D3 RID: 1491
		[Token(Token = "0x60004F9")]
		public abstract int GetMicState(string receiverID);

		// Token: 0x060005D4 RID: 1492
		[Token(Token = "0x60004FA")]
		public abstract int GetSpeakerState(string receiverID);

		// Token: 0x060005D5 RID: 1493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		protected ITMGRoomManager()
		{
		}
	}
}
