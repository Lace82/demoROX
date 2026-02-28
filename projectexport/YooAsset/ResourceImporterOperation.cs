using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000066")]
	public sealed class ResourceImporterOperation : DownloaderOperation
	{
		// Token: 0x060002E7 RID: 743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1BB1DC0", Offset = "0x1BB11C0", VA = "0x181BB1DC0")]
		internal ResourceImporterOperation(DownloadManager downloadMgr, string packageName, List<BundleInfo> downloadList, int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1BB1CD0", Offset = "0x1BB10D0", VA = "0x181BB1CD0")]
		internal static ResourceImporterOperation CreateEmptyImporter(DownloadManager downloadMgr, string packageName, int upackingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}
	}
}
