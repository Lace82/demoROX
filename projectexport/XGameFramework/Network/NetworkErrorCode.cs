using System;
using Il2CppDummyDll;

namespace XGameFramework.Network
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	public enum NetworkErrorCode : byte
	{
		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		Unknown,
		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		AddressFamilyError,
		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		SocketError,
		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		ConnectError,
		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		SendError,
		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		ReceiveError,
		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		SerializeError,
		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		DeserializePacketHeaderError,
		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		DeserializePacketError
	}
}
