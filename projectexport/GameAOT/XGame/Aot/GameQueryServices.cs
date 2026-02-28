using System;
using Il2CppDummyDll;
using YooAsset;

namespace XGame.Aot
{
	// Token: 0x02000118 RID: 280
	[Token(Token = "0x20000E2")]
	public class GameQueryServices : IBuildinQueryServices
	{
		// Token: 0x0600097E RID: 2430 RVA: 0x000041E8 File Offset: 0x000023E8
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x137B6C0", Offset = "0x137AAC0", VA = "0x18137B6C0", Slot = "4")]
		public bool Query(string packageName, string fileName, string fileCRC)
		{
			return default(bool);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000881")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public GameQueryServices()
		{
		}

		// Token: 0x04000519 RID: 1305
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x5020D")]
		public static bool CompareFileCRC;
	}
}
