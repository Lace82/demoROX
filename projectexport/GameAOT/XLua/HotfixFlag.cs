using System;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x2000020")]
	[Flags]
	public enum HotfixFlag
	{
		// Token: 0x04000147 RID: 327
		[Token(Token = "0x40000C4")]
		Stateless = 0,
		// Token: 0x04000148 RID: 328
		[Token(Token = "0x40000C5")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x1CBBC0", Offset = "0x1CAFC0")]
		Stateful = 1,
		// Token: 0x04000149 RID: 329
		[Token(Token = "0x40000C6")]
		ValueTypeBoxing = 2,
		// Token: 0x0400014A RID: 330
		[Token(Token = "0x40000C7")]
		IgnoreProperty = 4,
		// Token: 0x0400014B RID: 331
		[Token(Token = "0x40000C8")]
		IgnoreNotPublic = 8,
		// Token: 0x0400014C RID: 332
		[Token(Token = "0x40000C9")]
		Inline = 16,
		// Token: 0x0400014D RID: 333
		[Token(Token = "0x40000CA")]
		IntKey = 32,
		// Token: 0x0400014E RID: 334
		[Token(Token = "0x40000CB")]
		AdaptByDelegate = 64,
		// Token: 0x0400014F RID: 335
		[Token(Token = "0x40000CC")]
		IgnoreCompilerGenerated = 128,
		// Token: 0x04000150 RID: 336
		[Token(Token = "0x40000CD")]
		NoBaseProxy = 256
	}
}
