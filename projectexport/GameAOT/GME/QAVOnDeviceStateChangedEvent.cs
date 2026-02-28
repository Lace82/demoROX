using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000C3 RID: 195
	// (Invoke) Token: 0x060006E7 RID: 1767
	[Token(Token = "0x2000098")]
	[Attribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x91450", Offset = "0x90850")]
	public delegate void QAVOnDeviceStateChangedEvent(int deviceType, string deviceId, bool openOrClose);
}
