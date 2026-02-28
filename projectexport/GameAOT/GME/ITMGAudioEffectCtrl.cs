using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000B0 RID: 176
	[Token(Token = "0x2000085")]
	public abstract class ITMGAudioEffectCtrl
	{
		// Token: 0x14000017 RID: 23
		// (add) Token: 0x0600055F RID: 1375
		// (remove) Token: 0x06000560 RID: 1376
		[Token(Token = "0x14000017")]
		public abstract event QAVAccompanyFileCompleteHandler OnAccompanyFileCompleteHandler;

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000561 RID: 1377
		// (remove) Token: 0x06000562 RID: 1378
		[Token(Token = "0x14000018")]
		public abstract event QAVFetchVoiceChangerListCallback OnFetchVoiceChangerListCallback;

		// Token: 0x06000563 RID: 1379
		[Token(Token = "0x6000489")]
		public abstract int StartAccompany(string filePath, bool loopBack, int loopCount, int duckerTimeMs);

		// Token: 0x06000564 RID: 1380
		[Token(Token = "0x600048A")]
		public abstract int StopAccompany(int duckerTimeMs);

		// Token: 0x06000565 RID: 1381
		[Token(Token = "0x600048B")]
		public abstract bool IsAccompanyPlayEnd();

		// Token: 0x06000566 RID: 1382
		[Token(Token = "0x600048C")]
		public abstract int PauseAccompany();

		// Token: 0x06000567 RID: 1383
		[Token(Token = "0x600048D")]
		public abstract int ResumeAccompany();

		// Token: 0x06000568 RID: 1384
		[Token(Token = "0x600048E")]
		public abstract int EnableAccompanyPlay(bool enable);

		// Token: 0x06000569 RID: 1385
		[Token(Token = "0x600048F")]
		public abstract int EnableAccompanyLoopBack(bool enable);

		// Token: 0x0600056A RID: 1386
		[Token(Token = "0x6000490")]
		public abstract int SetAccompanyKey(int nKey);

		// Token: 0x0600056B RID: 1387
		[Token(Token = "0x6000491")]
		public abstract int SetAccompanyVolume(int vol);

		// Token: 0x0600056C RID: 1388
		[Token(Token = "0x6000492")]
		public abstract int GetAccompanyVolume();

		// Token: 0x0600056D RID: 1389
		[Token(Token = "0x6000493")]
		public abstract uint GetAccompanyFileTotalTimeByMs();

		// Token: 0x0600056E RID: 1390
		[Token(Token = "0x6000494")]
		public abstract uint GetAccompanyFileCurrentPlayedTimeByMs();

		// Token: 0x0600056F RID: 1391
		[Token(Token = "0x6000495")]
		public abstract uint GetAccompanyFileTotalTimeByMs(string openId);

		// Token: 0x06000570 RID: 1392
		[Token(Token = "0x6000496")]
		public abstract uint GetAccompanyFileCurrentPlayedTimeByMs(string openId);

		// Token: 0x06000571 RID: 1393
		[Token(Token = "0x6000497")]
		public abstract int SetAccompanyFileCurrentPlayedTimeByMs(uint time);

		// Token: 0x06000572 RID: 1394
		[Token(Token = "0x6000498")]
		public abstract int GetEffectsVolume();

		// Token: 0x06000573 RID: 1395
		[Token(Token = "0x6000499")]
		public abstract int SetEffectsVolume(int volume);

		// Token: 0x06000574 RID: 1396
		[Token(Token = "0x600049A")]
		public abstract int GetEffectVolume(int soundId);

		// Token: 0x06000575 RID: 1397
		[Token(Token = "0x600049B")]
		public abstract int SetEffectVolume(int soundId, int volume);

		// Token: 0x06000576 RID: 1398
		[Token(Token = "0x600049C")]
		public abstract int PlayEffect(int soundId, string filePath, bool loop = false, double pitch = 1.0, double pan = 0.0, int volume = 100);

		// Token: 0x06000577 RID: 1399
		[Token(Token = "0x600049D")]
		public abstract int PauseEffect(int soundId);

		// Token: 0x06000578 RID: 1400
		[Token(Token = "0x600049E")]
		public abstract int PauseAllEffects();

		// Token: 0x06000579 RID: 1401
		[Token(Token = "0x600049F")]
		public abstract int ResumeEffect(int soundId);

		// Token: 0x0600057A RID: 1402
		[Token(Token = "0x60004A0")]
		public abstract int ResumeAllEffects();

		// Token: 0x0600057B RID: 1403
		[Token(Token = "0x60004A1")]
		public abstract int StopEffect(int soundId);

		// Token: 0x0600057C RID: 1404
		[Token(Token = "0x60004A2")]
		public abstract int StopAllEffects();

		// Token: 0x0600057D RID: 1405
		[Token(Token = "0x60004A3")]
		public abstract int EnableEffectSend(int soundId, bool enable);

		// Token: 0x0600057E RID: 1406
		[Token(Token = "0x60004A4")]
		public abstract int SetEffectFileCurrentPlayedTimeByMs(int soundId, uint timeMs);

		// Token: 0x0600057F RID: 1407
		[Token(Token = "0x60004A5")]
		public abstract int GetEffectFileCurrentPlayedTimeByMs(int soundId);

		// Token: 0x06000580 RID: 1408
		[Token(Token = "0x60004A6")]
		public abstract int StartRecord(string filePath, int sampleRate, int channels, bool recordLocalMic, bool recordRemote, bool recordAccompany);

		// Token: 0x06000581 RID: 1409
		[Token(Token = "0x60004A7")]
		public abstract int StopRecord();

		// Token: 0x06000582 RID: 1410
		[Token(Token = "0x60004A8")]
		public abstract int PauseRecord();

		// Token: 0x06000583 RID: 1411
		[Token(Token = "0x60004A9")]
		public abstract int ResumeRecord();

		// Token: 0x06000584 RID: 1412
		[Token(Token = "0x60004AA")]
		public abstract int EnableRecordLocalMic(bool recordLocalMic);

		// Token: 0x06000585 RID: 1413
		[Token(Token = "0x60004AB")]
		public abstract int EnableRecordAccompany(bool recordAccompany);

		// Token: 0x06000586 RID: 1414
		[Token(Token = "0x60004AC")]
		public abstract int EnableRecordRemote(bool recordRemote);

		// Token: 0x06000587 RID: 1415
		[Token(Token = "0x60004AD")]
		public abstract int InitVoiceChanger(string dataPath);

		// Token: 0x06000588 RID: 1416
		[Token(Token = "0x60004AE")]
		public abstract int FetchVoiceChangerList();

		// Token: 0x06000589 RID: 1417
		[Token(Token = "0x60004AF")]
		public abstract int SetVoiceChangerName(string voiceName);

		// Token: 0x0600058A RID: 1418
		[Token(Token = "0x60004B0")]
		public abstract string GetVoiceChangerParams();

		// Token: 0x0600058B RID: 1419
		[Token(Token = "0x60004B1")]
		public abstract float GetVoiceChangerParamValue(string param);

		// Token: 0x0600058C RID: 1420
		[Token(Token = "0x60004B2")]
		public abstract int SetVoiceChangerParamValue(string voiceName, float value);

		// Token: 0x0600058D RID: 1421
		[Token(Token = "0x60004B3")]
		public abstract int SetVoiceType(int voiceType);

		// Token: 0x0600058E RID: 1422
		[Token(Token = "0x60004B4")]
		public abstract int SetKaraokeType(int type);

		// Token: 0x0600058F RID: 1423
		[Token(Token = "0x60004B5")]
		public abstract int SetKaraokeType(ITMG_VOICE_TYPE_EQUALIZER equalizer, ITMG_VOICE_TYPE_REVERB reverb);

		// Token: 0x06000590 RID: 1424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		protected ITMGAudioEffectCtrl()
		{
		}

		// Token: 0x04000354 RID: 852
		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x0")]
		public static int VOICE_TYPE_ORIGINAL_SOUND;

		// Token: 0x04000355 RID: 853
		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x4")]
		public static int VOICE_TYPE_LOLITA;

		// Token: 0x04000356 RID: 854
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x8")]
		public static int VOICE_TYPE_UNCLE;

		// Token: 0x04000357 RID: 855
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0xC")]
		public static int VOICE_TYPE_INTANGIBLE;

		// Token: 0x04000358 RID: 856
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x10")]
		public static int VOICE_TYPE_DEAD_FATBOY;

		// Token: 0x04000359 RID: 857
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x14")]
		public static int VOICE_TYPE_HEAVY_MENTAL;

		// Token: 0x0400035A RID: 858
		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x18")]
		public static int VOICE_TYPE_DIALECT;

		// Token: 0x0400035B RID: 859
		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x1C")]
		public static int VOICE_TYPE_INFLUENZA;

		// Token: 0x0400035C RID: 860
		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x20")]
		public static int VOICE_TYPE_CAGED_ANIMAL;

		// Token: 0x0400035D RID: 861
		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x24")]
		public static int VOICE_TYPE_HEAVY_MACHINE;

		// Token: 0x0400035E RID: 862
		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x28")]
		public static int VOICE_TYPE_STRONG_CURRENT;

		// Token: 0x0400035F RID: 863
		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x2C")]
		public static int VOICE_TYPE_KINDER_GARTEN;

		// Token: 0x04000360 RID: 864
		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x30")]
		public static int VOICE_TYPE_HUANG;

		// Token: 0x04000361 RID: 865
		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x34")]
		public static int KARAOKE_TYPE_ORIGINAL;

		// Token: 0x04000362 RID: 866
		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x38")]
		public static int KARAOKE_TYPE_POP;

		// Token: 0x04000363 RID: 867
		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x3C")]
		public static int KARAOKE_TYPE_ROCK;

		// Token: 0x04000364 RID: 868
		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x40")]
		public static int KARAOKE_TYPE_RB;

		// Token: 0x04000365 RID: 869
		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x44")]
		public static int KARAOKE_TYPE_DANCE;

		// Token: 0x04000366 RID: 870
		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x48")]
		public static int KARAOKE_TYPE_HEAVEN;

		// Token: 0x04000367 RID: 871
		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x4C")]
		public static int KARAOKE_TYPE_TTS;
	}
}
