using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000020")]
	[Serializable]
	internal class RemoteCommand
	{
		// Token: 0x0600009A RID: 154 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1BB1490", Offset = "0x1BB0890", VA = "0x181BB1490")]
		public static byte[] Serialize(RemoteCommand command)
		{
			return null;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1BB1450", Offset = "0x1BB0850", VA = "0x181BB1450")]
		public static RemoteCommand Deserialize(byte[] data)
		{
			return null;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public RemoteCommand()
		{
		}

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x10")]
		public int CommandType;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x18")]
		public string CommandParam;
	}
}
