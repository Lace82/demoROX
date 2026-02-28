using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace NLPC
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000030")]
	internal class GuardClient : PipeGuard
	{
		// Token: 0x06000310 RID: 784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x2E65510", Offset = "0x2E64910", VA = "0x182E65510")]
		private GuardClient()
		{
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000311 RID: 785 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000028")]
		public static GuardClient getInstance
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x2E65890", Offset = "0x2E64C90", VA = "0x182E65890")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600026F")]
		[Address(RVA = "0xB99CC0", Offset = "0xB990C0", VA = "0x180B99CC0")]
		public string nepPath()
		{
			return null;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x105CEB0", Offset = "0x105C2B0", VA = "0x18105CEB0")]
		public IntPtr nepHandle()
		{
			return 0;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x164A810", Offset = "0x1649C10", VA = "0x18164A810")]
		public uint nepCoreThreadId()
		{
			return 0U;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000272")]
		[Address(RVA = "0xCB09B0", Offset = "0xCAFDB0", VA = "0x180CB09B0")]
		public byte[] heartbeatPacket()
		{
			return null;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x14DAEC0", Offset = "0x14DA2C0", VA = "0x1814DAEC0")]
		public bool stop()
		{
			return default(bool);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x27A9CE0", Offset = "0x27A90E0", VA = "0x1827A9CE0")]
		public void stop(bool status)
		{
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x6000275")]
		[Address(RVA = "0xCB0840", Offset = "0xCAFC40", VA = "0x180CB0840")]
		public IntPtr ptrSetWhitelistIp()
		{
			return 0;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x6000276")]
		[Address(RVA = "0xCD6D90", Offset = "0xCD6190", VA = "0x180CD6D90")]
		public uint networkFailedCount()
		{
			return 0U;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x8EF970", Offset = "0x8EED70", VA = "0x1808EF970")]
		public IntPtr ptrSetWhitelistIpStatus()
		{
			return 0;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x6000278")]
		[Address(RVA = "0xCB0760", Offset = "0xCAFB60", VA = "0x180CB0760")]
		public IntPtr ptrCaptureScreen()
		{
			return 0;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x2E65FF0", Offset = "0x2E653F0", VA = "0x182E65FF0")]
		public bool report(NEPSTATUS code)
		{
			return default(bool);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x2E660B0", Offset = "0x2E654B0", VA = "0x182E660B0")]
		public bool request(E_Feature code)
		{
			return default(bool);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x2E65B10", Offset = "0x2E64F10", VA = "0x182E65B10")]
		public bool launch(uint serverProcessId)
		{
			return default(bool);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x2E66010", Offset = "0x2E65410", VA = "0x182E66010")]
		public bool requestAllFeature()
		{
			return default(bool);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x2E65E00", Offset = "0x2E65200", VA = "0x182E65E00")]
		private bool launch()
		{
			return default(bool);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2E65610", Offset = "0x2E64A10", VA = "0x182E65610")]
		private bool featureDispatcher(E_Feature code, IntPtr featureBuffer)
		{
			return default(bool);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x2E66160", Offset = "0x2E65560", VA = "0x182E66160")]
		private bool sync_message()
		{
			return default(bool);
		}

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected GuardClient.PipeMessage m_pipemessage;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int HEARTBEAT_PACKET_LENGTH;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected string m_nepMoudlePath;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected IntPtr m_nepHandle;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected uint m_nepCoreThreadId;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected byte[] m_heartbeatPacket;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected bool m_isStoped;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected IntPtr m_ptrSetWhitelistIp;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected uint m_networkFailedCount;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected IntPtr m_ptrSetWhitelistIpStatus;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected IntPtr m_ptrCaptureScreen;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static GuardClient instance;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly object locker;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool isInitedName;

		// Token: 0x02000051 RID: 81
		[Token(Token = "0x2000154")]
		[StructLayout(LayoutKind.Explicit)]
		public struct PipeMessage
		{
			// Token: 0x040001AD RID: 429
			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public NEPSTATUS nepCode;

			// Token: 0x040001AE RID: 430
			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public E_Feature featureCode;

			// Token: 0x040001AF RID: 431
			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public byte[] message;
		}
	}
}
