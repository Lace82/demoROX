using System;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public enum EStartTaskStatus : byte
	{
		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		Done,
		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		CanResume,
		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		HasToWait,
		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		UnknownError
	}
}
