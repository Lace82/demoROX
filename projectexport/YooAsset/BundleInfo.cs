using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

namespace YooAsset
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x200005F")]
	internal class BundleInfo
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600027D RID: 637 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600027C RID: 636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006A")]
		public string RemoteMainURL
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0xB9A940", Offset = "0xB99D40", VA = "0x180B9A940")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000271")]
			[Address(RVA = "0xCC1D90", Offset = "0xCC1190", VA = "0x180CC1D90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600027F RID: 639 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600027E RID: 638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006B")]
		public string RemoteFallbackURL
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0xB99ED0", Offset = "0xB992D0", VA = "0x180B99ED0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x1047110", Offset = "0x1046510", VA = "0x181047110")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000281 RID: 641 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000280 RID: 640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006C")]
		public string DeliveryFilePath
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0xB9A950", Offset = "0xB99D50", VA = "0x180B9A950")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000275")]
			[Address(RVA = "0xCC31B0", Offset = "0xCC25B0", VA = "0x180CC31B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		private BundleInfo()
		{
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x180E520", Offset = "0x180D920", VA = "0x18180E520")]
		public BundleInfo(ResourceAssist assist, PackageBundle bundle, BundleInfo.ELoadMode loadMode, string mainURL, string fallbackURL)
		{
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x180E370", Offset = "0x180D770", VA = "0x18180E370")]
		public BundleInfo(ResourceAssist assist, PackageBundle bundle, BundleInfo.ELoadMode loadMode, string deliveryFilePath)
		{
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x180E440", Offset = "0x180D840", VA = "0x18180E440")]
		public BundleInfo(ResourceAssist assist, PackageBundle bundle, BundleInfo.ELoadMode loadMode)
		{
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x180E160", Offset = "0x180D560", VA = "0x18180E160")]
		public bool IsRawFileBundle()
		{
			return default(bool);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x180E0F0", Offset = "0x180D4F0", VA = "0x18180E0F0")]
		public bool IsCached()
		{
			return default(bool);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x180DA10", Offset = "0x180CE10", VA = "0x18180DA10")]
		public void CacheRecord()
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x180D9D0", Offset = "0x180CDD0", VA = "0x18180D9D0")]
		public void CacheDiscard()
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x180E260", Offset = "0x180D660", VA = "0x18180E260")]
		public EVerifyResult VerifySelf()
		{
			return EVerifyResult.None;
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600028B RID: 651 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700006D")]
		public string CachedDataFilePath
		{
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x180E610", Offset = "0x180DA10", VA = "0x18180E610")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600028C RID: 652 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700006E")]
		public string CachedInfoFilePath
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x180E640", Offset = "0x180DA40", VA = "0x18180E640")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600028D RID: 653 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700006F")]
		public string TempDataFilePath
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x180E670", Offset = "0x180DA70", VA = "0x18180E670")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600028E RID: 654 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000070")]
		public string BuildinFilePath
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x180E5E0", Offset = "0x180D9E0", VA = "0x18180E5E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x180DC90", Offset = "0x180D090", VA = "0x18180DC90")]
		public DownloaderBase CreateDownloader(int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x180DFF0", Offset = "0x180D3F0", VA = "0x18180DFF0")]
		public DownloaderBase CreateUnpacker(int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x180E1C0", Offset = "0x180D5C0", VA = "0x18180E1C0")]
		internal AssetBundle LoadAssetBundle(string fileLoadPath, out Stream managedStream)
		{
			return null;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x180E180", Offset = "0x180D580", VA = "0x18180E180")]
		internal AssetBundleCreateRequest LoadAssetBundleAsync(string fileLoadPath, out Stream managedStream)
		{
			return null;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x180E230", Offset = "0x180D630", VA = "0x18180E230")]
		internal AssetBundle LoadDeliveryAssetBundle(string fileLoadPath)
		{
			return null;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x180E200", Offset = "0x180D600", VA = "0x18180E200")]
		internal AssetBundleCreateRequest LoadDeliveryAssetBundleAsync(string fileLoadPath)
		{
			return null;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x180DBD0", Offset = "0x180CFD0", VA = "0x18180DBD0")]
		private BundleInfo ConvertToUnpackInfo()
		{
			return null;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x180DE10", Offset = "0x180D210", VA = "0x18180DE10")]
		public static List<BundleInfo> CreateUnpackInfos(ResourceAssist assist, List<PackageBundle> unpackList)
		{
			return null;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x180DD60", Offset = "0x180D160", VA = "0x18180DD60")]
		private static BundleInfo CreateUnpackInfo(ResourceAssist assist, PackageBundle packageBundle)
		{
			return null;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x180DCD0", Offset = "0x180D0D0", VA = "0x18180DCD0")]
		public static BundleInfo CreateImportInfo(ResourceAssist assist, PackageBundle packageBundle, string filePath)
		{
			return null;
		}

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x10")]
		private readonly ResourceAssist _assist;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x18")]
		public readonly PackageBundle Bundle;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x20")]
		public readonly BundleInfo.ELoadMode LoadMode;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <RemoteMainURL>k__BackingField;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <RemoteFallbackURL>k__BackingField;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <DeliveryFilePath>k__BackingField;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x40")]
		public string[] IncludeAssetsInEditor;

		// Token: 0x02000076 RID: 118
		[Token(Token = "0x20000C0")]
		public enum ELoadMode
		{
			// Token: 0x040001D1 RID: 465
			[Token(Token = "0x40002E0")]
			None,
			// Token: 0x040001D2 RID: 466
			[Token(Token = "0x40002E1")]
			LoadFromDelivery,
			// Token: 0x040001D3 RID: 467
			[Token(Token = "0x40002E2")]
			LoadFromStreaming,
			// Token: 0x040001D4 RID: 468
			[Token(Token = "0x40002E3")]
			LoadFromCache,
			// Token: 0x040001D5 RID: 469
			[Token(Token = "0x40002E4")]
			LoadFromRemote,
			// Token: 0x040001D6 RID: 470
			[Token(Token = "0x40002E5")]
			LoadFromEditor
		}
	}
}
