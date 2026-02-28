using System;
using Il2CppDummyDll;

namespace quicksdk
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200004A")]
	public class GameRoleInfo
	{
		// Token: 0x0600038E RID: 910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public GameRoleInfo()
		{
		}

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x10")]
		public string serverName;

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x18")]
		public string serverId;

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x20")]
		public string gameRoleName;

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x28")]
		public string accountId;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x30")]
		public string gameRoleID;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x38")]
		public string vipLevel;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x40")]
		public string gameRoleLevel;
	}
}
