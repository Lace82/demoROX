using System;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

namespace YooAsset
{
	// Token: 0x020000C9 RID: 201
	[Token(Token = "0x2000094")]
	public interface IDecryptionServices
	{
		// Token: 0x06000482 RID: 1154
		[Token(Token = "0x6000462")]
		AssetBundle LoadAssetBundle(DecryptFileInfo fileInfo, out Stream managedStream);

		// Token: 0x06000483 RID: 1155
		[Token(Token = "0x6000463")]
		AssetBundleCreateRequest LoadAssetBundleAsync(DecryptFileInfo fileInfo, out Stream managedStream);
	}
}
