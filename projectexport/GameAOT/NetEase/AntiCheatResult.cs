using System;
using Il2CppDummyDll;

namespace NetEase
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200002C")]
	public class AntiCheatResult
	{
		// Token: 0x060002F8 RID: 760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1D31F00", Offset = "0x1D31300", VA = "0x181D31F00")]
		public AntiCheatResult(int code, string codeStr, string token)
		{
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1D31E60", Offset = "0x1D31260", VA = "0x181D31E60")]
		public AntiCheatResult(int code, string token)
		{
		}

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x0")]
		public static int OK;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x8")]
		public static string OK_STR;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x10")]
		public static int ERROR_NOT_INIT;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x18")]
		public static string ERROR_NOT_INIT_STR;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x20")]
		public static int ERROR_ON_MAIN;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x28")]
		public static string ERROR_ON_MAIN_STR;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x30")]
		public static int ERROR_BUSINESSID_INVALID;

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x38")]
		public static string ERROR_BUSINESSID_INVALID_STR;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x10")]
		public int code;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x18")]
		public string codeStr;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x20")]
		public string token;
	}
}
