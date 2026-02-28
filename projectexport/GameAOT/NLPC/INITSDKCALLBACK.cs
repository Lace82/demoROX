using System;
using Il2CppDummyDll;

namespace NLPC
{
	// Token: 0x02000060 RID: 96
	// (Invoke) Token: 0x0600033E RID: 830
	[Token(Token = "0x200003F")]
	[Attribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xECFA0", Offset = "0xEC3A0")]
	public delegate int INITSDKCALLBACK(string szProuctId, IntPtr gameSetInfo, TRANSCALLBACK transCallback);
}
