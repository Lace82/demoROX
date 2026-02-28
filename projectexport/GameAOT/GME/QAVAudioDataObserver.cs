using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x200006D")]
	public class QAVAudioDataObserver : ITMGAudioDataObserver
	{
		// Token: 0x060004D1 RID: 1233 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x2767E80", Offset = "0x2767280", VA = "0x182767E80")]
		public new static QAVAudioDataObserver GetInstance()
		{
			return null;
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060004D2 RID: 1234 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004D3 RID: 1235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000009")]
		public override event QAVAudioDataCallback OnAudioDataCallback
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x2768120", Offset = "0x2767520", VA = "0x182768120", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x27681C0", Offset = "0x27675C0", VA = "0x1827681C0", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x2768260", Offset = "0x2767660", VA = "0x182768260")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x8FA80", Offset = "0x8EE80")]
		private static void s_OnAudioDataCallback(uint audioDatType, ulong timestamp, uint sampleRate, uint channelCount, uint bitsType, uint length, IntPtr pcmData)
		{
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x2767F40", Offset = "0x2767340", VA = "0x182767F40", Slot = "6")]
		public override int RegisteAudioDataCallback(Audio_Data_Type dataType)
		{
			return 0;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00002E68 File Offset: 0x00001068
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x2768060", Offset = "0x2767460", VA = "0x182768060", Slot = "7")]
		public override int UnRegisteAudioDataCallback(Audio_Data_Type dataType)
		{
			return 0;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x2767FE0", Offset = "0x27673E0", VA = "0x182767FE0", Slot = "8")]
		public override int SetAudioDataFormat(Audio_Data_Type audioType, int sampleRate, int channelCount)
		{
			return 0;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public QAVAudioDataObserver()
		{
		}

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x0")]
		private static QAVAudioDataObserver sInstance;
	}
}
