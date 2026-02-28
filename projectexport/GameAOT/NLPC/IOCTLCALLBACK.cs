using System;
using Il2CppDummyDll;

namespace NLPC
{
	// Token: 0x0200005C RID: 92
	// (Invoke) Token: 0x0600032E RID: 814
	[Token(Token = "0x200003B")]
	[Attribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xECFA0", Offset = "0xEC3A0")]
	public delegate IntPtr IOCTLCALLBACK(IntPtr data, ulong len, int serviceType);
}
