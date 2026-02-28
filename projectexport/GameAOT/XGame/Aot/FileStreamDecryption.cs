using System;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;
using YooAsset;

namespace XGame.Aot
{
	// Token: 0x0200011B RID: 283
	[Token(Token = "0x20000E5")]
	public class FileStreamDecryption : IDecryptionServices
	{
		// Token: 0x06000987 RID: 2439 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x137A810", Offset = "0x1379C10", VA = "0x18137A810", Slot = "4")]
		private AssetBundle LoadAssetBundle(DecryptFileInfo fileInfo, out Stream managedStream)
		{
			return null;
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600088A")]
		[Address(RVA = "0x137A720", Offset = "0x1379B20", VA = "0x18137A720", Slot = "5")]
		private AssetBundleCreateRequest LoadAssetBundleAsync(DecryptFileInfo fileInfo, out Stream managedStream)
		{
			return null;
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00004218 File Offset: 0x00002418
		[Token(Token = "0x600088B")]
		[Address(RVA = "0x137A710", Offset = "0x1379B10", VA = "0x18137A710")]
		private static uint GetManagedReadBufferSize()
		{
			return 0U;
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088C")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public FileStreamDecryption()
		{
		}
	}
}
