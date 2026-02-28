using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x02000096 RID: 150
	[Token(Token = "0x200006B")]
	public abstract class ITMGAudioDataObserver
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060004A8 RID: 1192
		// (remove) Token: 0x060004A9 RID: 1193
		[Token(Token = "0x14000005")]
		public abstract event QAVAudioDataCallback OnAudioDataCallback;

		// Token: 0x060004AA RID: 1194 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x2760AD0", Offset = "0x275FED0", VA = "0x182760AD0")]
		public static ITMGAudioDataObserver GetInstance()
		{
			return null;
		}

		// Token: 0x060004AB RID: 1195
		[Token(Token = "0x60003D1")]
		public abstract int RegisteAudioDataCallback(Audio_Data_Type dataType);

		// Token: 0x060004AC RID: 1196
		[Token(Token = "0x60003D2")]
		public abstract int UnRegisteAudioDataCallback(Audio_Data_Type dataType);

		// Token: 0x060004AD RID: 1197
		[Token(Token = "0x60003D3")]
		public abstract int SetAudioDataFormat(Audio_Data_Type audioType, int sampleRate, int channelCount);

		// Token: 0x060004AE RID: 1198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		protected ITMGAudioDataObserver()
		{
		}
	}
}
