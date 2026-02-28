using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000D8 RID: 216
	[Token(Token = "0x20000A3")]
	internal static class YooLogger
	{
		// Token: 0x060004CC RID: 1228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x389CF80", Offset = "0x389C380", VA = "0x18389CF80")]
		[Attribute(Name = "ConditionalAttribute", RVA = "0x8FAD0", Offset = "0x8EED0")]
		public static void Log(string info)
		{
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x389D050", Offset = "0x389C450", VA = "0x18389D050")]
		public static void Warning(string info)
		{
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x389CD70", Offset = "0x389C170", VA = "0x18389CD70")]
		public static void Error(string info)
		{
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x389CE40", Offset = "0x389C240", VA = "0x18389CE40")]
		public static void Exception(Exception exception)
		{
		}

		// Token: 0x04000362 RID: 866
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x7472E")]
		public static ILogger Logger;
	}
}
