using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000C3 RID: 195
	[Token(Token = "0x200008F")]
	internal class WebPlayModeImpl : IPlayMode, IBundleQuery
	{
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000096")]
		public DownloadManager Download
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x18181E0", Offset = "0x18175E0", VA = "0x1818181E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000097")]
		public PersistentManager Persistent
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x1270BD0", Offset = "0x126FFD0", VA = "0x181270BD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000098")]
		public IRemoteServices RemoteServices
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0xB9A940", Offset = "0xB99D40", VA = "0x180B9A940")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x38989B0", Offset = "0x3897DB0", VA = "0x1838989B0")]
		public WebPlayModeImpl(string packageName)
		{
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x3897B80", Offset = "0x3896F80", VA = "0x183897B80")]
		public InitializationOperation InitializeAsync(ResourceAssist assist, IBuildinQueryServices buildinQueryServices, IRemoteServices remoteServices)
		{
			return null;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x3896F00", Offset = "0x3896300", VA = "0x183896F00")]
		private BundleInfo ConvertToDownloadInfo(PackageBundle packageBundle)
		{
			return null;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x3897000", Offset = "0x3896400", VA = "0x183897000")]
		private List<BundleInfo> ConvertToDownloadList(List<PackageBundle> downloadList)
		{
			return null;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xCB9160", Offset = "0xCB8560", VA = "0x180CB9160")]
		private bool IsCachedPackageBundle(PackageBundle packageBundle)
		{
			return default(bool);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x3897C60", Offset = "0x3897060", VA = "0x183897C60")]
		private bool IsBuildinPackageBundle(PackageBundle packageBundle)
		{
			return default(bool);
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000099")]
		public PackageManifest ActiveManifest
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0xB9A930", Offset = "0xB99D30", VA = "0x180B9A930", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0xCC26A0", Offset = "0xCC1AA0", VA = "0x180CC26A0", Slot = "4")]
			set
			{
			}
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "6")]
		public void FlushManifestVersionFile()
		{
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x3898900", Offset = "0x3897D00", VA = "0x183898900", Slot = "7")]
		private UpdatePackageVersionOperation UpdatePackageVersionAsync(bool appendTimeTicks, int timeout)
		{
			return null;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x3898840", Offset = "0x3897C40", VA = "0x183898840", Slot = "8")]
		private UpdatePackageManifestOperation UpdatePackageManifestAsync(string packageVersion, bool autoSaveVersion, int timeout)
		{
			return null;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x38987B0", Offset = "0x3897BB0", VA = "0x1838987B0", Slot = "9")]
		private PreDownloadContentOperation PreDownloadContentAsync(string packageVersion, int timeout)
		{
			return null;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x3898300", Offset = "0x3897700", VA = "0x183898300", Slot = "10")]
		private ResourceDownloaderOperation CreateResourceDownloaderByAll(int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x3898570", Offset = "0x3897970", VA = "0x183898570", Slot = "14")]
		private ResourceDownloaderOperation CreateResourceDownloaderWithFilter(Predicate<PackageBundle> filter, int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x3897380", Offset = "0x3896780", VA = "0x183897380")]
		public List<BundleInfo> GetDownloadListByFilter(PackageManifest manifest, Predicate<PackageBundle> filter)
		{
			return null;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x3897220", Offset = "0x3896620", VA = "0x183897220")]
		public List<BundleInfo> GetDownloadListByAll(PackageManifest manifest)
		{
			return null;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x38984A0", Offset = "0x38978A0", VA = "0x1838984A0", Slot = "11")]
		private ResourceDownloaderOperation CreateResourceDownloaderByTags(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x3898640", Offset = "0x3897A40", VA = "0x183898640", Slot = "12")]
		private ResourceDownloaderOperation CreateResourceDownloaderWithoutTags(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x3897860", Offset = "0x3896C60", VA = "0x183897860")]
		public List<BundleInfo> GetDownloadListByTags(PackageManifest manifest, string[] tags)
		{
			return null;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x38979F0", Offset = "0x3896DF0", VA = "0x1838979F0")]
		public List<BundleInfo> GetDownloadListWithoutTags(PackageManifest manifest, string[] tags)
		{
			return null;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x38983D0", Offset = "0x38977D0", VA = "0x1838983D0", Slot = "13")]
		private ResourceDownloaderOperation CreateResourceDownloaderByPaths(AssetInfo[] assetInfos, int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x3897510", Offset = "0x3896910", VA = "0x183897510")]
		public List<BundleInfo> GetDownloadListByPaths(PackageManifest manifest, AssetInfo[] assetInfos)
		{
			return null;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x3898740", Offset = "0x3897B40", VA = "0x183898740", Slot = "15")]
		private ResourceUnpackerOperation CreateResourceUnpackerByAll(int upackingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x3898780", Offset = "0x3897B80", VA = "0x183898780", Slot = "16")]
		private ResourceUnpackerOperation CreateResourceUnpackerByTags(string[] tags, int upackingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x3898710", Offset = "0x3897B10", VA = "0x183898710", Slot = "17")]
		private ResourceImporterOperation CreateResourceImporterByFilePaths(string[] filePaths, int importerMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x3897140", Offset = "0x3896540", VA = "0x183897140")]
		private BundleInfo CreateBundleInfo(PackageBundle packageBundle)
		{
			return null;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x38980E0", Offset = "0x38974E0", VA = "0x1838980E0", Slot = "18")]
		private BundleInfo GetMainBundleInfo(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x3897D50", Offset = "0x3897150", VA = "0x183897D50", Slot = "19")]
		private BundleInfo[] GetDependBundleInfos(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x3898250", Offset = "0x3897650", VA = "0x183898250", Slot = "20")]
		private string GetMainBundleName(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x3897F80", Offset = "0x3897380", VA = "0x183897F80", Slot = "21")]
		private string[] GetDependBundleNames(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x14C8BB0", Offset = "0x14C7FB0", VA = "0x1814C8BB0", Slot = "22")]
		private bool ManifestValid()
		{
			return default(bool);
		}

		// Token: 0x04000329 RID: 809
		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x10")]
		private PackageManifest _activeManifest;

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x18")]
		private ResourceAssist _assist;

		// Token: 0x0400032B RID: 811
		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x20")]
		private IBuildinQueryServices _buildinQueryServices;

		// Token: 0x0400032C RID: 812
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x28")]
		private IRemoteServices _remoteServices;

		// Token: 0x0400032D RID: 813
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x30")]
		public readonly string PackageName;
	}
}
