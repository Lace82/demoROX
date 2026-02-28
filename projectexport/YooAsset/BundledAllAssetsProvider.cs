using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YooAsset
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000050")]
	internal sealed class BundledAllAssetsProvider : ProviderBase
	{
		// Token: 0x060001FE RID: 510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x180F110", Offset = "0x180E510", VA = "0x18180F110")]
		public BundledAllAssetsProvider(ResourceManager manager, string providerGUID, AssetInfo assetInfo)
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x180EBC0", Offset = "0x180DFC0", VA = "0x18180EBC0", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0xE0")]
		private AssetBundleRequest _cacheRequest;
	}
}
