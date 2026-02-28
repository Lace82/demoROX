using System;
using Il2CppDummyDll;

namespace XGame.Aot
{
	// Token: 0x0200013D RID: 317
	[Token(Token = "0x20000F2")]
	[Serializable]
	public class RawFileHash
	{
		// Token: 0x06000A09 RID: 2569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public RawFileHash()
		{
		}

		// Token: 0x0400059E RID: 1438
		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		// Token: 0x0400059F RID: 1439
		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x18")]
		public string Md5;
	}
}
