using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000061")]
	internal interface IPlayMode
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600029F RID: 671
		// (set) Token: 0x0600029E RID: 670
		[Token(Token = "0x17000071")]
		PackageManifest ActiveManifest { [Token(Token = "0x6000294")] get; [Token(Token = "0x6000293")] set; }

		// Token: 0x060002A0 RID: 672
		[Token(Token = "0x6000295")]
		void FlushManifestVersionFile();

		// Token: 0x060002A1 RID: 673
		[Token(Token = "0x6000296")]
		UpdatePackageVersionOperation UpdatePackageVersionAsync(bool appendTimeTicks, int timeout);

		// Token: 0x060002A2 RID: 674
		[Token(Token = "0x6000297")]
		UpdatePackageManifestOperation UpdatePackageManifestAsync(string packageVersion, bool autoSaveVersion, int timeout);

		// Token: 0x060002A3 RID: 675
		[Token(Token = "0x6000298")]
		PreDownloadContentOperation PreDownloadContentAsync(string packageVersion, int timeout);

		// Token: 0x060002A4 RID: 676
		[Token(Token = "0x6000299")]
		ResourceDownloaderOperation CreateResourceDownloaderByAll(int downloadingMaxNumber, int failedTryAgain, int timeout);

		// Token: 0x060002A5 RID: 677
		[Token(Token = "0x600029A")]
		ResourceDownloaderOperation CreateResourceDownloaderByTags(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout);

		// Token: 0x060002A6 RID: 678
		[Token(Token = "0x600029B")]
		ResourceDownloaderOperation CreateResourceDownloaderWithoutTags(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout);

		// Token: 0x060002A7 RID: 679
		[Token(Token = "0x600029C")]
		ResourceDownloaderOperation CreateResourceDownloaderByPaths(AssetInfo[] assetInfos, int downloadingMaxNumber, int failedTryAgain, int timeout);

		// Token: 0x060002A8 RID: 680
		[Token(Token = "0x600029D")]
		ResourceDownloaderOperation CreateResourceDownloaderWithFilter(Predicate<PackageBundle> filter, int downloadingMaxNumber, int failedTryAgain, int timeout);

		// Token: 0x060002A9 RID: 681
		[Token(Token = "0x600029E")]
		ResourceUnpackerOperation CreateResourceUnpackerByAll(int upackingMaxNumber, int failedTryAgain, int timeout);

		// Token: 0x060002AA RID: 682
		[Token(Token = "0x600029F")]
		ResourceUnpackerOperation CreateResourceUnpackerByTags(string[] tags, int upackingMaxNumber, int failedTryAgain, int timeout);

		// Token: 0x060002AB RID: 683
		[Token(Token = "0x60002A0")]
		ResourceImporterOperation CreateResourceImporterByFilePaths(string[] filePaths, int importerMaxNumber, int failedTryAgain, int timeout);
	}
}
