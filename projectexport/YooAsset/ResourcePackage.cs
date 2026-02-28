using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace YooAsset
{
	// Token: 0x020000C5 RID: 197
	[Token(Token = "0x2000091")]
	public class ResourcePackage
	{
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x1700009E")]
		public EOperationStatus InitializeStatus
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0xCC2F30", Offset = "0xCC2330", VA = "0x180CC2F30")]
			get
			{
				return EOperationStatus.None;
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1BB8CD0", Offset = "0x1BB80D0", VA = "0x181BB8CD0")]
		private ResourcePackage()
		{
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1BB8C20", Offset = "0x1BB8020", VA = "0x181BB8C20")]
		internal ResourcePackage(string packageName)
		{
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1BB8BE0", Offset = "0x1BB7FE0", VA = "0x181BB8BE0")]
		internal void UpdatePackage()
		{
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1BB6880", Offset = "0x1BB5C80", VA = "0x181BB6880")]
		internal void DestroyPackage()
		{
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1BB6DC0", Offset = "0x1BB61C0", VA = "0x181BB6DC0")]
		public InitializationOperation InitializeAsync(InitializeParameters parameters)
		{
			return null;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1BB8880", Offset = "0x1BB7C80", VA = "0x181BB8880")]
		private void ResetInitializeAfterFailed()
		{
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1BB4E50", Offset = "0x1BB4250", VA = "0x181BB4E50")]
		private void CheckInitializeParameters(InitializeParameters parameters)
		{
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1BB76F0", Offset = "0x1BB6AF0", VA = "0x181BB76F0")]
		private void InitializeOperation_Completed(AsyncOperationBase op)
		{
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1BB8B10", Offset = "0x1BB7F10", VA = "0x181BB8B10")]
		public UpdatePackageVersionOperation UpdatePackageVersionAsync(bool appendTimeTicks = true, int timeout = 60)
		{
			return null;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1BB89B0", Offset = "0x1BB7DB0", VA = "0x181BB89B0")]
		public UpdatePackageManifestOperation UpdatePackageManifestAsync(string packageVersion, bool autoSaveVersion = true, int timeout = 60)
		{
			return null;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1BB8560", Offset = "0x1BB7960", VA = "0x181BB8560")]
		public PreDownloadContentOperation PreDownloadContentAsync(string packageVersion, int timeout = 60)
		{
			return null;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1BB53E0", Offset = "0x1BB47E0", VA = "0x181BB53E0")]
		public ClearUnusedCacheFilesOperation ClearUnusedCacheFilesAsync()
		{
			return null;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1BB5260", Offset = "0x1BB4660", VA = "0x181BB5260")]
		public ClearAllCacheFilesOperation ClearAllCacheFilesAsync()
		{
			return null;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1BB6D10", Offset = "0x1BB6110", VA = "0x181BB6D10")]
		public string GetPackageVersion()
		{
			return null;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1BB6D70", Offset = "0x1BB6170", VA = "0x181BB6D70")]
		public bool HasActiveManifest()
		{
			return default(bool);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1BB8990", Offset = "0x1BB7D90", VA = "0x181BB8990")]
		public void UnloadUnusedAssets()
		{
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1BB8910", Offset = "0x1BB7D10", VA = "0x181BB8910")]
		public void TryUnloadUnusedAsset(string location)
		{
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1BB88F0", Offset = "0x1BB7CF0", VA = "0x181BB88F0")]
		public void TryUnloadUnusedAsset(AssetInfo assetInfo)
		{
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1BB69C0", Offset = "0x1BB5DC0", VA = "0x181BB69C0")]
		public void ForceUnloadAllAssets()
		{
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1BB6CD0", Offset = "0x1BB60D0", VA = "0x181BB6CD0")]
		public string GetPackageBuildinRootDirectory()
		{
			return null;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x1BB6CF0", Offset = "0x1BB60F0", VA = "0x181BB6CF0")]
		public string GetPackageSandboxRootDirectory()
		{
			return null;
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1BB5380", Offset = "0x1BB4780", VA = "0x181BB5380")]
		public void ClearPackageSandbox()
		{
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1BB7970", Offset = "0x1BB6D70", VA = "0x181BB7970")]
		public bool IsNeedDownloadFromRemote(string location)
		{
			return default(bool);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1BB79F0", Offset = "0x1BB6DF0", VA = "0x181BB79F0")]
		public bool IsNeedDownloadFromRemote(AssetInfo assetInfo)
		{
			return default(bool);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1BB8630", Offset = "0x1BB7A30", VA = "0x181BB8630")]
		public bool QueryAssetFromRemote(string location, DownloaderOperation downloader, Action<int> callback, bool sync)
		{
			return default(bool);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1BB6AE0", Offset = "0x1BB5EE0", VA = "0x181BB6AE0")]
		public AssetInfo[] GetAssetInfos(string tag)
		{
			return null;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1BB6BC0", Offset = "0x1BB5FC0", VA = "0x181BB6BC0")]
		public AssetInfo[] GetAssetInfos(string[] tags)
		{
			return null;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1BB6A60", Offset = "0x1BB5E60", VA = "0x181BB6A60")]
		public AssetInfo GetAssetInfo(string location)
		{
			return null;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1BB6AD0", Offset = "0x1BB5ED0", VA = "0x181BB6AD0")]
		public AssetInfo GetAssetInfo(string location, Type type)
		{
			return null;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1BB69E0", Offset = "0x1BB5DE0", VA = "0x181BB69E0")]
		public AssetInfo GetAssetInfoByGUID(string assetGUID)
		{
			return null;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1BB6A50", Offset = "0x1BB5E50", VA = "0x181BB6A50")]
		public AssetInfo GetAssetInfoByGUID(string assetGUID, Type type)
		{
			return null;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1BB51E0", Offset = "0x1BB45E0", VA = "0x181BB51E0")]
		public bool CheckLocationValid(string location)
		{
			return default(bool);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1BB7720", Offset = "0x1BB6B20", VA = "0x181BB7720")]
		public bool IsBundleMultiplyAssets(string location)
		{
			return default(bool);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1BB7840", Offset = "0x1BB6C40", VA = "0x181BB7840")]
		private bool IsNeedDownloadFromRemoteInternal(AssetInfo assetInfo)
		{
			return default(bool);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1BB8130", Offset = "0x1BB7530", VA = "0x181BB8130")]
		public RawFileHandle LoadRawFileSync(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1BB8080", Offset = "0x1BB7480", VA = "0x181BB8080")]
		public RawFileHandle LoadRawFileSync(string location)
		{
			return null;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1BB7FF0", Offset = "0x1BB73F0", VA = "0x181BB7FF0")]
		public RawFileHandle LoadRawFileAsync(AssetInfo assetInfo, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1BB7F60", Offset = "0x1BB7360", VA = "0x181BB7F60")]
		public RawFileHandle LoadRawFileAsync(string location, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1BB8010", Offset = "0x1BB7410", VA = "0x181BB8010")]
		private RawFileHandle LoadRawFileInternal(AssetInfo assetInfo, bool waitForAsyncComplete, uint priority)
		{
			return null;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1BB8180", Offset = "0x1BB7580", VA = "0x181BB8180")]
		public SceneHandle LoadSceneAsync(string location, LoadSceneMode sceneMode = LoadSceneMode.Single, bool suspendLoad = false, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1BB8230", Offset = "0x1BB7630", VA = "0x181BB8230")]
		public SceneHandle LoadSceneAsync(AssetInfo assetInfo, LoadSceneMode sceneMode = LoadSceneMode.Single, bool suspendLoad = false, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1BB7F20", Offset = "0x1BB7320", VA = "0x181BB7F20")]
		public AssetHandle LoadAssetSync(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000431")]
		public AssetHandle LoadAssetSync<TObject>(string location) where TObject : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1BB7ED0", Offset = "0x1BB72D0", VA = "0x181BB7ED0")]
		public AssetHandle LoadAssetSync(string location, Type type)
		{
			return null;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1BB7E10", Offset = "0x1BB7210", VA = "0x181BB7E10")]
		public AssetHandle LoadAssetSync(string location)
		{
			return null;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1BB7DA0", Offset = "0x1BB71A0", VA = "0x181BB7DA0")]
		public AssetHandle LoadAssetAsync(AssetInfo assetInfo, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000435")]
		public AssetHandle LoadAssetAsync<TObject>(string location, uint priority = 0U) where TObject : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1BB7CB0", Offset = "0x1BB70B0", VA = "0x181BB7CB0")]
		public AssetHandle LoadAssetAsync(string location, Type type, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1BB7CF0", Offset = "0x1BB70F0", VA = "0x181BB7CF0")]
		public AssetHandle LoadAssetAsync(string location, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1BB7DC0", Offset = "0x1BB71C0", VA = "0x181BB7DC0")]
		private AssetHandle LoadAssetInternal(AssetInfo assetInfo, bool waitForAsyncComplete, uint priority)
		{
			return null;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1BB8440", Offset = "0x1BB7840", VA = "0x181BB8440")]
		public SubAssetsHandle LoadSubAssetsSync(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600043A")]
		public SubAssetsHandle LoadSubAssetsSync<TObject>(string location) where TObject : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1BB83E0", Offset = "0x1BB77E0", VA = "0x181BB83E0")]
		public SubAssetsHandle LoadSubAssetsSync(string location, Type type)
		{
			return null;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1BB8490", Offset = "0x1BB7890", VA = "0x181BB8490")]
		public SubAssetsHandle LoadSubAssetsSync(string location)
		{
			return null;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x1BB8260", Offset = "0x1BB7660", VA = "0x181BB8260")]
		public SubAssetsHandle LoadSubAssetsAsync(AssetInfo assetInfo, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600043E")]
		public SubAssetsHandle LoadSubAssetsAsync<TObject>(string location, uint priority = 0U) where TObject : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1BB8330", Offset = "0x1BB7730", VA = "0x181BB8330")]
		public SubAssetsHandle LoadSubAssetsAsync(string location, Type type, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1BB8280", Offset = "0x1BB7680", VA = "0x181BB8280")]
		public SubAssetsHandle LoadSubAssetsAsync(string location, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1BB8370", Offset = "0x1BB7770", VA = "0x181BB8370")]
		private SubAssetsHandle LoadSubAssetsInternal(AssetInfo assetInfo, bool waitForAsyncComplete, uint priority)
		{
			return null;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x1BB7B60", Offset = "0x1BB6F60", VA = "0x181BB7B60")]
		public AllAssetsHandle LoadAllAssetsSync(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000443")]
		public AllAssetsHandle LoadAllAssetsSync<TObject>(string location) where TObject : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x1BB7BA0", Offset = "0x1BB6FA0", VA = "0x181BB7BA0")]
		public AllAssetsHandle LoadAllAssetsSync(string location, Type type)
		{
			return null;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1BB7BF0", Offset = "0x1BB6FF0", VA = "0x181BB7BF0")]
		public AllAssetsHandle LoadAllAssetsSync(string location)
		{
			return null;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x1BB7A40", Offset = "0x1BB6E40", VA = "0x181BB7A40")]
		public AllAssetsHandle LoadAllAssetsAsync(AssetInfo assetInfo, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000447")]
		public AllAssetsHandle LoadAllAssetsAsync<TObject>(string location, uint priority = 0U) where TObject : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x1BB7A00", Offset = "0x1BB6E00", VA = "0x181BB7A00")]
		public AllAssetsHandle LoadAllAssetsAsync(string location, Type type, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x1BB7A60", Offset = "0x1BB6E60", VA = "0x181BB7A60")]
		public AllAssetsHandle LoadAllAssetsAsync(string location, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1BB7B10", Offset = "0x1BB6F10", VA = "0x181BB7B10")]
		private AllAssetsHandle LoadAllAssetsInternal(AssetInfo assetInfo, bool waitForAsyncComplete, uint priority)
		{
			return null;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1BB5D60", Offset = "0x1BB5160", VA = "0x181BB5D60")]
		public ResourceDownloaderOperation CreateResourceDownloader(int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x1BB5ED0", Offset = "0x1BB52D0", VA = "0x181BB5ED0")]
		public ResourceDownloaderOperation CreateResourceDownloader(string tag, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x1BB5E40", Offset = "0x1BB5240", VA = "0x181BB5E40")]
		public ResourceDownloaderOperation CreateResourceDownloader(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x1BB5BD0", Offset = "0x1BB4FD0", VA = "0x181BB5BD0")]
		public ResourceDownloaderOperation CreateResourceDownloaderWithoutTags(string tag, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1BB5CD0", Offset = "0x1BB50D0", VA = "0x181BB5CD0")]
		public ResourceDownloaderOperation CreateResourceDownloaderWithoutTags(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1BB5A80", Offset = "0x1BB4E80", VA = "0x181BB5A80")]
		public ResourceDownloaderOperation CreateResourceDownloaderWithTagFilter(Predicate<string[]> filter, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1BB5930", Offset = "0x1BB4D30", VA = "0x181BB5930")]
		public ResourceDownloaderOperation CreateBundleDownloader(string location, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1BB5690", Offset = "0x1BB4A90", VA = "0x181BB5690")]
		public ResourceDownloaderOperation CreateBundleDownloader(string[] locations, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1BB5830", Offset = "0x1BB4C30", VA = "0x181BB5830")]
		public ResourceDownloaderOperation CreateBundleDownloader(AssetInfo assetInfo, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x1BB5600", Offset = "0x1BB4A00", VA = "0x181BB5600")]
		public ResourceDownloaderOperation CreateBundleDownloader(AssetInfo[] assetInfos, int downloadingMaxNumber, int failedTryAgain, int timeout = 60)
		{
			return null;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x1BB61C0", Offset = "0x1BB55C0", VA = "0x181BB61C0")]
		public ResourceUnpackerOperation CreateResourceUnpacker(int unpackingMaxNumber, int failedTryAgain)
		{
			return null;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x1BB60C0", Offset = "0x1BB54C0", VA = "0x181BB60C0")]
		public ResourceUnpackerOperation CreateResourceUnpacker(string tag, int unpackingMaxNumber, int failedTryAgain)
		{
			return null;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x1BB6290", Offset = "0x1BB5690", VA = "0x181BB6290")]
		public ResourceUnpackerOperation CreateResourceUnpacker(string[] tags, int unpackingMaxNumber, int failedTryAgain)
		{
			return null;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x1BB5FD0", Offset = "0x1BB53D0", VA = "0x181BB5FD0")]
		public ResourceImporterOperation CreateResourceImporter(string[] filePaths, int importerMaxNumber, int failedTryAgain)
		{
			return null;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1BB7790", Offset = "0x1BB6B90", VA = "0x181BB7790")]
		internal bool IsIncludeBundleFile(string cacheGUID)
		{
			return default(bool);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1BB5580", Offset = "0x1BB4980", VA = "0x181BB5580")]
		private AssetInfo ConvertLocationToAssetInfo(string location, Type assetType)
		{
			return null;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1BB5500", Offset = "0x1BB4900", VA = "0x181BB5500")]
		private AssetInfo ConvertAssetGUIDToAssetInfo(string assetGUID, Type assetType)
		{
			return null;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x1BB6630", Offset = "0x1BB5A30", VA = "0x181BB6630")]
		[Attribute(Name = "ConditionalAttribute", RVA = "0x8FAD0", Offset = "0x8EED0")]
		private void DebugCheckInitialize(bool checkActiveManifest = true)
		{
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x1BB6750", Offset = "0x1BB5B50", VA = "0x181BB6750")]
		[Attribute(Name = "ConditionalAttribute", RVA = "0x8FAD0", Offset = "0x8EED0")]
		private void DebugCheckRawFileLoadMethod(string method)
		{
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1BB6320", Offset = "0x1BB5720", VA = "0x181BB6320")]
		[Attribute(Name = "ConditionalAttribute", RVA = "0x8FAD0", Offset = "0x8EED0")]
		private void DebugCheckAssetLoadMethod(string method)
		{
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1BB6450", Offset = "0x1BB5850", VA = "0x181BB6450")]
		[Attribute(Name = "ConditionalAttribute", RVA = "0x8FAD0", Offset = "0x8EED0")]
		private void DebugCheckAssetLoadType(Type type)
		{
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1BB6C30", Offset = "0x1BB6030", VA = "0x181BB6C30")]
		internal DebugPackageData GetDebugPackageData()
		{
			return null;
		}

		// Token: 0x04000332 RID: 818
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x10")]
		private bool _isInitialize;

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x18")]
		private string _initializeError;

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x20")]
		private EOperationStatus _initializeStatus;

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x24")]
		private EPlayMode _playMode;

		// Token: 0x04000336 RID: 822
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x28")]
		private CacheManager _cacheMgr;

		// Token: 0x04000337 RID: 823
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x30")]
		private PersistentManager _persistentMgr;

		// Token: 0x04000338 RID: 824
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x38")]
		private DownloadManager _downloadMgr;

		// Token: 0x04000339 RID: 825
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x40")]
		private ResourceManager _resourceMgr;

		// Token: 0x0400033A RID: 826
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x48")]
		private ResourceLoader _resourceLoader;

		// Token: 0x0400033B RID: 827
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x50")]
		private IBundleQuery _bundleQuery;

		// Token: 0x0400033C RID: 828
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x58")]
		private IPlayMode _playModeImpl;

		// Token: 0x0400033D RID: 829
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x60")]
		public readonly string PackageName;

		// Token: 0x0400033E RID: 830
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x68")]
		private readonly List<BundleInfo> _queryDownloadTasks;

		// Token: 0x020000C6 RID: 198
		[Token(Token = "0x20000DE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private sealed class <>c__DisplayClass88_0
		{
			// Token: 0x0600047F RID: 1151 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000538")]
			[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
			public <>c__DisplayClass88_0()
			{
			}

			// Token: 0x06000480 RID: 1152 RVA: 0x00002CD0 File Offset: 0x00000ED0
			[Token(Token = "0x6000539")]
			[Address(RVA = "0x1BBAB00", Offset = "0x1BB9F00", VA = "0x181BBAB00")]
			internal bool <CreateResourceDownloaderWithTagFilter>b__0(PackageBundle packageBundle)
			{
				return default(bool);
			}

			// Token: 0x0400033F RID: 831
			[Token(Token = "0x400036A")]
			[FieldOffset(Offset = "0x10")]
			public Predicate<string[]> filter;
		}
	}
}
