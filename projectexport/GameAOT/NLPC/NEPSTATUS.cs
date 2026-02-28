using System;
using Il2CppDummyDll;

namespace NLPC
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000036")]
	public enum NEPSTATUS
	{
		// Token: 0x040001CF RID: 463
		[Token(Token = "0x400013B")]
		eNEP_Status_Normal,
		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x400013C")]
		eNEP_Status_NotLoaded,
		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x400013D")]
		eNEP_Status_FileNotFount,
		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x400013E")]
		eNEP_Status_FileModified = 4,
		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x400013F")]
		eNEP_Status_Suspended = 8,
		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x4000140")]
		eNEP_Status_TiggerEvent = 16,
		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x4000141")]
		eNEP_Status_InternalWardenError = 32,
		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x4000142")]
		eNEP_Status_NetworkError = 64
	}
}
