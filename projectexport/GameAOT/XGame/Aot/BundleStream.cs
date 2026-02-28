using System;
using System.IO;
using Il2CppDummyDll;

namespace XGame.Aot
{
	// Token: 0x02000114 RID: 276
	[Token(Token = "0x20000DE")]
	public class BundleStream : FileStream
	{
		// Token: 0x06000976 RID: 2422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x1377410", Offset = "0x1376810", VA = "0x181377410")]
		public BundleStream(string path, FileMode mode, FileAccess access, FileShare share)
		{
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000879")]
		[Address(RVA = "0x1377390", Offset = "0x1376790", VA = "0x181377390")]
		public BundleStream(string path, FileMode mode)
		{
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x000041D0 File Offset: 0x000023D0
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x1377330", Offset = "0x1376730", VA = "0x181377330", Slot = "33")]
		public override int Read(byte[] array, int offset, int count)
		{
			return 0;
		}

		// Token: 0x04000512 RID: 1298
		[Token(Token = "0x4000427")]
		public const byte KEY = 64;
	}
}
