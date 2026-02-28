using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YooAsset
{
	// Token: 0x020000D1 RID: 209
	[Token(Token = "0x200009C")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x174110", Offset = "0x173510")]
	internal class YooAssetSettings : ScriptableObject
	{
		// Token: 0x0600048B RID: 1163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x389A040", Offset = "0x3899440", VA = "0x18389A040")]
		public YooAssetSettings()
		{
		}

		// Token: 0x0400034B RID: 843
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x18")]
		public string ManifestFileName;

		// Token: 0x0400034C RID: 844
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x20")]
		public string DefaultYooFolderName;

		// Token: 0x0400034D RID: 845
		[Token(Token = "0x4000246")]
		public const uint ManifestFileSign = 5853007U;

		// Token: 0x0400034E RID: 846
		[Token(Token = "0x4000247")]
		public const int ManifestFileMaxSize = 104857600;

		// Token: 0x0400034F RID: 847
		[Token(Token = "0x4000248")]
		public const string ManifestFileVersion = "2.0.0";

		// Token: 0x04000350 RID: 848
		[Token(Token = "0x4000249")]
		public const string CacheBundleDataFileName = "__data";

		// Token: 0x04000351 RID: 849
		[Token(Token = "0x400024A")]
		public const string CacheBundleInfoFileName = "__info";

		// Token: 0x04000352 RID: 850
		[Token(Token = "0x400024B")]
		public const string CacheFilesFolderName = "CacheFiles";

		// Token: 0x04000353 RID: 851
		[Token(Token = "0x400024C")]
		public const string ManifestFolderName = "ManifestFiles";

		// Token: 0x04000354 RID: 852
		[Token(Token = "0x400024D")]
		public const string AppFootPrintFileName = "ApplicationFootPrint.bytes";

		// Token: 0x04000355 RID: 853
		[Token(Token = "0x400024E")]
		public const string OutputFolderName = "OutputCache";

		// Token: 0x04000356 RID: 854
		[Token(Token = "0x400024F")]
		public const string ReportFileName = "BuildReport";

		// Token: 0x04000357 RID: 855
		[Token(Token = "0x4000250")]
		public const string HOTUPDATE_ASSET_PARENT = "Assets/GameAssets/HotUpdateAssets";

		// Token: 0x04000358 RID: 856
		[Token(Token = "0x4000251")]
		public const string NECESSARY_ASSET_TAG = "necessarytag";
	}
}
