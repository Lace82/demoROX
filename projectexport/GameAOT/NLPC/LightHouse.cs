using System;
using System.Threading;
using Il2CppDummyDll;

namespace NLPC
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200002F")]
	internal class LightHouse
	{
		// Token: 0x06000301 RID: 769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x2E69310", Offset = "0x2E68710", VA = "0x182E69310")]
		public LightHouse()
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x2E68C10", Offset = "0x2E68010", VA = "0x182E68C10", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x2E691B0", Offset = "0x2E685B0", VA = "0x182E691B0")]
		public void SignalMustPause()
		{
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2E69250", Offset = "0x2E68650", VA = "0x182E69250")]
		public void SignalMustStop()
		{
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2E69110", Offset = "0x2E68510", VA = "0x182E69110")]
		public void SignalMustContinueEveythingIsOk()
		{
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x2E68FC0", Offset = "0x2E683C0", VA = "0x182E68FC0")]
		public void SignalBusy()
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x2E69060", Offset = "0x2E68460", VA = "0x182E69060")]
		public void SignalCustomCommandFlag(LightHouse.EFLAG CommandFlag)
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x2E68DC0", Offset = "0x2E681C0", VA = "0x182E68DC0")]
		public bool IsDangerThere(int dwMilliseconds = 0)
		{
			return default(bool);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x183D120", Offset = "0x183C520", VA = "0x18183D120")]
		public bool waitDanger(int dwMilliseconds)
		{
			return default(bool);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x2E68EA0", Offset = "0x2E682A0", VA = "0x182E68EA0")]
		public bool IsMustPause()
		{
			return default(bool);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1662C00", Offset = "0x1662000", VA = "0x181662C00")]
		public void PauseWaitForSignal()
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x2E68F30", Offset = "0x2E68330", VA = "0x182E68F30")]
		public bool IsMustStop()
		{
			return default(bool);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x2E68E10", Offset = "0x2E68210", VA = "0x182E68E10")]
		public bool IsMustContinue()
		{
			return default(bool);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x2E68D30", Offset = "0x2E68130", VA = "0x182E68D30")]
		public bool IsBusy()
		{
			return default(bool);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x2E68CA0", Offset = "0x2E680A0", VA = "0x182E68CA0")]
		public LightHouse.EFLAG GetCustomCommandFlag()
		{
			return LightHouse.EFLAG.eFlagMustContinueEveythingIsOk;
		}

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x10")]
		private readonly ManualResetEvent mEvent;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x18")]
		private readonly object mutexHere;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x20")]
		private LightHouse.EFLAG mFlag;

		// Token: 0x0200004F RID: 79
		[Token(Token = "0x2000153")]
		public enum EFLAG
		{
			// Token: 0x0400019B RID: 411
			[Token(Token = "0x4000547")]
			eFlagMustContinueEveythingIsOk,
			// Token: 0x0400019C RID: 412
			[Token(Token = "0x4000548")]
			eFlagMustPause,
			// Token: 0x0400019D RID: 413
			[Token(Token = "0x4000549")]
			eFlagMustStop,
			// Token: 0x0400019E RID: 414
			[Token(Token = "0x400054A")]
			eFlagBusy
		}
	}
}
