using System;
using Il2CppDummyDll;

namespace NLPC
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000047")]
	internal class PipeGuard
	{
		// Token: 0x06000377 RID: 887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x2E6AE50", Offset = "0x2E6A250", VA = "0x182E6AE50")]
		public PipeGuard()
		{
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xCC03C0", Offset = "0xCBF7C0", VA = "0x180CC03C0")]
		public bool launch_status()
		{
			return default(bool);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x2E6AE90", Offset = "0x2E6A290", VA = "0x182E6AE90")]
		public void launch_status(bool status)
		{
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x2E6B100", Offset = "0x2E6A500", VA = "0x182E6B100")]
		public bool write(IntPtr data, uint dataLength)
		{
			return default(bool);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x2E6AF70", Offset = "0x2E6A370", VA = "0x182E6AF70")]
		public bool read(IntPtr data, out uint dataLength)
		{
			return default(bool);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x2E6B090", Offset = "0x2E6A490", VA = "0x182E6B090")]
		public void safeExit()
		{
		}

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x10")]
		protected IntPtr m_hPipe;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x18")]
		protected string m_pipeName;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x20")]
		protected string m_serverMessage;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x28")]
		protected bool m_isLaunched;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x0")]
		public static readonly object mutexThere;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x8")]
		public static readonly uint MAX_READ_WRITE_SIZE;
	}
}
