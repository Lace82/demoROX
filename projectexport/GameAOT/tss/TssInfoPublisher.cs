using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;

namespace tss
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000026")]
	public class TssInfoPublisher
	{
		// Token: 0x060002D5 RID: 725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x38909B0", Offset = "0x388FDB0", VA = "0x1838909B0")]
		private TssInfoPublisher()
		{
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x3890C80", Offset = "0x3890080", VA = "0x183890C80")]
		public static TssInfoPublisher getInstance()
		{
			return null;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x3891160", Offset = "0x3890560", VA = "0x183891160")]
		public void registTssInfoReceiver(TssInfoReceiver receiver)
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x3890A20", Offset = "0x388FE20", VA = "0x183890A20")]
		private void broadcastInfo(int id, string info)
		{
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x3890F00", Offset = "0x3890300", VA = "0x183890F00")]
		private void recvDataThread()
		{
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x3890EA0", Offset = "0x38902A0", VA = "0x183890EA0")]
		private static int openPipe()
		{
			return 0;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x3890C40", Offset = "0x3890040", VA = "0x183890C40")]
		private static void closePipe()
		{
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x3891120", Offset = "0x3890520", VA = "0x183891120")]
		private static string recvPipe()
		{
			return null;
		}

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x40000D8")]
		public const int TSS_INFO_TYPE_DETECT_RESULT = 1;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x40000D9")]
		public const int TSS_INFO_TYPE_HEARTBEAT = 2;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x0")]
		private static TssInfoPublisher mInstance;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object mSingletonLock;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x10")]
		private readonly object padlockReceiver;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x10")]
		private static List<TssInfoReceiver> mReceivers;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x18")]
		private static Thread mTssInfoPublisherThread;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x20")]
		private static bool mTssInfoPublisherThreadStarted;
	}
}
