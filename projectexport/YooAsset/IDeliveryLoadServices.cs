using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YooAsset
{
	// Token: 0x020000CB RID: 203
	[Token(Token = "0x2000096")]
	public interface IDeliveryLoadServices
	{
		// Token: 0x06000484 RID: 1156
		[Token(Token = "0x6000464")]
		AssetBundle LoadAssetBundle(DeliveryFileInfo fileInfo);

		// Token: 0x06000485 RID: 1157
		[Token(Token = "0x6000465")]
		AssetBundleCreateRequest LoadAssetBundleAsync(DeliveryFileInfo fileInfo);
	}
}
