using System;
using Il2CppDummyDll;

namespace NetEase
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200002B")]
	public class SafeCommResult
	{
		// Token: 0x060002F6 RID: 758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1D50880", Offset = "0x1D4FC80", VA = "0x181D50880")]
		public SafeCommResult()
		{
		}

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x0")]
		public static int SC_CODE_OK;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x4")]
		public static int SC_FILE_NOTEXIST;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x8")]
		public static int SC_FILE_IS_BROKEN;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0xC")]
		public static int SC_PROTOCOL_VERSION_ERROR;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x10")]
		public static int SC_PARAM_ERROR;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x14")]
		public static int SC_DATA_TAMPERED;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x18")]
		public static int SC_DATA_DECRYPT_ERROR;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x1C")]
		public static int SC_ALG_ERROR;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x20")]
		public static int SC_TIMEOUT;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x24")]
		public static int SC_NOT_INIT;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x28")]
		public static int SC_BUFF_MALLOC_ERROR;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x2C")]
		public static int SC_INSIDE_ERROR;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x10")]
		public int ret;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x18")]
		public byte[] encBytes;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x20")]
		public string encResult;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x28")]
		public byte[] decResult;
	}
}
