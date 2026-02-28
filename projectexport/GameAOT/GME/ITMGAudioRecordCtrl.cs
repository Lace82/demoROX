using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x02000093 RID: 147
	[Token(Token = "0x2000068")]
	public abstract class ITMGAudioRecordCtrl
	{
		// Token: 0x0600048B RID: 1163 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x2760D40", Offset = "0x2760140", VA = "0x182760D40")]
		public static ITMGAudioRecordCtrl GetInstance()
		{
			return null;
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600048C RID: 1164
		// (remove) Token: 0x0600048D RID: 1165
		[Token(Token = "0x14000002")]
		public abstract event QAVAudioRecordCallback OnAudioRecordComplete;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600048E RID: 1166
		// (remove) Token: 0x0600048F RID: 1167
		[Token(Token = "0x14000003")]
		public abstract event QAVAudioRecordPreviewCallback OnAudioRecordPreviewComplete;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000490 RID: 1168
		// (remove) Token: 0x06000491 RID: 1169
		[Token(Token = "0x14000004")]
		public abstract event QAVAudioRecordMixCallback OnAudioRecordMixComplete;

		// Token: 0x06000492 RID: 1170
		[Token(Token = "0x60003B8")]
		public abstract int StartRecord(ITMGRecordingType type, string dstFile, string accMixFile, string accPlayFile);

		// Token: 0x06000493 RID: 1171
		[Token(Token = "0x60003B9")]
		public abstract int StopRecord();

		// Token: 0x06000494 RID: 1172
		[Token(Token = "0x60003BA")]
		public abstract int PauseRecord();

		// Token: 0x06000495 RID: 1173
		[Token(Token = "0x60003BB")]
		public abstract int ResumeRecord();

		// Token: 0x06000496 RID: 1174
		[Token(Token = "0x60003BC")]
		public abstract int SetAccompanyFile(string accMixFile);

		// Token: 0x06000497 RID: 1175
		[Token(Token = "0x60003BD")]
		public abstract int GetAccompanyTotalTimeByMs();

		// Token: 0x06000498 RID: 1176
		[Token(Token = "0x60003BE")]
		public abstract int GetRecordTimeByMs();

		// Token: 0x06000499 RID: 1177
		[Token(Token = "0x60003BF")]
		public abstract int SetRecordTimeByMs(int timePlay, int timeRecord);

		// Token: 0x0600049A RID: 1178
		[Token(Token = "0x60003C0")]
		public abstract int SetRecordKaraokeType(int type);

		// Token: 0x0600049B RID: 1179
		[Token(Token = "0x60003C1")]
		public abstract int GetRecordFileDurationByMs();

		// Token: 0x0600049C RID: 1180
		[Token(Token = "0x60003C2")]
		public abstract int StartPreview();

		// Token: 0x0600049D RID: 1181
		[Token(Token = "0x60003C3")]
		public abstract int StopPreview();

		// Token: 0x0600049E RID: 1182
		[Token(Token = "0x60003C4")]
		public abstract int PausePreview();

		// Token: 0x0600049F RID: 1183
		[Token(Token = "0x60003C5")]
		public abstract int ResumePreview();

		// Token: 0x060004A0 RID: 1184
		[Token(Token = "0x60003C6")]
		public abstract int SetPreviewTimeByMs(int time);

		// Token: 0x060004A1 RID: 1185
		[Token(Token = "0x60003C7")]
		public abstract int GetPreviewTimeByMs();

		// Token: 0x060004A2 RID: 1186
		[Token(Token = "0x60003C8")]
		public abstract int SetMixWeights(float mic, float acc);

		// Token: 0x060004A3 RID: 1187
		[Token(Token = "0x60003C9")]
		public abstract int AdjustAudioTimeByMs(int time);

		// Token: 0x060004A4 RID: 1188
		[Token(Token = "0x60003CA")]
		public abstract int MixRecordFile(bool needMicData);

		// Token: 0x060004A5 RID: 1189
		[Token(Token = "0x60003CB")]
		public abstract int CancelMixRecordFile();

		// Token: 0x060004A6 RID: 1190
		[Token(Token = "0x60003CC")]
		public abstract int CleanTask();

		// Token: 0x060004A7 RID: 1191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		protected ITMGAudioRecordCtrl()
		{
		}
	}
}
