using System;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;
using YooAsset;

namespace XGame.Aot
{
	// Token: 0x0200011C RID: 284
	[Token(Token = "0x20000E6")]
	public class FileOffsetDecryption : IDecryptionServices
	{
		// Token: 0x0600098B RID: 2443 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600088D")]
		[Address(RVA = "0x137A6C0", Offset = "0x1379AC0", VA = "0x18137A6C0", Slot = "4")]
		private AssetBundle LoadAssetBundle(DecryptFileInfo fileInfo, out Stream managedStream)
		{
			return null;
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600088E")]
		[Address(RVA = "0x137A670", Offset = "0x1379A70", VA = "0x18137A670", Slot = "5")]
		private AssetBundleCreateRequest LoadAssetBundleAsync(DecryptFileInfo fileInfo, out Stream managedStream)
		{
			return null;
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00004230 File Offset: 0x00002430
		[Token(Token = "0x600088F")]
		[Address(RVA = "0xE295A0", Offset = "0xE289A0", VA = "0x180E295A0")]
		private static ulong GetFileOffset()
		{
			return 0UL;
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000890")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public FileOffsetDecryption()
		{
		}
	}
}
