using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	internal class CacheFileInfo
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1810E50", Offset = "0x1810250", VA = "0x181810E50")]
		public static void WriteInfoToFile(string filePath, string dataFileCRC, long dataFileSize)
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1810D80", Offset = "0x1810180", VA = "0x181810D80")]
		public static void ReadInfoFromFile(string filePath, out string dataFileCRC, out long dataFileSize)
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public CacheFileInfo()
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x7461E")]
		private static readonly BufferWriter SharedBuffer;
	}
}
