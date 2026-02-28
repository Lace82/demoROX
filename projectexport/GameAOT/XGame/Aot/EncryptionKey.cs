using System;
using Il2CppDummyDll;

namespace XGame.Aot
{
	// Token: 0x02000105 RID: 261
	[Token(Token = "0x20000D5")]
	[Serializable]
	public class EncryptionKey
	{
		// Token: 0x0600093F RID: 2367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600084B")]
		[Address(RVA = "0xCD69C0", Offset = "0xCD5DC0", VA = "0x180CD69C0")]
		public EncryptionKey(string version, string key)
		{
		}

		// Token: 0x040004A5 RID: 1189
		[Token(Token = "0x40003D2")]
		[FieldOffset(Offset = "0x10")]
		public string Version;

		// Token: 0x040004A6 RID: 1190
		[Token(Token = "0x40003D3")]
		[FieldOffset(Offset = "0x18")]
		public string EncryptKey;
	}
}
