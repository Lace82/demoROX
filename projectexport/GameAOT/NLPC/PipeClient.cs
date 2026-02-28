using System;
using Il2CppDummyDll;

namespace NLPC
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000046")]
	internal class PipeClient : PipeGuard
	{
		// Token: 0x06000371 RID: 881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x2E6A060", Offset = "0x2E69460", VA = "0x182E6A060")]
		private PipeClient()
		{
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000029")]
		public static PipeClient getInstance
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x2E6A170", Offset = "0x2E69570", VA = "0x182E6A170")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x2E6A3F0", Offset = "0x2E697F0", VA = "0x182E6A3F0")]
		private bool launch()
		{
			return default(bool);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x2E6A670", Offset = "0x2E69A70", VA = "0x182E6A670")]
		private bool sync_message(uint curMsgType)
		{
			return default(bool);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x2E69FC0", Offset = "0x2E693C0", VA = "0x182E69FC0")]
		public bool InitCallback()
		{
			return default(bool);
		}

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x30")]
		protected PipeClient.PipeMessage m_pipemsg;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x0")]
		private static PipeClient instance;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object locker;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x60")]
		public SETROLEINFOCALLBACK setRoleInfoCallback;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x68")]
		public INITSDKCALLBACK initSdkCallback;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x70")]
		public IOCTLCALLBACK ioctlCallback;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x78")]
		public INSTALLTRANSCALLBACK installTransCallback;

		// Token: 0x02000068 RID: 104
		[Token(Token = "0x2000155")]
		public struct PipeMessage
		{
			// Token: 0x04000202 RID: 514
			[Token(Token = "0x400054E")]
			[FieldOffset(Offset = "0x0")]
			public uint msgType;

			// Token: 0x04000203 RID: 515
			[Token(Token = "0x400054F")]
			[FieldOffset(Offset = "0x8")]
			public IntPtr installTransCallbacker;

			// Token: 0x04000204 RID: 516
			[Token(Token = "0x4000550")]
			[FieldOffset(Offset = "0x10")]
			public IntPtr sendTransResultCallbacker;

			// Token: 0x04000205 RID: 517
			[Token(Token = "0x4000551")]
			[FieldOffset(Offset = "0x18")]
			public IntPtr accountCallbacker;

			// Token: 0x04000206 RID: 518
			[Token(Token = "0x4000552")]
			[FieldOffset(Offset = "0x20")]
			public IntPtr initAppCallbacker;

			// Token: 0x04000207 RID: 519
			[Token(Token = "0x4000553")]
			[FieldOffset(Offset = "0x28")]
			public IntPtr sdkFuncFactory;
		}
	}
}
