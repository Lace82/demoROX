using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace YooAsset
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000053")]
	internal sealed class BundledSceneProvider : ProviderBase
	{
		// Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x180FBD0", Offset = "0x180EFD0", VA = "0x18180FBD0")]
		public BundledSceneProvider(ResourceManager manager, string providerGUID, AssetInfo assetInfo, LoadSceneMode sceneMode, bool suspendLoad)
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x180F820", Offset = "0x180EC20", VA = "0x18180F820", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x180FBA0", Offset = "0x180EFA0", VA = "0x18180FBA0")]
		public bool UnSuspendLoad()
		{
			return default(bool);
		}

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0xE0")]
		public readonly LoadSceneMode SceneMode;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0xE4")]
		private readonly bool _suspendLoad;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0xE8")]
		private AsyncOperation _asyncOperation;
	}
}
