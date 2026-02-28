using System;
using Il2CppDummyDll;

namespace NLPC
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x2000048")]
	internal class StatusChecker
	{
		// Token: 0x0600037E RID: 894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x2E7CA00", Offset = "0x2E7BE00", VA = "0x182E7CA00")]
		private StatusChecker()
		{
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x2E7C8A0", Offset = "0x2E7BCA0", VA = "0x182E7C8A0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700002A")]
		public static StatusChecker getInstance
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x2E7D270", Offset = "0x2E7C670", VA = "0x182E7D270")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x2E7D410", Offset = "0x2E7C810", VA = "0x182E7D410")]
		public bool install(NEPStatusCallback callback, int intervalSeconds, bool callbackOnlyAbnormal, uint pid)
		{
			return default(bool);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x2E7E120", Offset = "0x2E7D520", VA = "0x182E7E120")]
		public bool uninstall()
		{
			return default(bool);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x2E7D1F0", Offset = "0x2E7C5F0", VA = "0x182E7D1F0")]
		public NEPSTATUS getStatus()
		{
			return NEPSTATUS.eNEP_Status_Normal;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x2E7DDF0", Offset = "0x2E7D1F0", VA = "0x182E7DDF0")]
		public void threadProcCheckStatus()
		{
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x2E7CC80", Offset = "0x2E7C080", VA = "0x182E7CC80")]
		private NEPSTATUS checkStatus()
		{
			return NEPSTATUS.eNEP_Status_Normal;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x2E7D920", Offset = "0x2E7CD20", VA = "0x182E7D920")]
		private bool isCoreFileExist()
		{
			return default(bool);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x2E7D9E0", Offset = "0x2E7CDE0", VA = "0x182E7D9E0")]
		private bool isCoreFileLoaded()
		{
			return default(bool);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x2E7DA50", Offset = "0x2E7CE50", VA = "0x182E7DA50")]
		private bool isCoreThreadAlive()
		{
			return default(bool);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x2E7DC50", Offset = "0x2E7D050", VA = "0x182E7DC50")]
		private bool isNetworkNormal()
		{
			return default(bool);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x2E7DF70", Offset = "0x2E7D370", VA = "0x182E7DF70")]
		private bool touch()
		{
			return default(bool);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x2E7D8A0", Offset = "0x2E7CCA0", VA = "0x182E7D8A0")]
		private bool isAppWillExit(int dwMilliseconds = 0)
		{
			return default(bool);
		}

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x0")]
		private static StatusChecker instance;

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object locker;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x10")]
		private readonly object m_csInstall;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x18")]
		private readonly object m_csCheckStatus;

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x20")]
		public string mCoreFilepath;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x28")]
		public string mCoreFilename;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x30")]
		public uint mCoreProcessId;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x34")]
		public uint mCoreThreadId;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x38")]
		public MyAtomic<NEPStatusCallback> mStatusCallback;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x40")]
		public int mIntervalSeconds;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x48")]
		public MyAtomic<bool> isCallbackOnlyAbnormal;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x50")]
		public MyAtomic<bool> isInstalled;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x58")]
		public MyAtomic<bool> isCheckThreadStart;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x60")]
		public LightHouse mLightHouse;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x68")]
		private int hCheckThread;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x10")]
		private static bool isPathChecked;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x18")]
		private static long initTime;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x20")]
		private static bool isInitPacket;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int HEARTBEAT_PACKET_LENGTH;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x28")]
		private static readonly byte[] packetBuffer;
	}
}
