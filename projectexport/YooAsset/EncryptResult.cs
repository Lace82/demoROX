using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000CD RID: 205
	[Token(Token = "0x2000098")]
	public struct EncryptResult
	{
		// Token: 0x04000347 RID: 839
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x0")]
		public bool Encrypted;

		// Token: 0x04000348 RID: 840
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x8")]
		public byte[] EncryptedData;
	}
}
