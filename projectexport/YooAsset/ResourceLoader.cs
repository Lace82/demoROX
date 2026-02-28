using System;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

namespace YooAsset
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x200005C")]
	internal class ResourceLoader
	{
		// Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1BB1E50", Offset = "0x1BB1250", VA = "0x181BB1E50")]
		public void Init(IDecryptionServices decryption, IDeliveryLoadServices delivery)
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1BB2070", Offset = "0x1BB1470", VA = "0x181BB2070")]
		public AssetBundle LoadAssetBundle(BundleInfo bundleInfo, string fileLoadPath, out Stream managedStream)
		{
			return null;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1BB1E90", Offset = "0x1BB1290", VA = "0x181BB1E90")]
		public AssetBundleCreateRequest LoadAssetBundleAsync(BundleInfo bundleInfo, string fileLoadPath, out Stream managedStream)
		{
			return null;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1BB23E0", Offset = "0x1BB17E0", VA = "0x181BB23E0")]
		public AssetBundle LoadDeliveryAssetBundle(BundleInfo bundleInfo, string fileLoadPath)
		{
			return null;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1BB2250", Offset = "0x1BB1650", VA = "0x181BB2250")]
		public AssetBundleCreateRequest LoadDeliveryAssetBundleAsync(BundleInfo bundleInfo, string fileLoadPath)
		{
			return null;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public ResourceLoader()
		{
		}

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x10")]
		private IDecryptionServices _decryption;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x18")]
		private IDeliveryLoadServices _delivery;
	}
}
