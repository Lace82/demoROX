using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000C2 RID: 194
	[Token(Token = "0x200008E")]
	internal class OfflinePlayModeImpl : IPlayMode, IBundleQuery
	{
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060003DC RID: 988 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000092")]
		public DownloadManager Download
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x18181E0", Offset = "0x18175E0", VA = "0x1818181E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060003DD RID: 989 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000093")]
		public PersistentManager Persistent
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x1270BD0", Offset = "0x126FFD0", VA = "0x181270BD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060003DE RID: 990 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000094")]
		public CacheManager Cache
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x11A1A60", Offset = "0x11A0E60", VA = "0x1811A1A60")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x18181B0", Offset = "0x18175B0", VA = "0x1818181B0")]
		public OfflinePlayModeImpl(string packageName)
		{
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1BA9790", Offset = "0x1BA8B90", VA = "0x181BA9790")]
		public InitializationOperation InitializeAsync(ResourceAssist assist)
		{
			return null;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1BA98C0", Offset = "0x1BA8CC0", VA = "0x181BA98C0")]
		private bool IsCachedPackageBundle(PackageBundle packageBundle)
		{
			return default(bool);
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000095")]
		public PackageManifest ActiveManifest
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0xB9A930", Offset = "0xB99D30", VA = "0x180B9A930", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0xCC26A0", Offset = "0xCC1AA0", VA = "0x180CC26A0", Slot = "4")]
			set
			{
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "6")]
		public void FlushManifestVersionFile()
		{
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1BAA350", Offset = "0x1BA9750", VA = "0x181BAA350", Slot = "7")]
		private UpdatePackageVersionOperation UpdatePackageVersionAsync(bool appendTimeTicks, int timeout)
		{
			return null;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1BAA250", Offset = "0x1BA9650", VA = "0x181BAA250", Slot = "8")]
		private UpdatePackageManifestOperation UpdatePackageManifestAsync(string packageVersion, bool autoSaveVersion, int timeout)
		{
			return null;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1BAA140", Offset = "0x1BA9540", VA = "0x181BAA140", Slot = "9")]
		private PreDownloadContentOperation PreDownloadContentAsync(string packageVersion, int timeout)
		{
			return null;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1817F10", Offset = "0x1817310", VA = "0x181817F10", Slot = "10")]
		private ResourceDownloaderOperation CreateResourceDownloaderByAll(int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1817F50", Offset = "0x1817350", VA = "0x181817F50", Slot = "11")]
		private ResourceDownloaderOperation CreateResourceDownloaderByTags(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1817F50", Offset = "0x1817350", VA = "0x181817F50", Slot = "12")]
		private ResourceDownloaderOperation CreateResourceDownloaderWithoutTags(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1817F50", Offset = "0x1817350", VA = "0x181817F50", Slot = "13")]
		private ResourceDownloaderOperation CreateResourceDownloaderByPaths(AssetInfo[] assetInfos, int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1817F50", Offset = "0x1817350", VA = "0x181817F50", Slot = "14")]
		private ResourceDownloaderOperation CreateResourceDownloaderWithFilter(Predicate<PackageBundle> filter, int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x1BA9F20", Offset = "0x1BA9320", VA = "0x181BA9F20", Slot = "15")]
		private ResourceUnpackerOperation CreateResourceUnpackerByAll(int upackingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1BA9450", Offset = "0x1BA8850", VA = "0x181BA9450")]
		private List<BundleInfo> GetUnpackListByAll(PackageManifest manifest)
		{
			return null;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1BAA030", Offset = "0x1BA9430", VA = "0x181BAA030", Slot = "16")]
		private ResourceUnpackerOperation CreateResourceUnpackerByTags(string[] tags, int upackingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1BA95E0", Offset = "0x1BA89E0", VA = "0x181BA95E0")]
		private List<BundleInfo> GetUnpackListByTags(PackageManifest manifest, string[] tags)
		{
			return null;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1BA9E10", Offset = "0x1BA9210", VA = "0x181BA9E10", Slot = "17")]
		private ResourceImporterOperation CreateResourceImporterByFilePaths(string[] filePaths, int importerMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1BA9250", Offset = "0x1BA8650", VA = "0x181BA9250")]
		private List<BundleInfo> GetImporterListByFilePaths(PackageManifest manifest, string[] filePaths)
		{
			return null;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1BA9160", Offset = "0x1BA8560", VA = "0x181BA9160")]
		private BundleInfo CreateBundleInfo(PackageBundle packageBundle)
		{
			return null;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1BA9CA0", Offset = "0x1BA90A0", VA = "0x181BA9CA0", Slot = "18")]
		private BundleInfo GetMainBundleInfo(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1BA9900", Offset = "0x1BA8D00", VA = "0x181BA9900", Slot = "19")]
		private BundleInfo[] GetDependBundleInfos(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1BA9D60", Offset = "0x1BA9160", VA = "0x181BA9D60", Slot = "20")]
		private string GetMainBundleName(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1BA9B40", Offset = "0x1BA8F40", VA = "0x181BA9B40", Slot = "21")]
		private string[] GetDependBundleNames(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x14C8BB0", Offset = "0x14C7FB0", VA = "0x1814C8BB0", Slot = "22")]
		private bool ManifestValid()
		{
			return default(bool);
		}

		// Token: 0x04000326 RID: 806
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x10")]
		private PackageManifest _activeManifest;

		// Token: 0x04000327 RID: 807
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x18")]
		private ResourceAssist _assist;

		// Token: 0x04000328 RID: 808
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x20")]
		public readonly string PackageName;
	}
}
