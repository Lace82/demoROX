using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YooAsset
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000054")]
	internal sealed class BundledSubAssetsProvider : ProviderBase
	{
		// Token: 0x0600020B RID: 523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x180F110", Offset = "0x180E510", VA = "0x18180F110")]
		public BundledSubAssetsProvider(ResourceManager manager, string providerGUID, AssetInfo assetInfo)
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x180FCD0", Offset = "0x180F0D0", VA = "0x18180FCD0", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0xE0")]
		private AssetBundleRequest _cacheRequest;
	}
}
