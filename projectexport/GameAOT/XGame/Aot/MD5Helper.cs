using System;
using System.IO;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace XGame.Aot
{
	// Token: 0x02000160 RID: 352
	[Token(Token = "0x200010B")]
	public static class MD5Helper
	{
		// Token: 0x06000AA9 RID: 2729 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000965")]
		[Address(RVA = "0xEC8510", Offset = "0xEC7910", VA = "0x180EC8510")]
		public static string HashFileFromPath(string path)
		{
			return null;
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00004668 File Offset: 0x00002868
		[Token(Token = "0x6000966")]
		[Address(RVA = "0xEC8370", Offset = "0xEC7770", VA = "0x180EC8370")]
		public static int ComputeFileLength(string path)
		{
			return 0;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000967")]
		[Address(RVA = "0xEC86B0", Offset = "0xEC7AB0", VA = "0x180EC86B0")]
		public static string HashFileFromStream(Stream stream)
		{
			return null;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000968")]
		[Address(RVA = "0xEC8430", Offset = "0xEC7830", VA = "0x180EC8430")]
		public static string HashBytes(byte[] bytes)
		{
			return null;
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000969")]
		[Address(RVA = "0xEC8780", Offset = "0xEC7B80", VA = "0x180EC8780")]
		public static string HashString(string str)
		{
			return null;
		}

		// Token: 0x04000615 RID: 1557
		[Token(Token = "0x40004AC")]
		[FieldOffset(Offset = "0x5032D")]
		private static readonly MD5CryptoServiceProvider MD5;
	}
}
