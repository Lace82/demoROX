using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000065")]
	public sealed class ResourceUnpackerOperation : DownloaderOperation
	{
		// Token: 0x060002E5 RID: 741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1BB8E50", Offset = "0x1BB8250", VA = "0x181BB8E50")]
		internal ResourceUnpackerOperation(DownloadManager downloadMgr, string packageName, List<BundleInfo> downloadList, int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x1BB8D60", Offset = "0x1BB8160", VA = "0x181BB8D60")]
		internal static ResourceUnpackerOperation CreateEmptyUnpacker(DownloadManager downloadMgr, string packageName, int upackingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}
	}
}
