using System;
using Il2CppDummyDll;

namespace NLPC
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000034")]
	public struct GameSetInfo
	{
		// Token: 0x06000324 RID: 804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2E65450", Offset = "0x2E64850", VA = "0x182E65450")]
		public GameSetInfo(ServerType servType)
		{
		}

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x0")]
		public int serverType;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x8")]
		public string reserved;
	}
}
