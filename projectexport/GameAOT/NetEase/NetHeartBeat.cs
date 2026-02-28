using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;

namespace NetEase
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x200002A")]
	public class NetHeartBeat
	{
		// Token: 0x060002ED RID: 749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1D323F0", Offset = "0x1D317F0", VA = "0x181D323F0")]
		private NetHeartBeat()
		{
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1D326B0", Offset = "0x1D31AB0", VA = "0x181D326B0")]
		public static NetHeartBeat getInstance()
		{
			return null;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1D32BA0", Offset = "0x1D31FA0", VA = "0x181D32BA0")]
		public void registInfoReceiver(InfoReceiver receiver)
		{
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1D32460", Offset = "0x1D31860", VA = "0x181D32460")]
		private void callResult(int id, string info)
		{
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1D328D0", Offset = "0x1D31CD0", VA = "0x181D328D0")]
		private void recvDataThread()
		{
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1D32680", Offset = "0x1D31A80", VA = "0x181D32680")]
		private static string openPipe()
		{
			return null;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1D32680", Offset = "0x1D31A80", VA = "0x181D32680")]
		private static string recvPipe()
		{
			return null;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1D32680", Offset = "0x1D31A80", VA = "0x181D32680")]
		private static string closePipe()
		{
			return null;
		}

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x40000E5")]
		public const int INFO_TYPE_HEARTBEAT = 1;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x40000E6")]
		public const int INFO_TYPE_ENC_HEARTBEAT = 2;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x40000E7")]
		public const int INFO_TYPE_CHEATINFO = 3;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x0")]
		private static NetHeartBeat mInstance;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object mSingletonLock;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x10")]
		private readonly object padlockReceiver;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x10")]
		private static readonly List<InfoReceiver> mReceivers;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x18")]
		private static Thread mInfoPublisherThread;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x20")]
		private static bool thread_running;
	}
}
