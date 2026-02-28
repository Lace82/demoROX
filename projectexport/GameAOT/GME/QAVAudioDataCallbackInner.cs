using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000DB RID: 219
	// (Invoke) Token: 0x06000747 RID: 1863
	[Token(Token = "0x20000B0")]
	[Attribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x91450", Offset = "0x90850")]
	public delegate void QAVAudioDataCallbackInner(uint audioDatType, ulong timestamp, uint sampleRate, uint channelCount, uint bitsType, uint length, IntPtr pcmData);
}
