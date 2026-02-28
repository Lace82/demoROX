using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000060")]
	internal interface IBundleQuery
	{
		// Token: 0x06000299 RID: 665
		[Token(Token = "0x600028E")]
		BundleInfo GetMainBundleInfo(AssetInfo assetInfo);

		// Token: 0x0600029A RID: 666
		[Token(Token = "0x600028F")]
		BundleInfo[] GetDependBundleInfos(AssetInfo assetPath);

		// Token: 0x0600029B RID: 667
		[Token(Token = "0x6000290")]
		string GetMainBundleName(AssetInfo assetInfo);

		// Token: 0x0600029C RID: 668
		[Token(Token = "0x6000291")]
		string[] GetDependBundleNames(AssetInfo assetInfo);

		// Token: 0x0600029D RID: 669
		[Token(Token = "0x6000292")]
		bool ManifestValid();
	}
}
