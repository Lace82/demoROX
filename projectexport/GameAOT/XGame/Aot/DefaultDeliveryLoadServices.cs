using System;
using Il2CppDummyDll;
using UnityEngine;
using YooAsset;

namespace XGame.Aot
{
	// Token: 0x0200011A RID: 282
	[Token(Token = "0x20000E4")]
	public class DefaultDeliveryLoadServices : IDeliveryLoadServices
	{
		// Token: 0x06000984 RID: 2436 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x1378F50", Offset = "0x1378350", VA = "0x181378F50", Slot = "4")]
		public AssetBundle LoadAssetBundle(DeliveryFileInfo fileInfo)
		{
			return null;
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x1378F00", Offset = "0x1378300", VA = "0x181378F00", Slot = "5")]
		public AssetBundleCreateRequest LoadAssetBundleAsync(DeliveryFileInfo fileInfo)
		{
			return null;
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000888")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public DefaultDeliveryLoadServices()
		{
		}
	}
}
