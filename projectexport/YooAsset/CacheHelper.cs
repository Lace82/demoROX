using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	internal static class CacheHelper
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002054 File Offset: 0x00000254
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x18110C0", Offset = "0x18104C0", VA = "0x1818110C0")]
		public static EVerifyResult VerifyingCacheFile(VerifyCacheFileElement element, EVerifyLevel verifyLevel)
		{
			return EVerifyResult.None;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x1811480", Offset = "0x1810880", VA = "0x181811480")]
		public static EVerifyResult VerifyingTempFile(VerifyTempFileElement element)
		{
			return EVerifyResult.None;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x18113C0", Offset = "0x18107C0", VA = "0x1818113C0")]
		public static EVerifyResult VerifyingRecordFile(CacheManager cache, string cacheGUID)
		{
			return EVerifyResult.None;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x18112A0", Offset = "0x18106A0", VA = "0x1818112A0")]
		private static EVerifyResult VerifyingInternal(string filePath, long fileSize, string fileCRC, EVerifyLevel verifyLevel)
		{
			return EVerifyResult.None;
		}

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x74717")]
		public static bool DisableUnityCacheOnWebGL;
	}
}
