using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000D8 RID: 216
	// (Invoke) Token: 0x0600073B RID: 1851
	[Token(Token = "0x20000AD")]
	[Attribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x91450", Offset = "0x90850")]
	public delegate void QAVCustomStreamDataCallback(ulong uin, byte[] data, ulong timestamp, IntPtr userData);
}
