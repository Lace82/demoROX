using System;
using System.IO;
using Il2CppDummyDll;

namespace XGame.Aot
{
	// Token: 0x0200015D RID: 349
	[Token(Token = "0x2000109")]
	public class EncryptUtil
	{
		// Token: 0x06000A93 RID: 2707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000957")]
		[Address(RVA = "0x137A560", Offset = "0x1379960", VA = "0x18137A560")]
		public static void SetKey(string key, string iv)
		{
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x137A140", Offset = "0x1379540", VA = "0x18137A140")]
		public static void LoadEncryptKey(string key = "", string iv = "")
		{
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000959")]
		[Address(RVA = "0x1379600", Offset = "0x1378A00", VA = "0x181379600")]
		private static string DecryptKey(string key)
		{
			return null;
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x13796F0", Offset = "0x1378AF0", VA = "0x1813796F0")]
		public static string Decrypt(string encString)
		{
			return null;
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600095B")]
		[Address(RVA = "0x1379980", Offset = "0x1378D80", VA = "0x181379980")]
		public static byte[] Decrypt(byte[] data)
		{
			return null;
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600095C")]
		[Address(RVA = "0x1379BB0", Offset = "0x1378FB0", VA = "0x181379BB0")]
		public static string Encrypt(string rawString)
		{
			return null;
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600095D")]
		[Address(RVA = "0x1379E80", Offset = "0x1379280", VA = "0x181379E80")]
		public static byte[] Encrypt(MemoryStream ms)
		{
			return null;
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600095E")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public EncryptUtil()
		{
		}

		// Token: 0x04000612 RID: 1554
		[Token(Token = "0x40004AA")]
		[FieldOffset(Offset = "0x0")]
		private static string _sKey;

		// Token: 0x04000613 RID: 1555
		[Token(Token = "0x40004AB")]
		[FieldOffset(Offset = "0x8")]
		private static string _sIv;
	}
}
