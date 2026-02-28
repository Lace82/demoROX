using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.SceneManagement;

namespace YooAsset
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x200005D")]
	internal class ResourceManager
	{
		// Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1BB4D60", Offset = "0x1BB4160", VA = "0x181BB4D60")]
		public ResourceManager(string packageName)
		{
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1BB3550", Offset = "0x1BB2950", VA = "0x181BB3550")]
		public void Initialize(bool simulationOnEditor, bool autoDestroyAssetProvider, IBundleQuery bundleServices)
		{
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1BB4BC0", Offset = "0x1BB3FC0", VA = "0x181BB4BC0")]
		public void Update()
		{
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1BB4A30", Offset = "0x1BB3E30", VA = "0x181BB4A30")]
		public void UnloadUnusedAssets()
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1BB4220", Offset = "0x1BB3620", VA = "0x181BB4220")]
		public void TryUnloadUnusedAsset(AssetInfo assetInfo)
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1BB2BD0", Offset = "0x1BB1FD0", VA = "0x181BB2BD0")]
		public void ForceUnloadAllAssets()
		{
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1BB3B40", Offset = "0x1BB2F40", VA = "0x181BB3B40")]
		public SceneHandle LoadSceneAsync(AssetInfo assetInfo, LoadSceneMode sceneMode, bool suspendLoad, uint priority)
		{
			return null;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1BB3760", Offset = "0x1BB2B60", VA = "0x181BB3760")]
		public AssetHandle LoadAssetAsync(AssetInfo assetInfo, uint priority)
		{
			return null;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1BB3E10", Offset = "0x1BB3210", VA = "0x181BB3E10")]
		public SubAssetsHandle LoadSubAssetsAsync(AssetInfo assetInfo, uint priority)
		{
			return null;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1BB3570", Offset = "0x1BB2970", VA = "0x181BB3570")]
		public AllAssetsHandle LoadAllAssetsAsync(AssetInfo assetInfo, uint priority)
		{
			return null;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1BB3950", Offset = "0x1BB2D50", VA = "0x181BB3950")]
		public RawFileHandle LoadRawFileAsync(AssetInfo assetInfo, uint priority)
		{
			return null;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1BB4710", Offset = "0x1BB3B10", VA = "0x181BB4710")]
		internal void UnloadSubScene(string sceneName)
		{
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1BB45B0", Offset = "0x1BB39B0", VA = "0x181BB45B0")]
		private void UnloadAllScene()
		{
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1BB2570", Offset = "0x1BB1970", VA = "0x181BB2570")]
		private void ClearSceneHandle()
		{
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1BB2B60", Offset = "0x1BB1F60", VA = "0x181BB2B60")]
		internal BundleLoaderBase CreateOwnerAssetBundleLoader(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1BB2A60", Offset = "0x1BB1E60", VA = "0x181BB2A60")]
		internal List<BundleLoaderBase> CreateDependAssetBundleLoaders(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1BB4000", Offset = "0x1BB3400", VA = "0x181BB4000")]
		internal void RemoveBundleProviders(List<ProviderBase> removeList)
		{
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1BB3510", Offset = "0x1BB2910", VA = "0x181BB3510")]
		internal bool HasAnyLoader()
		{
			return default(bool);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1BB28B0", Offset = "0x1BB1CB0", VA = "0x181BB28B0")]
		private BundleLoaderBase CreateAssetBundleLoaderInternal(BundleInfo bundleInfo)
		{
			return null;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1BB4120", Offset = "0x1BB3520", VA = "0x181BB4120")]
		private BundleLoaderBase TryGetAssetBundleLoader(string bundleName)
		{
			return null;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1BB41A0", Offset = "0x1BB35A0", VA = "0x181BB41A0")]
		private ProviderBase TryGetProvider(string providerGUID)
		{
			return null;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1BB3280", Offset = "0x1BB2680", VA = "0x181BB3280")]
		internal List<DebugProviderInfo> GetDebugReportInfos()
		{
			return null;
		}

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, SceneHandle> _sceneHandles;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x8")]
		private static long _sceneCreateCount;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, ProviderBase> _providerDic;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<string, BundleLoaderBase> _loaderDic;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<BundleLoaderBase> _loaderList;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x28")]
		private bool _simulationOnEditor;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x29")]
		private bool _autoDestroyAssetProvider;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x30")]
		private IBundleQuery _bundleQuery;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x38")]
		public readonly string PackageName;
	}
}
