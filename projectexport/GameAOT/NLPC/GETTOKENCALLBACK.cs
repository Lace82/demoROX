using System;
using Il2CppDummyDll;

namespace NLPC
{
	// Token: 0x02000063 RID: 99
	// (Invoke) Token: 0x0600034A RID: 842
	[Token(Token = "0x2000042")]
	[Attribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xECFA0", Offset = "0xEC3A0")]
	public delegate int GETTOKENCALLBACK(string businessId, ref IntPtr token, ref int size);
}
