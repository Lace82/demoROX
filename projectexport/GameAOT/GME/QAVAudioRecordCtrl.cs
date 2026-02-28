using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x02000097 RID: 151
	[Token(Token = "0x200006C")]
	public class QAVAudioRecordCtrl : ITMGAudioRecordCtrl
	{
		// Token: 0x060004AF RID: 1199 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x276A390", Offset = "0x2769790", VA = "0x18276A390")]
		public new static QAVAudioRecordCtrl GetInstance()
		{
			return null;
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060004B0 RID: 1200 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004B1 RID: 1201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000006")]
		public override event QAVAudioRecordCallback OnAudioRecordComplete
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x276AAE0", Offset = "0x2769EE0", VA = "0x18276AAE0", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x276ACC0", Offset = "0x276A0C0", VA = "0x18276ACC0", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x276AEA0", Offset = "0x276A2A0", VA = "0x18276AEA0")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x1DC600", Offset = "0x1DBA00")]
		private static void s_OnAudioRecordComplete(int code, string dstfile, int durationMs)
		{
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060004B3 RID: 1203 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004B4 RID: 1204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000007")]
		public override event QAVAudioRecordPreviewCallback OnAudioRecordPreviewComplete
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x276AC20", Offset = "0x276A020", VA = "0x18276AC20", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x276AE00", Offset = "0x276A200", VA = "0x18276AE00", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x276B170", Offset = "0x276A570", VA = "0x18276B170")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x1DCE30", Offset = "0x1DC230")]
		private static void s_OnAudioRecordPreviewComplete(int code)
		{
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060004B6 RID: 1206 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004B7 RID: 1207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000008")]
		public override event QAVAudioRecordMixCallback OnAudioRecordMixComplete
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x276AB80", Offset = "0x2769F80", VA = "0x18276AB80", Slot = "8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x276AD60", Offset = "0x276A160", VA = "0x18276AD60", Slot = "9")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x276B000", Offset = "0x276A400", VA = "0x18276B000")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x1DD7B0", Offset = "0x1DCBB0")]
		private static void s_OnAudioRecordMixComplete(int code, string dstfile, string micFile, int durationMs)
		{
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x276A920", Offset = "0x2769D20", VA = "0x18276A920", Slot = "10")]
		public override int StartRecord(ITMGRecordingType type, string dstFile, string accMixFile, string accPlayFile)
		{
			return 0;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x276AA30", Offset = "0x2769E30", VA = "0x18276AA30", Slot = "11")]
		public override int StopRecord()
		{
			return 0;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x276A5D0", Offset = "0x27699D0", VA = "0x18276A5D0", Slot = "12")]
		public override int PauseRecord()
		{
			return 0;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x276A670", Offset = "0x2769A70", VA = "0x18276A670", Slot = "13")]
		public override int ResumeRecord()
		{
			return 0;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x276A6C0", Offset = "0x2769AC0", VA = "0x18276A6C0", Slot = "14")]
		public override int SetAccompanyFile(string accMixFile)
		{
			return 0;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x276A340", Offset = "0x2769740", VA = "0x18276A340", Slot = "15")]
		public override int GetAccompanyTotalTimeByMs()
		{
			return 0;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x276A490", Offset = "0x2769890", VA = "0x18276A490", Slot = "16")]
		public override int GetRecordTimeByMs()
		{
			return 0;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00002D00 File Offset: 0x00000F00
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x276A830", Offset = "0x2769C30", VA = "0x18276A830", Slot = "17")]
		public override int SetRecordTimeByMs(int timePlay, int timeRecord)
		{
			return 0;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00002D18 File Offset: 0x00000F18
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x276A7E0", Offset = "0x2769BE0", VA = "0x18276A7E0", Slot = "18")]
		public override int SetRecordKaraokeType(int type)
		{
			return 0;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x276A440", Offset = "0x2769840", VA = "0x18276A440", Slot = "19")]
		public override int GetRecordFileDurationByMs()
		{
			return 0;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00002D48 File Offset: 0x00000F48
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x276A890", Offset = "0x2769C90", VA = "0x18276A890", Slot = "20")]
		public override int StartPreview()
		{
			return 0;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00002D60 File Offset: 0x00000F60
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x276A9E0", Offset = "0x2769DE0", VA = "0x18276A9E0", Slot = "21")]
		public override int StopPreview()
		{
			return 0;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x276A580", Offset = "0x2769980", VA = "0x18276A580", Slot = "22")]
		public override int PausePreview()
		{
			return 0;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00002D90 File Offset: 0x00000F90
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x276A620", Offset = "0x2769A20", VA = "0x18276A620", Slot = "23")]
		public override int ResumePreview()
		{
			return 0;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x276A790", Offset = "0x2769B90", VA = "0x18276A790", Slot = "24")]
		public override int SetPreviewTimeByMs(int time)
		{
			return 0;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x276A3F0", Offset = "0x27697F0", VA = "0x18276A3F0", Slot = "25")]
		public override int GetPreviewTimeByMs()
		{
			return 0;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x276A720", Offset = "0x2769B20", VA = "0x18276A720", Slot = "26")]
		public override int SetMixWeights(float mic, float acc)
		{
			return 0;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x276A250", Offset = "0x2769650", VA = "0x18276A250", Slot = "27")]
		public override int AdjustAudioTimeByMs(int time)
		{
			return 0;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00002E08 File Offset: 0x00001008
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x276A4E0", Offset = "0x27698E0", VA = "0x18276A4E0", Slot = "28")]
		public override int MixRecordFile(bool needMicData)
		{
			return 0;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x276A2A0", Offset = "0x27696A0", VA = "0x18276A2A0", Slot = "29")]
		public override int CancelMixRecordFile()
		{
			return 0;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x276A2F0", Offset = "0x27696F0", VA = "0x18276A2F0", Slot = "30")]
		public override int CleanTask()
		{
			return 0;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public QAVAudioRecordCtrl()
		{
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x14C58E0", Offset = "0x14C4CE0", VA = "0x1814C58E0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x0")]
		private static QAVAudioRecordCtrl sInstance;
	}
}
