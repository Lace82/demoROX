using System;
using Il2CppDummyDll;

namespace NLPC
{
	// Token: 0x0200005B RID: 91
	// (Invoke) Token: 0x0600032A RID: 810
	[Token(Token = "0x200003A")]
	[Attribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xECFA0", Offset = "0xEC3A0")]
	public delegate bool TRANSCALLBACK(IntPtr data, ulong len, int serviceType);
}
