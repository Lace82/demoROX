using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace NLPC
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000045")]
	internal class LaunchStub
	{
		// Token: 0x06000362 RID: 866 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x2E682A0", Offset = "0x2E676A0", VA = "0x182E682A0")]
		public static bool SM_InitCallbackByCPP()
		{
			return default(bool);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x2E681C0", Offset = "0x2E675C0", VA = "0x182E681C0")]
		public static bool Pipe_InitCallback()
		{
			return default(bool);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x2E66E10", Offset = "0x2E66210", VA = "0x182E66E10")]
		private static bool InitResourceByCPP()
		{
			return default(bool);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x2E66B90", Offset = "0x2E65F90", VA = "0x182E66B90")]
		private static bool InitEvent()
		{
			return default(bool);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x2E68AC0", Offset = "0x2E67EC0", VA = "0x182E68AC0")]
		private static bool waitingTransferData()
		{
			return default(bool);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x2E678F0", Offset = "0x2E66CF0", VA = "0x182E678F0")]
		public static bool NEP_Init(string productId, GameSetInfo gameSetInfo, [Optional] TRANSCALLBACK callback)
		{
			return default(bool);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x2E67E40", Offset = "0x2E67240", VA = "0x182E67E40")]
		public static bool NEP_SetRoleInfo(string szBusinessId, string szAccount, string szRoleId, string szRoleName, int nServerId, string szServerName, int nRoleLevel, int nState = 0, [Optional] string szGameJson)
		{
			return default(bool);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x2E675D0", Offset = "0x2E669D0", VA = "0x182E675D0")]
		public static NEPRESULT NEP_GetToken(string businessId, ref string token)
		{
			return (NEPRESULT)0;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x2E67420", Offset = "0x2E66820", VA = "0x182E67420")]
		public static NEPRESULT NEP_GetTokenAsync(string businessId, TOKENCALLBACK cb)
		{
			return (NEPRESULT)0;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x2E67C40", Offset = "0x2E67040", VA = "0x182E67C40")]
		public static string NEP_Ioctl(IntPtr data, ulong len, int serviceType)
		{
			return null;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x2E672E0", Offset = "0x2E666E0", VA = "0x182E672E0")]
		public static INSTALLRESULT InstallStatusChecker(NEPStatusCallback callback, int intervalSeconds, bool isCallbackOnlyAbnormal)
		{
			return INSTALLRESULT.SUCCESS_INSTALLED;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x2E68930", Offset = "0x2E67D30", VA = "0x182E68930")]
		public static void UninstallStatusChecker()
		{
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x2E66AC0", Offset = "0x2E65EC0", VA = "0x182E66AC0")]
		public static NEPSTATUS GetSecurityStatus()
		{
			return NEPSTATUS.eNEP_Status_Normal;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public LaunchStub()
		{
		}

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string SKD_VERISON;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static IntPtr pShareMem;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static IntPtr hNepEvent;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static IntPtr hGameEvent;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly object mutexThere;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly string smappingName;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly string seventNepName;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly string seventGameName;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static bool initResourceStatusByCPP;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private static readonly uint waitingTime;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x400015F")]
		private const uint MIN_INTERVAL_SECONDS = 20U;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x4000160")]
		private const uint MAX_INTERVAL_SECONDS = 3600U;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static SETROLEINFOCALLBACK setRoleInfoCallback;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static INITSDKCALLBACK initSdkCallback;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static IOCTLCALLBACK ioctlCallback;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static FREEBUFFERCALLBACK freeBufferCallback;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static GETTOKENCALLBACK getTokenCallback;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static GETTOKENASYNCCALLBACK getTokenAsyncCallback;
	}
}
