using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x200008C")]
	internal class EditorSimulateModeImpl : IPlayMode, IBundleQuery
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600039E RID: 926 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700008B")]
		public DownloadManager Download
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x18181E0", Offset = "0x18175E0", VA = "0x1818181E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x18181B0", Offset = "0x18175B0", VA = "0x1818181B0")]
		public EditorSimulateModeImpl(string packageName)
		{
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1817850", Offset = "0x1816C50", VA = "0x181817850")]
		public InitializationOperation InitializeAsync(ResourceAssist assist, string simulateManifestFilePath)
		{
			return null;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008C")]
		public PackageManifest ActiveManifest
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0xB9A930", Offset = "0xB99D30", VA = "0x180B9A930", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000383")]
			[Address(RVA = "0xCC26A0", Offset = "0xCC1AA0", VA = "0x180CC26A0", Slot = "4")]
			set
			{
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "6")]
		public void FlushManifestVersionFile()
		{
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1818130", Offset = "0x1817530", VA = "0x181818130", Slot = "7")]
		private UpdatePackageVersionOperation UpdatePackageVersionAsync(bool appendTimeTicks, int timeout)
		{
			return null;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x18180B0", Offset = "0x18174B0", VA = "0x1818180B0", Slot = "8")]
		private UpdatePackageManifestOperation UpdatePackageManifestAsync(string packageVersion, bool autoSaveVersion, int timeout)
		{
			return null;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1818020", Offset = "0x1817420", VA = "0x181818020", Slot = "9")]
		private PreDownloadContentOperation PreDownloadContentAsync(string packageVersion, int timeout)
		{
			return null;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1817F10", Offset = "0x1817310", VA = "0x181817F10", Slot = "10")]
		private ResourceDownloaderOperation CreateResourceDownloaderByAll(int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1817F50", Offset = "0x1817350", VA = "0x181817F50", Slot = "11")]
		private ResourceDownloaderOperation CreateResourceDownloaderByTags(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1817F50", Offset = "0x1817350", VA = "0x181817F50", Slot = "12")]
		private ResourceDownloaderOperation CreateResourceDownloaderWithoutTags(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1817F50", Offset = "0x1817350", VA = "0x181817F50", Slot = "13")]
		private ResourceDownloaderOperation CreateResourceDownloaderByPaths(AssetInfo[] assetInfos, int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1817F50", Offset = "0x1817350", VA = "0x181817F50", Slot = "14")]
		private ResourceDownloaderOperation CreateResourceDownloaderWithFilter(Predicate<PackageBundle> filter, int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1817FB0", Offset = "0x18173B0", VA = "0x181817FB0", Slot = "15")]
		private ResourceUnpackerOperation CreateResourceUnpackerByAll(int upackingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1817FF0", Offset = "0x18173F0", VA = "0x181817FF0", Slot = "16")]
		private ResourceUnpackerOperation CreateResourceUnpackerByTags(string[] tags, int upackingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1817F80", Offset = "0x1817380", VA = "0x181817F80", Slot = "17")]
		private ResourceImporterOperation CreateResourceImporterByFilePaths(string[] filePaths, int importerMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1817710", Offset = "0x1816B10", VA = "0x181817710")]
		private BundleInfo CreateBundleInfo(PackageBundle packageBundle, AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1817D40", Offset = "0x1817140", VA = "0x181817D40", Slot = "18")]
		private BundleInfo GetMainBundleInfo(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1817910", Offset = "0x1816D10", VA = "0x181817910", Slot = "19")]
		private BundleInfo[] GetDependBundleInfos(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1817E30", Offset = "0x1817230", VA = "0x181817E30", Slot = "20")]
		private string GetMainBundleName(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1817BC0", Offset = "0x1816FC0", VA = "0x181817BC0", Slot = "21")]
		private string[] GetDependBundleNames(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x14C8BB0", Offset = "0x14C7FB0", VA = "0x1814C8BB0", Slot = "22")]
		private bool ManifestValid()
		{
			return default(bool);
		}

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x10")]
		private PackageManifest _activeManifest;

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x18")]
		private ResourceAssist _assist;

		// Token: 0x0400031E RID: 798
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x20")]
		public readonly string PackageName;
	}
}
