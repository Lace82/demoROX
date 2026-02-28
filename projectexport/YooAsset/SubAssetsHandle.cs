using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YooAsset
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000046")]
	public sealed class SubAssetsHandle : HandleBase, IDisposable
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1BB1220", Offset = "0x1BB0620", VA = "0x181BB1220")]
		internal SubAssetsHandle(ProviderBase provider)
		{
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1BBA6A0", Offset = "0x1BB9AA0", VA = "0x181BBA6A0", Slot = "7")]
		internal override void InvokeCallback()
		{
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060001B3 RID: 435 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001B4 RID: 436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000006")]
		public event Action<SubAssetsHandle> Completed
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x1BBA6F0", Offset = "0x1BB9AF0", VA = "0x181BBA6F0")]
			add
			{
			}
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x1BBA820", Offset = "0x1BB9C20", VA = "0x181BBA820")]
			remove
			{
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1808D70", Offset = "0x1808170", VA = "0x181808D70")]
		public void WaitForAsyncComplete()
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1BB0F30", Offset = "0x1BB0330", VA = "0x181BB0F30")]
		public void Release()
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1BB0F30", Offset = "0x1BB0330", VA = "0x181BB0F30", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000046")]
		public UnityEngine.Object[] AllAssetObjects
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x1808F30", Offset = "0x1808330", VA = "0x181808F30")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001AE")]
		public TObject GetSubAssetObject<TObject>(string assetName) where TObject : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001AF")]
		public TObject[] GetSubAssetObjects<TObject>() where TObject : UnityEngine.Object
		{
			return null;
		}
	}
}
