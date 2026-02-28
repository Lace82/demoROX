using System;
using Il2CppDummyDll;
using YooAsset;

namespace XGame.Aot
{
	// Token: 0x02000119 RID: 281
	[Token(Token = "0x20000E3")]
	public class DefaultDeliveryQueryServices : IDeliveryQueryServices
	{
		// Token: 0x06000981 RID: 2433 RVA: 0x00004200 File Offset: 0x00002400
		[Token(Token = "0x6000883")]
		[Address(RVA = "0xCB9160", Offset = "0xCB8560", VA = "0x180CB9160", Slot = "4")]
		public bool Query(string packageName, string fileName, string fileCRC)
		{
			return default(bool);
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000884")]
		[Address(RVA = "0x1378FA0", Offset = "0x13783A0", VA = "0x181378FA0", Slot = "5")]
		public string GetFilePath(string packageName, string fileName)
		{
			return null;
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000885")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public DefaultDeliveryQueryServices()
		{
		}
	}
}
