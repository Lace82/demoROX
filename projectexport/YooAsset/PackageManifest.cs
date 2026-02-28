using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000BE RID: 190
	[Token(Token = "0x200008A")]
	[Serializable]
	internal class PackageManifest
	{
		// Token: 0x0600038C RID: 908 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1BACF40", Offset = "0x1BAC340", VA = "0x181BACF40")]
		public string TryMappingToAssetPath(string location)
		{
			return null;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x1BACA50", Offset = "0x1BABE50", VA = "0x181BACA50")]
		public PackageBundle GetMainPackageBundle(string assetPath)
		{
			return null;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1BAC4E0", Offset = "0x1BAB8E0", VA = "0x181BAC4E0")]
		public PackageBundle[] GetAllDependencies(string assetPath)
		{
			return null;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1BACDF0", Offset = "0x1BAC1F0", VA = "0x181BACDF0")]
		public bool TryGetPackageAsset(string assetPath, out PackageAsset result)
		{
			return default(bool);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1BACE60", Offset = "0x1BAC260", VA = "0x181BACE60")]
		public bool TryGetPackageBundleByBundleName(string bundleName, out PackageBundle result)
		{
			return default(bool);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1BACED0", Offset = "0x1BAC2D0", VA = "0x181BACED0")]
		public bool TryGetPackageBundleByFileName(string fileName, out PackageBundle result)
		{
			return default(bool);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1BACD90", Offset = "0x1BAC190", VA = "0x181BACD90")]
		public bool IsIncludeBundleFile(string cacheGUID)
		{
			return default(bool);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x1BAC670", Offset = "0x1BABA70", VA = "0x181BAC670")]
		public AssetInfo[] GetAssetsInfoByTags(string[] tags)
		{
			return null;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1BAC170", Offset = "0x1BAB570", VA = "0x181BAC170")]
		public AssetInfo ConvertLocationToAssetInfo(string location, Type assetType)
		{
			return null;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1BAC040", Offset = "0x1BAB440", VA = "0x181BAC040")]
		private string ConvertLocationToAssetInfoMapping(string location)
		{
			return null;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1BABDC0", Offset = "0x1BAB1C0", VA = "0x181BABDC0")]
		public AssetInfo ConvertAssetGUIDToAssetInfo(string assetGUID, Type assetType)
		{
			return null;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1BABCB0", Offset = "0x1BAB0B0", VA = "0x181BABCB0")]
		private string ConvertAssetGUIDToAssetInfoMapping(string assetGUID)
		{
			return null;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1BAC890", Offset = "0x1BABC90", VA = "0x181BAC890")]
		public string[] GetBundleIncludeAssets(string assetPath)
		{
			return null;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1BACB80", Offset = "0x1BABF80", VA = "0x181BACB80")]
		public bool IsBundleMultiplyAssets(string location)
		{
			return default(bool);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1BAC3A0", Offset = "0x1BAB7A0", VA = "0x181BAC3A0")]
		[Attribute(Name = "ConditionalAttribute", RVA = "0x8FAD0", Offset = "0x8EED0")]
		private void DebugCheckLocation(string location)
		{
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1BACFF0", Offset = "0x1BAC3F0", VA = "0x181BACFF0")]
		public PackageManifest()
		{
		}

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x10")]
		public string FileVersion;

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x18")]
		public bool EnableAddressable;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x19")]
		public bool LocationToLower;

		// Token: 0x0400030F RID: 783
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x1A")]
		public bool IncludeAssetGUID;

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x1C")]
		public int OutputNameStyle;

		// Token: 0x04000311 RID: 785
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x20")]
		public string BuildPipeline;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x28")]
		public string PackageName;

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x30")]
		public string PackageVersion;

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x38")]
		public List<PackageAsset> AssetList;

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x40")]
		public List<PackageBundle> BundleList;

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Dictionary<string, PackageBundle> BundleDic1;

		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Dictionary<string, PackageBundle> BundleDic2;

		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Dictionary<string, PackageAsset> AssetDic;

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public Dictionary<string, string> AssetPathMapping1;

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Dictionary<string, string> AssetPathMapping2;

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public HashSet<string> CacheGUIDs;
	}
}
