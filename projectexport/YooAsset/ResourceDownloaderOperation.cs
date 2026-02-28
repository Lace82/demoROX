using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000083 RID: 131
	[Token(Token = "0x2000064")]
	public sealed class ResourceDownloaderOperation : DownloaderOperation
	{
		// Token: 0x060002E3 RID: 739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1BB1C40", Offset = "0x1BB1040", VA = "0x181BB1C40")]
		internal ResourceDownloaderOperation(DownloadManager downloadMgr, string packageName, List<BundleInfo> downloadList, int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1BB1B50", Offset = "0x1BB0F50", VA = "0x181BB1B50")]
		internal static ResourceDownloaderOperation CreateEmptyDownloader(DownloadManager downloadMgr, string packageName, int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}
	}
}
