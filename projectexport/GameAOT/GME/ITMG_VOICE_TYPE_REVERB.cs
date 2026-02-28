using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000AC RID: 172
	[Token(Token = "0x2000081")]
	public struct ITMG_VOICE_TYPE_REVERB
	{
		// Token: 0x0400033C RID: 828
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x0")]
		public float HARMONIC_GAIN;

		// Token: 0x0400033D RID: 829
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x4")]
		public float HARMONIC_START_FREQUENCY;

		// Token: 0x0400033E RID: 830
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x8")]
		public float HARMONIC_BASS_CONTROL;

		// Token: 0x0400033F RID: 831
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0xC")]
		public float REVERB_SIZE;

		// Token: 0x04000340 RID: 832
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x10")]
		public float REVERB_DEPTH;

		// Token: 0x04000341 RID: 833
		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x14")]
		public float REVERB_GAIN;

		// Token: 0x04000342 RID: 834
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x18")]
		public float REVERB_ECHO_DEPTH;
	}
}
