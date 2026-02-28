using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace YooAsset
{
	// Token: 0x020000DD RID: 221
	[Token(Token = "0x20000A8")]
	public static class YooAssets
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x170000A3")]
		public static bool Initialized
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x389CD10", Offset = "0x389C110", VA = "0x18389CD10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x389B840", Offset = "0x389AC40", VA = "0x18389B840")]
		public static void Initialize([Optional] ILogger logger)
		{
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x389AED0", Offset = "0x389A2D0", VA = "0x18389AED0")]
		public static void Destroy()
		{
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x389CB20", Offset = "0x389BF20", VA = "0x18389CB20")]
		public static void Update(float deltaTime)
		{
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x389A750", Offset = "0x3899B50", VA = "0x18389A750")]
		public static ResourcePackage CreatePackage(string packageName)
		{
			return null;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x389B7A0", Offset = "0x389ABA0", VA = "0x18389B7A0")]
		public static ResourcePackage GetPackage(string packageName)
		{
			return null;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x389CAC0", Offset = "0x389BEC0", VA = "0x18389CAC0")]
		public static ResourcePackage TryGetPackage(string packageName)
		{
			return null;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x389AE10", Offset = "0x389A210", VA = "0x18389AE10")]
		public static void DestroyPackage(string packageName)
		{
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x389A460", Offset = "0x3899860", VA = "0x18389A460")]
		public static bool ContainsPackage(string packageName)
		{
			return default(bool);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x389CA50", Offset = "0x389BE50", VA = "0x18389CA50")]
		public static void StartOperation(GameAsyncOperation operation)
		{
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x389B5F0", Offset = "0x389A9F0", VA = "0x18389B5F0")]
		private static ResourcePackage GetPackageInternal(string packageName)
		{
			return null;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x389A310", Offset = "0x3899710", VA = "0x18389A310")]
		private static void CheckException(string packageName)
		{
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x389C860", Offset = "0x389BC60", VA = "0x18389C860")]
		public static void SetDownloadSystemClearFileResponseCode(List<long> codes)
		{
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x389C900", Offset = "0x389BD00", VA = "0x18389C900")]
		public static void SetDownloadSystemUnityWebRequest(DownloadRequestDelegate requestDelegate)
		{
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x389C970", Offset = "0x389BD70", VA = "0x18389C970")]
		public static void SetOperationSystemMaxTimeSlice(long milliseconds)
		{
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x389C790", Offset = "0x389BB90", VA = "0x18389C790")]
		public static void SetCacheSystemDisableCacheOnWebGL()
		{
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x389B470", Offset = "0x389A870", VA = "0x18389B470")]
		internal static DebugReport GetDebugReport()
		{
			return null;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x389C7F0", Offset = "0x389BBF0", VA = "0x18389C7F0")]
		public static void SetDefaultPackage(ResourcePackage package)
		{
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x389BA20", Offset = "0x389AE20", VA = "0x18389BA20")]
		public static bool IsNeedDownloadFromRemote(string location)
		{
			return default(bool);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x389B9A0", Offset = "0x389ADA0", VA = "0x18389B9A0")]
		public static bool IsNeedDownloadFromRemote(AssetInfo assetInfo)
		{
			return default(bool);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x389B370", Offset = "0x389A770", VA = "0x18389B370")]
		public static AssetInfo[] GetAssetInfos(string tag)
		{
			return null;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x389B3F0", Offset = "0x389A7F0", VA = "0x18389B3F0")]
		public static AssetInfo[] GetAssetInfos(string[] tags)
		{
			return null;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x389B260", Offset = "0x389A660", VA = "0x18389B260")]
		public static AssetInfo GetAssetInfo(string location)
		{
			return null;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x389B2E0", Offset = "0x389A6E0", VA = "0x18389B2E0")]
		public static AssetInfo GetAssetInfo(string location, Type type)
		{
			return null;
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x389B1E0", Offset = "0x389A5E0", VA = "0x18389B1E0")]
		public static AssetInfo GetAssetInfoByGUID(string assetGUID)
		{
			return null;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x389B150", Offset = "0x389A550", VA = "0x18389B150")]
		public static AssetInfo GetAssetInfoByGUID(string assetGUID, Type type)
		{
			return null;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x389A3E0", Offset = "0x38997E0", VA = "0x18389A3E0")]
		public static bool CheckLocationValid(string location)
		{
			return default(bool);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x389C200", Offset = "0x389B600", VA = "0x18389C200")]
		public static RawFileHandle LoadRawFileSync(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x389C280", Offset = "0x389B680", VA = "0x18389C280")]
		public static RawFileHandle LoadRawFileSync(string location)
		{
			return null;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x389C180", Offset = "0x389B580", VA = "0x18389C180")]
		public static RawFileHandle LoadRawFileAsync(AssetInfo assetInfo, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x389C100", Offset = "0x389B500", VA = "0x18389C100")]
		public static RawFileHandle LoadRawFileAsync(string location, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x389C300", Offset = "0x389B700", VA = "0x18389C300")]
		public static SceneHandle LoadSceneAsync(string location, LoadSceneMode sceneMode = LoadSceneMode.Single, bool suspendLoad = false, uint priority = 100U)
		{
			return null;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x389C3B0", Offset = "0x389B7B0", VA = "0x18389C3B0")]
		public static SceneHandle LoadSceneAsync(AssetInfo assetInfo, LoadSceneMode sceneMode = LoadSceneMode.Single, bool suspendLoad = false, uint priority = 100U)
		{
			return null;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x389C000", Offset = "0x389B400", VA = "0x18389C000")]
		public static AssetHandle LoadAssetSync(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004F2")]
		public static AssetHandle LoadAssetSync<TObject>(string location) where TObject : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x389BF70", Offset = "0x389B370", VA = "0x18389BF70")]
		public static AssetHandle LoadAssetSync(string location, Type type)
		{
			return null;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x389C080", Offset = "0x389B480", VA = "0x18389C080")]
		public static AssetHandle LoadAssetSync(string location)
		{
			return null;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x389BE70", Offset = "0x389B270", VA = "0x18389BE70")]
		public static AssetHandle LoadAssetAsync(AssetInfo assetInfo, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004F6")]
		public static AssetHandle LoadAssetAsync<TObject>(string location, uint priority = 0U) where TObject : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x389BDD0", Offset = "0x389B1D0", VA = "0x18389BDD0")]
		public static AssetHandle LoadAssetAsync(string location, Type type, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x389BEF0", Offset = "0x389B2F0", VA = "0x18389BEF0")]
		public static AssetHandle LoadAssetAsync(string location, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x389C600", Offset = "0x389BA00", VA = "0x18389C600")]
		public static SubAssetsHandle LoadSubAssetsSync(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004FA")]
		public static SubAssetsHandle LoadSubAssetsSync<TObject>(string location) where TObject : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x389C680", Offset = "0x389BA80", VA = "0x18389C680")]
		public static SubAssetsHandle LoadSubAssetsSync(string location, Type type)
		{
			return null;
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x389C710", Offset = "0x389BB10", VA = "0x18389C710")]
		public static SubAssetsHandle LoadSubAssetsSync(string location)
		{
			return null;
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x389C4E0", Offset = "0x389B8E0", VA = "0x18389C4E0")]
		public static SubAssetsHandle LoadSubAssetsAsync(AssetInfo assetInfo, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004FE")]
		public static SubAssetsHandle LoadSubAssetsAsync<TObject>(string location, uint priority = 0U) where TObject : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x389C560", Offset = "0x389B960", VA = "0x18389C560")]
		public static SubAssetsHandle LoadSubAssetsAsync(string location, Type type, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x389C460", Offset = "0x389B860", VA = "0x18389C460")]
		public static SubAssetsHandle LoadSubAssetsAsync(string location, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x389BCC0", Offset = "0x389B0C0", VA = "0x18389BCC0")]
		public static AllAssetsHandle LoadAllAssetsSync(AssetInfo assetInfo)
		{
			return null;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000502")]
		public static AllAssetsHandle LoadAllAssetsSync<TObject>(string location) where TObject : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x389BD40", Offset = "0x389B140", VA = "0x18389BD40")]
		public static AllAssetsHandle LoadAllAssetsSync(string location, Type type)
		{
			return null;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x389BC40", Offset = "0x389B040", VA = "0x18389BC40")]
		public static AllAssetsHandle LoadAllAssetsSync(string location)
		{
			return null;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x389BAA0", Offset = "0x389AEA0", VA = "0x18389BAA0")]
		public static AllAssetsHandle LoadAllAssetsAsync(AssetInfo assetInfo, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000506")]
		public static AllAssetsHandle LoadAllAssetsAsync<TObject>(string location, uint priority = 0U) where TObject : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x389BB20", Offset = "0x389AF20", VA = "0x18389BB20")]
		public static AllAssetsHandle LoadAllAssetsAsync(string location, Type type, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x389BBC0", Offset = "0x389AFC0", VA = "0x18389BBC0")]
		public static AllAssetsHandle LoadAllAssetsAsync(string location, uint priority = 0U)
		{
			return null;
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x389AA80", Offset = "0x3899E80", VA = "0x18389AA80")]
		public static ResourceDownloaderOperation CreateResourceDownloader(int downloadingMaxNumber, int failedTryAgain)
		{
			return null;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x389A960", Offset = "0x3899D60", VA = "0x18389A960")]
		public static ResourceDownloaderOperation CreateResourceDownloader(string tag, int downloadingMaxNumber, int failedTryAgain)
		{
			return null;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x389A8C0", Offset = "0x3899CC0", VA = "0x18389A8C0")]
		public static ResourceDownloaderOperation CreateResourceDownloader(string[] tags, int downloadingMaxNumber, int failedTryAgain)
		{
			return null;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x389A570", Offset = "0x3899970", VA = "0x18389A570")]
		public static ResourceDownloaderOperation CreateBundleDownloader(string location, int downloadingMaxNumber, int failedTryAgain)
		{
			return null;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x389A4D0", Offset = "0x38998D0", VA = "0x18389A4D0")]
		public static ResourceDownloaderOperation CreateBundleDownloader(string[] locations, int downloadingMaxNumber, int failedTryAgain)
		{
			return null;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x389A610", Offset = "0x3899A10", VA = "0x18389A610")]
		public static ResourceDownloaderOperation CreateBundleDownloader(AssetInfo assetInfo, int downloadingMaxNumber, int failedTryAgain)
		{
			return null;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x389A6B0", Offset = "0x3899AB0", VA = "0x18389A6B0")]
		public static ResourceDownloaderOperation CreateBundleDownloader(AssetInfo[] assetInfos, int downloadingMaxNumber, int failedTryAgain)
		{
			return null;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x389ABB0", Offset = "0x3899FB0", VA = "0x18389ABB0")]
		public static ResourceUnpackerOperation CreateResourceUnpacker(int unpackingMaxNumber, int failedTryAgain)
		{
			return null;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x389AC30", Offset = "0x389A030", VA = "0x18389AC30")]
		public static ResourceUnpackerOperation CreateResourceUnpacker(string tag, int unpackingMaxNumber, int failedTryAgain)
		{
			return null;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x389ACD0", Offset = "0x389A0D0", VA = "0x18389ACD0")]
		public static ResourceUnpackerOperation CreateResourceUnpacker(string[] tags, int unpackingMaxNumber, int failedTryAgain)
		{
			return null;
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x389AB10", Offset = "0x3899F10", VA = "0x18389AB10")]
		public static ResourceImporterOperation CreateResourceImporter(string[] filePaths, int importerMaxNumber, int failedTryAgain)
		{
			return null;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x389AD70", Offset = "0x389A170", VA = "0x18389AD70")]
		[Attribute(Name = "ConditionalAttribute", RVA = "0x8FAD0", Offset = "0x8EED0")]
		private static void DebugCheckDefaultPackageValid()
		{
		}

		// Token: 0x04000364 RID: 868
		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _isInitialize;

		// Token: 0x04000365 RID: 869
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static GameObject _driver;

		// Token: 0x04000366 RID: 870
		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly List<ResourcePackage> _packages;

		// Token: 0x04000367 RID: 871
		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static int SyncDownTimeOut;

		// Token: 0x04000368 RID: 872
		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<byte[], byte[]> DecryptFunc;

		// Token: 0x04000369 RID: 873
		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static ResourcePackage _defaultPackage;
	}
}
