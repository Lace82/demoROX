using System;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace XGame.Aot
{
	// Token: 0x02000161 RID: 353
	[Token(Token = "0x200010C")]
	public static class RSAUtil
	{
		// Token: 0x06000AAF RID: 2735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600096B")]
		[Address(RVA = "0xECDBF0", Offset = "0xECCFF0", VA = "0x180ECDBF0")]
		public static void LoadPemPublicKey(byte[] bytes)
		{
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600096C")]
		[Address(RVA = "0xECDA90", Offset = "0xECCE90", VA = "0x180ECDA90")]
		public static byte[] Encrypt(byte[] data, string pemPublicKey)
		{
			return null;
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00004680 File Offset: 0x00002880
		[Token(Token = "0x600096D")]
		[Address(RVA = "0xECD830", Offset = "0xECCC30", VA = "0x180ECD830")]
		private static RSAParameters ConvertFromPemPublicKey(string pemFileContent)
		{
			return default(RSAParameters);
		}

		// Token: 0x04000616 RID: 1558
		[Token(Token = "0x40004AD")]
		[FieldOffset(Offset = "0x0")]
		public static string RSAPubKey;

		// Token: 0x04000617 RID: 1559
		[Token(Token = "0x40004AE")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string KEY_PATH;
	}
}
