using System;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	public static class FileUtility
	{
		// Token: 0x06000154 RID: 340 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000154")]
		public static void WriteJson<T>(T obj, string filePath) where T : class
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000155")]
		public static T ReadJson<T>(string filePath) where T : class
		{
			return null;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2B948F0", Offset = "0x2B93CF0", VA = "0x182B948F0")]
		public static byte[] ReadAllBytes(string filePath)
		{
			return null;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2B949D0", Offset = "0x2B93DD0", VA = "0x182B949D0")]
		public static string[] ReadAllLines(string filePath)
		{
			return null;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2B94AB0", Offset = "0x2B93EB0", VA = "0x182B94AB0")]
		public static string ReadAllText(string filePath)
		{
			return null;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2B94CA0", Offset = "0x2B940A0", VA = "0x182B94CA0")]
		public static void WriteAllBytes(string filePath, byte[] data)
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2B94D90", Offset = "0x2B94190", VA = "0x182B94D90")]
		public static void WriteAllLines(string filePath, string[] textLines)
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2B94E80", Offset = "0x2B94280", VA = "0x182B94E80")]
		public static void WriteAllText(string filePath, string text)
		{
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2B94860", Offset = "0x2B93C60", VA = "0x182B94860")]
		public static void PrepareDirectory(string filePath)
		{
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2B943D0", Offset = "0x2B937D0", VA = "0x182B943D0")]
		public static void CleanDirectory(string folder)
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2B945A0", Offset = "0x2B939A0", VA = "0x182B945A0")]
		public static void DeleteDirectory(string folder)
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2B94750", Offset = "0x2B93B50", VA = "0x182B94750")]
		private static void InternalDeleteDirectory(string folder)
		{
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2B94670", Offset = "0x2B93A70", VA = "0x182B94670")]
		public static void DeleteFile(string filePath)
		{
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2B94B90", Offset = "0x2B93F90", VA = "0x182B94B90")]
		public static void RenameFile(string sourceFile, string destFile)
		{
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2B944A0", Offset = "0x2B938A0", VA = "0x182B944A0")]
		public static void CopyFile(string fromFile, string toFile)
		{
		}
	}
}
