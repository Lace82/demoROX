using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000A0")]
	internal class SafeProxy
	{
		// Token: 0x060004B7 RID: 1207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x1BB9600", Offset = "0x1BB8A00", VA = "0x181BB9600")]
		internal SafeProxy()
		{
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x1BB94E0", Offset = "0x1BB88E0", VA = "0x181BB94E0")]
		public void Init(uint poly)
		{
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x1BB8EE0", Offset = "0x1BB82E0", VA = "0x181BB8EE0")]
		public uint Append(uint crc, byte[] input, int offset, int length)
		{
			return 0U;
		}

		// Token: 0x0400035E RID: 862
		[Token(Token = "0x4000257")]
		private const uint Poly = 3988292384U;

		// Token: 0x0400035F RID: 863
		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x10")]
		private readonly uint[] _table;
	}
}
