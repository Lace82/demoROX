using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000C1 RID: 193
	[Token(Token = "0x200008D")]
	internal class HostPlayModeImpl : IPlayMode, IBundleQuery
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700008D")]
		public DownloadManager Download
		{
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x18181E0", Offset = "0x18175E0", VA = "0x1818181E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700008E")]
		public PersistentManager Persistent
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x1270BD0", Offset = "0x126FFD0", VA = "0x181270BD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700008F")]
		public CacheManager Cache
		{
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x11A1A60", Offset = "0x11A0E60", VA = "0x1811A1A60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000090")]
		public IRemoteServices RemoteServices
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0xB99ED0", Offset = "0xB992D0", VA = "0x180B99ED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x181DB20", Offset = "0x181CF20", VA = "0x18181DB20")]
		public HostPlayModeImpl(string packageName)
		{
		}

		// Token: 0x060003BA RID: 954 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x181CB10", Offset = "0x181BF10", VA = "0x18181CB10")]
		public InitializationOperation InitializeAsync(ResourceAssist assist, IBuildinQueryServices buildinQueryServices, IDeliveryQueryServices deliveryQueryServices, IRemoteServices remoteServices)
		{
			return null;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x181B470", Offset = "0x181A870", VA = "0x18181B470")]
		private List<BundleInfo> ConvertToDownloadList(List<PackageBundle> downloadList)
		{
			return null;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x181B310", Offset = "0x181A710", VA = "0x18181B310")]
		private BundleInfo ConvertToDownloadInfo(PackageBundle packageBundle)
		{
			return null;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x181CD10", Offset = "0x181C110", VA = "0x18181CD10")]
		private bool IsDeliveryPackageBundle(PackageBundle packageBundle)
		{
			return default(bool);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x181CCA0", Offset = "0x181C0A0", VA = "0x18181CCA0")]
		private bool IsCachedPackageBundle(PackageBundle packageBundle)
		{
			return default(bool);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x181CC10", Offset = "0x181C010", VA = "0x18181CC10")]
		private bool IsBuildinPackageBundle(PackageBundle packageBundle)
		{
			return default(bool);
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000091")]
		public PackageManifest ActiveManifest
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0xB9A930", Offset = "0xB99D30", VA = "0x180B9A930", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0xCC26A0", Offset = "0xCC1AA0", VA = "0x180CC26A0", Slot = "4")]
			set
			{
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x181B8C0", Offset = "0x181ACC0", VA = "0x18181B8C0", Slot = "6")]
		public void FlushManifestVersionFile()
		{
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x181DA70", Offset = "0x181CE70", VA = "0x18181DA70", Slot = "7")]
		private UpdatePackageVersionOperation UpdatePackageVersionAsync(bool appendTimeTicks, int timeout)
		{
			return null;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x181D9B0", Offset = "0x181CDB0", VA = "0x18181D9B0", Slot = "8")]
		private UpdatePackageManifestOperation UpdatePackageManifestAsync(string packageVersion, bool autoSaveVersion, int timeout)
		{
			return null;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x181D900", Offset = "0x181CD00", VA = "0x18181D900", Slot = "9")]
		private PreDownloadContentOperation PreDownloadContentAsync(string packageVersion, int timeout)
		{
			return null;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x181D280", Offset = "0x181C680", VA = "0x18181D280", Slot = "10")]
		private ResourceDownloaderOperation CreateResourceDownloaderByAll(int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x181B900", Offset = "0x181AD00", VA = "0x18181B900")]
		public List<BundleInfo> GetDownloadListByAll(PackageManifest manifest)
		{
			return null;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x181D420", Offset = "0x181C820", VA = "0x18181D420", Slot = "11")]
		private ResourceDownloaderOperation CreateResourceDownloaderByTags(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x181D5C0", Offset = "0x181C9C0", VA = "0x18181D5C0", Slot = "12")]
		private ResourceDownloaderOperation CreateResourceDownloaderWithoutTags(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x181C0F0", Offset = "0x181B4F0", VA = "0x18181C0F0")]
		public List<BundleInfo> GetDownloadListByTags(PackageManifest manifest, string[] tags)
		{
			return null;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x181C320", Offset = "0x181B720", VA = "0x18181C320")]
		public List<BundleInfo> GetDownloadListWithoutTags(PackageManifest manifest, string[] tags)
		{
			return null;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x181D350", Offset = "0x181C750", VA = "0x18181D350", Slot = "13")]
		private ResourceDownloaderOperation CreateResourceDownloaderByPaths(AssetInfo[] assetInfos, int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x181BD30", Offset = "0x181B130", VA = "0x18181BD30")]
		public List<BundleInfo> GetDownloadListByPaths(PackageManifest manifest, AssetInfo[] assetInfos)
		{
			return null;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x181D4F0", Offset = "0x181C8F0", VA = "0x18181D4F0", Slot = "14")]
		private ResourceDownloaderOperation CreateResourceDownloaderWithFilter(Predicate<PackageBundle> filter, int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x181BB00", Offset = "0x181AF00", VA = "0x18181BB00")]
		public List<BundleInfo> GetDownloadListByFilter(PackageManifest manifest, Predicate<PackageBundle> filter)
		{
			return null;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x181D760", Offset = "0x181CB60", VA = "0x18181D760", Slot = "15")]
		private ResourceUnpackerOperation CreateResourceUnpackerByAll(int upackingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x181C700", Offset = "0x181BB00", VA = "0x18181C700")]
		private List<BundleInfo> GetUnpackListByAll(PackageManifest manifest)
		{
			return null;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x181D830", Offset = "0x181CC30", VA = "0x18181D830", Slot = "16")]
		private ResourceUnpackerOperation CreateResourceUnpackerByTags(string[] tags, int upackingMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x181C8F0", Offset = "0x181BCF0", VA = "0x18181C8F0")]
		private List<BundleInfo> GetUnpackListByTags(PackageManifest manifest, string[] tags)
		{
			return null;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x181D690", Offset = "0x181CA90", VA = "0x18181D690", Slot = "17")]
		private ResourceImporterOperation CreateResourceImporterByFilePaths(string[] filePaths, int importerMaxNumber, int failedTryAgain, int timeout)
		{
			return null;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x181C550", Offset = "0x181B950", VA = "0x18181C550")]
		private List<BundleInfo> GetImporterListByFilePaths(PackageManifest manifest, string[] filePaths)
		{
			return null;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x181B5B0", Offset = "0x181A9B0", VA = "0x18181B5B0")]
		private BundleInfo CreateBundleInfo(PackageBundle packageBundle)
		{
			return null;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x181D0C0", Offset = "0x181C4C0", VA = "0x18181D0C0", Slot = "18")]
		private BundleInfo GetMainBundleInfo(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x181CDB0", Offset = "0x181C1B0", VA = "0x18181CDB0", Slot = "19")]
		private BundleInfo[] GetDependBundleInfos(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x181D1A0", Offset = "0x181C5A0", VA = "0x18181D1A0", Slot = "20")]
		private string GetMainBundleName(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x181CF40", Offset = "0x181C340", VA = "0x18181CF40", Slot = "21")]
		private string[] GetDependBundleNames(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x14C8BB0", Offset = "0x14C7FB0", VA = "0x1814C8BB0", Slot = "22")]
		private bool ManifestValid()
		{
			return default(bool);
		}

		// Token: 0x0400031F RID: 799
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x10")]
		private PackageManifest _activeManifest;

		// Token: 0x04000320 RID: 800
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x18")]
		private ResourceAssist _assist;

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x20")]
		private IBuildinQueryServices _buildinQueryServices;

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x28")]
		private IDeliveryQueryServices _deliveryQueryServices;

		// Token: 0x04000323 RID: 803
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x30")]
		private IRemoteServices _remoteServices;

		// Token: 0x04000324 RID: 804
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x38")]
		private readonly Dictionary<PackageBundle, BundleInfo> _pakageToBundleMap;

		// Token: 0x04000325 RID: 805
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x40")]
		public readonly string PackageName;
	}
}
