using System;
using Il2CppDummyDll;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x0200016C RID: 364
	[Token(Token = "0x2000114")]
	public sealed class VarByte : Variable<byte>
	{
		// Token: 0x06000AE7 RID: 2791 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600099C")]
		[Address(RVA = "0xED9920", Offset = "0xED8D20", VA = "0x180ED9920")]
		public static implicit operator VarByte(byte value)
		{
			return null;
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00004728 File Offset: 0x00002928
		[Token(Token = "0x600099D")]
		[Address(RVA = "0xED98E0", Offset = "0xED8CE0", VA = "0x180ED98E0")]
		public static implicit operator byte(VarByte value)
		{
			return 0;
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600099E")]
		[Address(RVA = "0xED98A0", Offset = "0xED8CA0", VA = "0x180ED98A0")]
		public VarByte()
		{
		}
	}
}
