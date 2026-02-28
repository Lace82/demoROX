using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000AD RID: 173
	[Token(Token = "0x2000082")]
	public abstract class ITMGContext
	{
		// Token: 0x060004DB RID: 1243 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x2760DE0", Offset = "0x27601E0", VA = "0x182760DE0")]
		public static ITMGContext GetInstance()
		{
			return null;
		}

		// Token: 0x060004DC RID: 1244
		[Token(Token = "0x6000402")]
		public abstract int Poll();

		// Token: 0x060004DD RID: 1245
		[Token(Token = "0x6000403")]
		public abstract int Pause();

		// Token: 0x060004DE RID: 1246
		[Token(Token = "0x6000404")]
		public abstract int Resume();

		// Token: 0x060004DF RID: 1247
		[Token(Token = "0x6000405")]
		public abstract string GetSDKVersion();

		// Token: 0x060004E0 RID: 1248
		[Token(Token = "0x6000406")]
		public abstract void SetAppVersion(string sAppVersion);

		// Token: 0x060004E1 RID: 1249
		[Token(Token = "0x6000407")]
		public abstract void SetRegion(string region);

		// Token: 0x060004E2 RID: 1250
		[Token(Token = "0x6000408")]
		public abstract void SetHost(string chatHost, string pttHost);

		// Token: 0x060004E3 RID: 1251
		[Token(Token = "0x6000409")]
		public abstract int SetLogLevel(int levelWrite, int levelPrint);

		// Token: 0x060004E4 RID: 1252
		[Token(Token = "0x600040A")]
		public abstract int SetLogPath(string logDir);

		// Token: 0x060004E5 RID: 1253
		[Token(Token = "0x600040B")]
		public abstract int Init(string sdkAppID, string openID);

		// Token: 0x060004E6 RID: 1254
		[Token(Token = "0x600040C")]
		public abstract int Uninit();

		// Token: 0x060004E7 RID: 1255
		[Token(Token = "0x600040D")]
		public abstract bool IsRoomEntered();

		// Token: 0x060004E8 RID: 1256
		[Token(Token = "0x600040E")]
		public abstract int EnterRoom(string roomID, ITMGRoomType roomType, byte[] authBuffer);

		// Token: 0x060004E9 RID: 1257
		[Token(Token = "0x600040F")]
		public abstract int ExitRoom();

		// Token: 0x060004EA RID: 1258
		[Token(Token = "0x6000410")]
		public abstract int SetAdvanceParams(string KeyCode, string value);

		// Token: 0x060004EB RID: 1259
		[Token(Token = "0x6000411")]
		public abstract string GetAdvanceParams(string KeyCode);

		// Token: 0x060004EC RID: 1260
		[Token(Token = "0x6000412")]
		public abstract int TrackingVolume(float trackingTimeS);

		// Token: 0x060004ED RID: 1261
		[Token(Token = "0x6000413")]
		public abstract int StopTrackingVolume();

		// Token: 0x060004EE RID: 1262
		[Token(Token = "0x6000414")]
		public abstract int StartRealTimeASR();

		// Token: 0x060004EF RID: 1263
		[Token(Token = "0x6000415")]
		public abstract int StartRealTimeASR(string language);

		// Token: 0x060004F0 RID: 1264
		[Token(Token = "0x6000416")]
		public abstract int StopRealTimeASR();

		// Token: 0x060004F1 RID: 1265
		[Token(Token = "0x6000417")]
		public abstract int InitAgeDectection(string strBinaryPath, string strParamPath);

		// Token: 0x060004F2 RID: 1266
		[Token(Token = "0x6000418")]
		public abstract int EnableAgeDectection(bool bEnable);

		// Token: 0x060004F3 RID: 1267
		[Token(Token = "0x6000419")]
		public abstract ITMGRoom GetRoom();

		// Token: 0x060004F4 RID: 1268
		[Token(Token = "0x600041A")]
		public abstract ITMGAudioCtrl GetAudioCtrl();

		// Token: 0x060004F5 RID: 1269
		[Token(Token = "0x600041B")]
		public abstract ITMGAudioEffectCtrl GetAudioEffectCtrl();

		// Token: 0x060004F6 RID: 1270
		[Token(Token = "0x600041C")]
		public abstract ITMGRoomManager GetRoomManager();

		// Token: 0x060004F7 RID: 1271
		[Token(Token = "0x600041D")]
		public abstract ITMG_RECORD_PERMISSION CheckMicPermission();

		// Token: 0x060004F8 RID: 1272
		[Token(Token = "0x600041E")]
		public abstract ITMGPTT GetPttCtrl();

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060004F9 RID: 1273
		// (remove) Token: 0x060004FA RID: 1274
		[Token(Token = "0x1400000A")]
		public abstract event QAVEnterRoomComplete OnEnterRoomCompleteEvent;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060004FB RID: 1275
		// (remove) Token: 0x060004FC RID: 1276
		[Token(Token = "0x1400000B")]
		public abstract event QAVExitRoomComplete OnExitRoomCompleteEvent;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060004FD RID: 1277
		// (remove) Token: 0x060004FE RID: 1278
		[Token(Token = "0x1400000C")]
		public abstract event QAVRoomDisconnect OnRoomDisconnectEvent;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060004FF RID: 1279
		// (remove) Token: 0x06000500 RID: 1280
		[Token(Token = "0x1400000D")]
		public abstract event QAVEndpointsUpdateInfo OnEndpointsUpdateInfoEvent;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000501 RID: 1281
		// (remove) Token: 0x06000502 RID: 1282
		[Token(Token = "0x1400000E")]
		public abstract event QAVOnRoomTypeChangedEvent OnRoomTypeChangedEvent;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000503 RID: 1283
		// (remove) Token: 0x06000504 RID: 1284
		[Token(Token = "0x1400000F")]
		public abstract event QAVAudioReadyCallback OnAudioReadyEvent;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000505 RID: 1285
		// (remove) Token: 0x06000506 RID: 1286
		[Token(Token = "0x14000010")]
		public abstract event QAVRoomChangeQualityCallback OnRoomChangeQualityEvent;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000507 RID: 1287
		// (remove) Token: 0x06000508 RID: 1288
		[Token(Token = "0x14000011")]
		public abstract event QAVCommonEventCallback OnCommonEventCallback;

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000509 RID: 1289
		// (remove) Token: 0x0600050A RID: 1290
		[Token(Token = "0x14000012")]
		public abstract event QAVOnEventCallBack onEventCallBack;

		// Token: 0x0600050B RID: 1291
		[Token(Token = "0x6000431")]
		public abstract int SetRecvMixStreamCount(int nCount);

		// Token: 0x0600050C RID: 1292
		[Token(Token = "0x6000432")]
		public abstract int SetRangeAudioMode(ITMGRangeAudioMode gameAudioMode);

		// Token: 0x0600050D RID: 1293
		[Token(Token = "0x6000433")]
		public abstract int SetRangeAudioTeamID(int teamID);

		// Token: 0x0600050E RID: 1294
		[Token(Token = "0x6000434")]
		public abstract int SetAudioRole(ITMG_AUDIO_MEMBER_ROLE role);

		// Token: 0x0600050F RID: 1295
		[Token(Token = "0x6000435")]
		public abstract ITMG_CHECK_MIC_STATUS CheckMic();

		// Token: 0x06000510 RID: 1296
		[Token(Token = "0x6000436")]
		public abstract int SetLicenseForPlugins(string license, string secretKey);

		// Token: 0x06000511 RID: 1297
		[Token(Token = "0x6000437")]
		public abstract int InitFaceTracker(string license, string secretKey);

		// Token: 0x06000512 RID: 1298
		[Token(Token = "0x6000438")]
		public abstract ITMGFaceTracker CreateFaceTracker(string modelDirPath, string configFileName);

		// Token: 0x06000513 RID: 1299
		[Token(Token = "0x6000439")]
		public abstract ITMGPoseTracker CreatePoseTracker(string bodyModelPath, string bodyModelBinPath, string poseModelPath, string poseModelBinPath, string smootherModePath, string smootherModeBinPath);

		// Token: 0x06000514 RID: 1300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		protected ITMGContext()
		{
		}

		// Token: 0x04000343 RID: 835
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x0")]
		public static string IENGINE_VERSION;

		// Token: 0x04000344 RID: 836
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x8")]
		public static int LOG_LEVEL_NONE;

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0xC")]
		public static int LOG_LEVEL_ERROR;

		// Token: 0x04000346 RID: 838
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x10")]
		public static int LOG_LEVEL_INFO;

		// Token: 0x04000347 RID: 839
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x14")]
		public static int LOG_LEVEL_DEBUG;

		// Token: 0x04000348 RID: 840
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x18")]
		public static int LOG_LEVEL_VERBOSE;

		// Token: 0x04000349 RID: 841
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x1C")]
		public static int EVENT_ID_ENDPOINT_ENTER;

		// Token: 0x0400034A RID: 842
		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x20")]
		public static int EVENT_ID_ENDPOINT_EXIT;

		// Token: 0x0400034B RID: 843
		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x24")]
		public static int EVENT_ID_ENDPOINT_HAS_AUDIO;

		// Token: 0x0400034C RID: 844
		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x28")]
		public static int EVENT_ID_ENDPOINT_NO_AUDIO;

		// Token: 0x0400034D RID: 845
		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x2C")]
		public static int EVENT_ID_ENDPOINT_MIC_OPENED;

		// Token: 0x0400034E RID: 846
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x30")]
		public static int EVENT_ID_ENDPOINT_MIC_CLOSED;
	}
}
