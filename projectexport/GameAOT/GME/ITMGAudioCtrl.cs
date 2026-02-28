using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000AF RID: 175
	[Token(Token = "0x2000084")]
	public abstract class ITMGAudioCtrl
	{
		// Token: 0x0600052C RID: 1324
		[Token(Token = "0x6000452")]
		public abstract int EnableMic(bool isEnabled);

		// Token: 0x0600052D RID: 1325
		[Token(Token = "0x6000453")]
		public abstract int GetMicState();

		// Token: 0x0600052E RID: 1326
		[Token(Token = "0x6000454")]
		public abstract int EnableSpeaker(bool isEnabled);

		// Token: 0x0600052F RID: 1327
		[Token(Token = "0x6000455")]
		public abstract int GetSpeakerState();

		// Token: 0x06000530 RID: 1328
		[Token(Token = "0x6000456")]
		public abstract int CheckDeviceMuteState();

		// Token: 0x06000531 RID: 1329
		[Token(Token = "0x6000457")]
		public abstract int EnableAudioCaptureDevice(bool enabled);

		// Token: 0x06000532 RID: 1330
		[Token(Token = "0x6000458")]
		public abstract int EnableAudioPlayDevice(bool enabled);

		// Token: 0x06000533 RID: 1331
		[Token(Token = "0x6000459")]
		public abstract bool IsAudioCaptureDeviceEnabled();

		// Token: 0x06000534 RID: 1332
		[Token(Token = "0x600045A")]
		public abstract bool IsAudioPlayDeviceEnabled();

		// Token: 0x06000535 RID: 1333
		[Token(Token = "0x600045B")]
		public abstract int EnableAudioSend(bool isEnabled);

		// Token: 0x06000536 RID: 1334
		[Token(Token = "0x600045C")]
		public abstract int EnableAudioRecv(bool isEnabled);

		// Token: 0x06000537 RID: 1335
		[Token(Token = "0x600045D")]
		public abstract bool IsAudioSendEnabled();

		// Token: 0x06000538 RID: 1336
		[Token(Token = "0x600045E")]
		public abstract bool IsAudioRecvEnabled();

		// Token: 0x06000539 RID: 1337
		[Token(Token = "0x600045F")]
		public abstract int GetMicLevel();

		// Token: 0x0600053A RID: 1338
		[Token(Token = "0x6000460")]
		public abstract int SetMicVolume(int volume);

		// Token: 0x0600053B RID: 1339
		[Token(Token = "0x6000461")]
		public abstract int GetMicVolume();

		// Token: 0x0600053C RID: 1340
		[Token(Token = "0x6000462")]
		public abstract int GetSpeakerLevel();

		// Token: 0x0600053D RID: 1341
		[Token(Token = "0x6000463")]
		public abstract int SetSpeakerVolume(int volume);

		// Token: 0x0600053E RID: 1342
		[Token(Token = "0x6000464")]
		public abstract int GetSpeakerVolume();

		// Token: 0x0600053F RID: 1343
		[Token(Token = "0x6000465")]
		public abstract int SetSpeakerVolumeByOpenID(string openid, int volume);

		// Token: 0x06000540 RID: 1344
		[Token(Token = "0x6000466")]
		public abstract int GetSpeakerVolumeByOpenID(string openid);

		// Token: 0x06000541 RID: 1345
		[Token(Token = "0x6000467")]
		public abstract int GetVolumeById(string openid);

		// Token: 0x06000542 RID: 1346
		[Token(Token = "0x6000468")]
		public abstract int EnableLoopBack(bool enable);

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000543 RID: 1347
		// (remove) Token: 0x06000544 RID: 1348
		[Token(Token = "0x14000015")]
		public abstract event QAVAudioRouteChangeCallback OnAudioRouteChangeComplete;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000545 RID: 1349
		// (remove) Token: 0x06000546 RID: 1350
		[Token(Token = "0x14000016")]
		public abstract event QAVAudioIOSMuteSwitchResultCallback OnIOSMuteSwitchResult;

		// Token: 0x06000547 RID: 1351
		[Token(Token = "0x600046D")]
		public abstract int AddAudioBlackList(string openId);

		// Token: 0x06000548 RID: 1352
		[Token(Token = "0x600046E")]
		public abstract int RemoveAudioBlackList(string openId);

		// Token: 0x06000549 RID: 1353
		[Token(Token = "0x600046F")]
		public abstract bool IsOpenIdInAudioBlackList(string openId);

		// Token: 0x0600054A RID: 1354
		[Token(Token = "0x6000470")]
		public abstract int GetSendStreamLevel();

		// Token: 0x0600054B RID: 1355
		[Token(Token = "0x6000471")]
		public abstract int GetRecvStreamLevel(string openId);

		// Token: 0x0600054C RID: 1356
		[Token(Token = "0x6000472")]
		public abstract int InitSpatializer(string modelPath);

		// Token: 0x0600054D RID: 1357
		[Token(Token = "0x6000473")]
		public abstract int EnableSpatializer(bool enable, bool applyTeam);

		// Token: 0x0600054E RID: 1358
		[Token(Token = "0x6000474")]
		public abstract bool IsEnableSpatializer();

		// Token: 0x0600054F RID: 1359
		[Token(Token = "0x6000475")]
		public abstract int SetAudioMixCount(int nCount);

		// Token: 0x06000550 RID: 1360
		[Token(Token = "0x6000476")]
		public abstract int AddSameTeamSpatializer(string openId);

		// Token: 0x06000551 RID: 1361
		[Token(Token = "0x6000477")]
		public abstract int RemoveSameTeamSpatializer(string openId);

		// Token: 0x06000552 RID: 1362
		[Token(Token = "0x6000478")]
		public abstract int AddSpatializerBlacklist(string openId);

		// Token: 0x06000553 RID: 1363
		[Token(Token = "0x6000479")]
		public abstract int RemoveSpatializerBlacklist(string openId);

		// Token: 0x06000554 RID: 1364
		[Token(Token = "0x600047A")]
		public abstract int ClearSpatializerBlacklist();

		// Token: 0x06000555 RID: 1365
		[Token(Token = "0x600047B")]
		public abstract int EnableAudioDispatcher(bool enable);

		// Token: 0x06000556 RID: 1366
		[Token(Token = "0x600047C")]
		public abstract int GetMicListCount();

		// Token: 0x06000557 RID: 1367
		[Token(Token = "0x600047D")]
		public abstract int GetMicList(out List<TMGAudioDeviceInfo> devicesInfo, int count);

		// Token: 0x06000558 RID: 1368
		[Token(Token = "0x600047E")]
		public abstract int SelectMic(string micID);

		// Token: 0x06000559 RID: 1369
		[Token(Token = "0x600047F")]
		public abstract int GetSpeakerListCount();

		// Token: 0x0600055A RID: 1370
		[Token(Token = "0x6000480")]
		public abstract int GetSpeakerList(out List<TMGAudioDeviceInfo> devicesInfo, int count);

		// Token: 0x0600055B RID: 1371
		[Token(Token = "0x6000481")]
		public abstract int SelectSpeaker(string speaker);

		// Token: 0x0600055C RID: 1372
		[Token(Token = "0x6000482")]
		public abstract int EnableMixSystemAudioToSend(bool enable);

		// Token: 0x0600055D RID: 1373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		protected ITMGAudioCtrl()
		{
		}

		// Token: 0x0400034F RID: 847
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x0")]
		public static int AUDIOROUTE_OTHERS;

		// Token: 0x04000350 RID: 848
		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x4")]
		public static int AUDIOROUTE_BUILDINRECIEVER;

		// Token: 0x04000351 RID: 849
		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x8")]
		public static int AUDIOROUTE_SPEAKER;

		// Token: 0x04000352 RID: 850
		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0xC")]
		public static int AUDIOROUTE_HEADPHONE;

		// Token: 0x04000353 RID: 851
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x10")]
		public static int AUDIOROUTE_BLUETOOTH;
	}
}
