using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YooAsset
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000051")]
	internal sealed class BundledAssetProvider : ProviderBase
	{
		// Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x180F110", Offset = "0x180E510", VA = "0x18180F110")]
		public BundledAssetProvider(ResourceManager manager, string providerGUID, AssetInfo assetInfo)
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x180F120", Offset = "0x180E520", VA = "0x18180F120", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0xE0")]
		private AssetBundleRequest _cacheRequest;
	}
}
