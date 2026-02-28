using System;
using Il2CppDummyDll;

namespace XGame.Aot
{
	// Token: 0x02000104 RID: 260
	[Token(Token = "0x20000D4")]
	[Serializable]
	public class EncryptionSeed
	{
		// Token: 0x0600093E RID: 2366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600084A")]
		[Address(RVA = "0x105C4F0", Offset = "0x105B8F0", VA = "0x18105C4F0")]
		public EncryptionSeed(string version, int seed)
		{
		}

		// Token: 0x040004A3 RID: 1187
		[Token(Token = "0x40003D0")]
		[FieldOffset(Offset = "0x10")]
		public string Version;

		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x40003D1")]
		[FieldOffset(Offset = "0x18")]
		public int EncryptSeed;
	}
}
