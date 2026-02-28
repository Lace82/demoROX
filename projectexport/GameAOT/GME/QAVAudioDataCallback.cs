using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000DA RID: 218
	// (Invoke) Token: 0x06000743 RID: 1859
	[Token(Token = "0x20000AF")]
	[Attribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x91450", Offset = "0x90850")]
	public delegate void QAVAudioDataCallback(Audio_Data_Type audioDatType, ulong timestamp, uint sampleRate, uint channelCount, uint bitsType, byte[] pcmData);
}
