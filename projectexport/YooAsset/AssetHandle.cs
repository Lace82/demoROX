using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YooAsset
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x2000042")]
	public sealed class AssetHandle : HandleBase, IDisposable
	{
		// Token: 0x06000174 RID: 372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1808DB0", Offset = "0x18081B0", VA = "0x181808DB0")]
		internal AssetHandle(ProviderBase provider)
		{
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x180B450", Offset = "0x180A850", VA = "0x18180B450", Slot = "7")]
		internal override void InvokeCallback()
		{
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000176 RID: 374 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000177 RID: 375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000003")]
		public event Action<AssetHandle> Completed
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x180B4A0", Offset = "0x180A8A0", VA = "0x18180B4A0")]
			add
			{
			}
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x180B610", Offset = "0x180AA10", VA = "0x18180B610")]
			remove
			{
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1808D70", Offset = "0x1808170", VA = "0x181808D70")]
		public void WaitForAsyncComplete()
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1808CC0", Offset = "0x18080C0", VA = "0x181808CC0")]
		public void Release()
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1808CC0", Offset = "0x18080C0", VA = "0x181808CC0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600017B RID: 379 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000039")]
		public UnityEngine.Object AssetObject
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x180B5D0", Offset = "0x180A9D0", VA = "0x18180B5D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000171")]
		public TAsset GetAssetObject<TAsset>() where TAsset : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x180AE40", Offset = "0x180A240", VA = "0x18180AE40")]
		public GameObject InstantiateSync()
		{
			return null;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x180B0B0", Offset = "0x180A4B0", VA = "0x18180B0B0")]
		public GameObject InstantiateSync(Transform parent)
		{
			return null;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x180AFC0", Offset = "0x180A3C0", VA = "0x18180AFC0")]
		public GameObject InstantiateSync(Transform parent, bool worldPositionStays)
		{
			return null;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x180B230", Offset = "0x180A630", VA = "0x18180B230")]
		public GameObject InstantiateSync(Vector3 position, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x180B340", Offset = "0x180A740", VA = "0x18180B340")]
		public GameObject InstantiateSync(Vector3 position, Quaternion rotation, Transform parent)
		{
			return null;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x180A8A0", Offset = "0x1809CA0", VA = "0x18180A8A0")]
		public InstantiateOperation InstantiateAsync()
		{
			return null;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x180A710", Offset = "0x1809B10", VA = "0x18180A710")]
		public InstantiateOperation InstantiateAsync(Transform parent)
		{
			return null;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x180AB30", Offset = "0x1809F30", VA = "0x18180AB30")]
		public InstantiateOperation InstantiateAsync(Transform parent, bool worldPositionStays)
		{
			return null;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x180AC20", Offset = "0x180A020", VA = "0x18180AC20")]
		public InstantiateOperation InstantiateAsync(Vector3 position, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x180AA20", Offset = "0x1809E20", VA = "0x18180AA20")]
		public InstantiateOperation InstantiateAsync(Vector3 position, Quaternion rotation, Transform parent)
		{
			return null;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x180AD20", Offset = "0x180A120", VA = "0x18180AD20")]
		private GameObject InstantiateSyncInternal(bool setPositionAndRotation, Vector3 position, Quaternion rotation, Transform parent, bool worldPositionStays)
		{
			return null;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x180A5F0", Offset = "0x18099F0", VA = "0x18180A5F0")]
		private InstantiateOperation InstantiateAsyncInternal(bool setPositionAndRotation, Vector3 position, Quaternion rotation, Transform parent, bool worldPositionStays)
		{
			return null;
		}
	}
}
