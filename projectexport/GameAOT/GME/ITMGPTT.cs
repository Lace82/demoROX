using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000B1 RID: 177
	[Token(Token = "0x2000086")]
	public abstract class ITMGPTT
	{
		// Token: 0x06000593 RID: 1427 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x2760FD0", Offset = "0x27603D0", VA = "0x182760FD0")]
		public static ITMGPTT GetInstance()
		{
			return null;
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06000594 RID: 1428
		// (remove) Token: 0x06000595 RID: 1429
		[Token(Token = "0x14000019")]
		public abstract event QAVRecordFileCompleteCallback OnRecordFileComplete;

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000596 RID: 1430
		// (remove) Token: 0x06000597 RID: 1431
		[Token(Token = "0x1400001A")]
		public abstract event QAVUploadFileCompleteCallback OnUploadFileComplete;

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06000598 RID: 1432
		// (remove) Token: 0x06000599 RID: 1433
		[Token(Token = "0x1400001B")]
		public abstract event QAVDownloadFileCompleteCallback OnDownloadFileComplete;

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x0600059A RID: 1434
		// (remove) Token: 0x0600059B RID: 1435
		[Token(Token = "0x1400001C")]
		public abstract event QAVPlayFileCompleteCallback OnPlayFileComplete;

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x0600059C RID: 1436
		// (remove) Token: 0x0600059D RID: 1437
		[Token(Token = "0x1400001D")]
		public abstract event QAVSpeechToTextCallback OnSpeechToTextComplete;

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x0600059E RID: 1438
		// (remove) Token: 0x0600059F RID: 1439
		[Token(Token = "0x1400001E")]
		public abstract event QAVStreamingRecognitionCallback OnStreamingSpeechComplete;

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x060005A0 RID: 1440
		// (remove) Token: 0x060005A1 RID: 1441
		[Token(Token = "0x1400001F")]
		public abstract event QAVStreamingRecognitionCallback OnStreamingSpeechisRunning;

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x060005A2 RID: 1442
		// (remove) Token: 0x060005A3 RID: 1443
		[Token(Token = "0x14000020")]
		public abstract event QAVDownloadFileWithAuditCompleteCallback OnDownloadFileAuditComplete;

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x060005A4 RID: 1444
		// (remove) Token: 0x060005A5 RID: 1445
		[Token(Token = "0x14000021")]
		public abstract event QAVSpeechToTextWithAuditCallback OnSpeechToTextAuditComplete;

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x060005A6 RID: 1446
		// (remove) Token: 0x060005A7 RID: 1447
		[Token(Token = "0x14000022")]
		public abstract event QAVSpeechToTextWithTargetTextCallback OnSpeechToTextTargetTextComplete;

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x060005A8 RID: 1448
		// (remove) Token: 0x060005A9 RID: 1449
		[Token(Token = "0x14000023")]
		public abstract event QAVTranslateTextCallback OnTranslateTextComplete;

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x060005AA RID: 1450
		// (remove) Token: 0x060005AB RID: 1451
		[Token(Token = "0x14000024")]
		public abstract event QAVTextToSpeechCallback OnTextToSpeechComplete;

		// Token: 0x060005AC RID: 1452
		[Token(Token = "0x60004D2")]
		public abstract int ApplyPTTAuthbuffer(byte[] authBuffer);

		// Token: 0x060005AD RID: 1453
		[Token(Token = "0x60004D3")]
		public abstract int SetMaxMessageLength(int msTime);

		// Token: 0x060005AE RID: 1454
		[Token(Token = "0x60004D4")]
		public abstract int SetPTTSourceLanguage(string sourceLanguage);

		// Token: 0x060005AF RID: 1455
		[Token(Token = "0x60004D5")]
		public abstract int StartRecording(string filePath);

		// Token: 0x060005B0 RID: 1456
		[Token(Token = "0x60004D6")]
		public abstract int StopRecording();

		// Token: 0x060005B1 RID: 1457
		[Token(Token = "0x60004D7")]
		public abstract int CancelRecording();

		// Token: 0x060005B2 RID: 1458
		[Token(Token = "0x60004D8")]
		public abstract int UploadRecordedFile(string filePath);

		// Token: 0x060005B3 RID: 1459
		[Token(Token = "0x60004D9")]
		public abstract int DownloadRecordedFile(string fileID, string downloadFilePath);

		// Token: 0x060005B4 RID: 1460
		[Token(Token = "0x60004DA")]
		public abstract int PlayRecordedFile(string filePath);

		// Token: 0x060005B5 RID: 1461
		[Token(Token = "0x60004DB")]
		public abstract int PlayRecordedFile(string filePath, int voiceType);

		// Token: 0x060005B6 RID: 1462
		[Token(Token = "0x60004DC")]
		public abstract int StopPlayFile();

		// Token: 0x060005B7 RID: 1463
		[Token(Token = "0x60004DD")]
		public abstract int SpeechToText(string fileID);

		// Token: 0x060005B8 RID: 1464
		[Token(Token = "0x60004DE")]
		public abstract int SpeechToText(string fileID, string speechLanguage);

		// Token: 0x060005B9 RID: 1465
		[Token(Token = "0x60004DF")]
		public abstract int SpeechToText(string fileID, string speechLanguage, string translatelanguage);

		// Token: 0x060005BA RID: 1466
		[Token(Token = "0x60004E0")]
		public abstract int GetFileSize(string filePath);

		// Token: 0x060005BB RID: 1467
		[Token(Token = "0x60004E1")]
		public abstract int GetVoiceFileDuration(string filePath);

		// Token: 0x060005BC RID: 1468
		[Token(Token = "0x60004E2")]
		public abstract int StartRecordingWithStreamingRecognition(string filePath);

		// Token: 0x060005BD RID: 1469
		[Token(Token = "0x60004E3")]
		public abstract int StartRecordingWithStreamingRecognition(string filePath, string speechLanguage);

		// Token: 0x060005BE RID: 1470
		[Token(Token = "0x60004E4")]
		public abstract int StartRecordingWithStreamingRecognition(string filePath, string speechLanguage, string translatelanguage);

		// Token: 0x060005BF RID: 1471
		[Token(Token = "0x60004E5")]
		public abstract int TranslateText(string text, string sourceLanguage, string translateLanguage);

		// Token: 0x060005C0 RID: 1472
		[Token(Token = "0x60004E6")]
		public abstract int GetMicLevel();

		// Token: 0x060005C1 RID: 1473
		[Token(Token = "0x60004E7")]
		public abstract int SetMicVolume(int volume);

		// Token: 0x060005C2 RID: 1474
		[Token(Token = "0x60004E8")]
		public abstract int GetMicVolume();

		// Token: 0x060005C3 RID: 1475
		[Token(Token = "0x60004E9")]
		public abstract int GetSpeakerLevel();

		// Token: 0x060005C4 RID: 1476
		[Token(Token = "0x60004EA")]
		public abstract int SetSpeakerVolume(int volume);

		// Token: 0x060005C5 RID: 1477
		[Token(Token = "0x60004EB")]
		public abstract int GetSpeakerVolume();

		// Token: 0x060005C6 RID: 1478
		[Token(Token = "0x60004EC")]
		public abstract int PauseRecording();

		// Token: 0x060005C7 RID: 1479
		[Token(Token = "0x60004ED")]
		public abstract int ResumeRecording();

		// Token: 0x060005C8 RID: 1480
		[Token(Token = "0x60004EE")]
		public abstract int TextToSpeech(string text, string voiceName, string languageCode, float speakingRate);

		// Token: 0x060005C9 RID: 1481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		protected ITMGPTT()
		{
		}
	}
}
