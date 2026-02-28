using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace YooAsset
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x2000059")]
	internal sealed class DatabaseSceneProvider : ProviderBase
	{
		// Token: 0x0600021B RID: 539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x18121B0", Offset = "0x18115B0", VA = "0x1818121B0")]
		public DatabaseSceneProvider(ResourceManager manager, string providerGUID, AssetInfo assetInfo, LoadSceneMode sceneMode, bool suspendLoad)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x180FBA0", Offset = "0x180EFA0", VA = "0x18180FBA0")]
		public bool UnSuspendLoad()
		{
			return default(bool);
		}

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0xE0")]
		public readonly LoadSceneMode SceneMode;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0xE4")]
		private readonly bool _suspendLoad;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0xE8")]
		private AsyncOperation _asyncOperation;
	}
}
