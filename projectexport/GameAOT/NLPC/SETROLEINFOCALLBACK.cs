using System;
using Il2CppDummyDll;

namespace NLPC
{
	// Token: 0x0200005D RID: 93
	// (Invoke) Token: 0x06000332 RID: 818
	[Token(Token = "0x200003C")]
	[Attribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xECFA0", Offset = "0xEC3A0")]
	public delegate bool SETROLEINFOCALLBACK(string szBusinessId, string szSdkVersion, string szAccount, string szRoleId, string szRoleName, int nServerId, string szServerName, int nRoleLevel, int nState, string szGameJson);
}
