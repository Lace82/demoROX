using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YooAsset
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x2000041")]
	public sealed class AllAssetsHandle : HandleBase, IDisposable
	{
		// Token: 0x0600016C RID: 364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1808DB0", Offset = "0x18081B0", VA = "0x181808DB0")]
		internal AllAssetsHandle(ProviderBase provider)
		{
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1808D20", Offset = "0x1808120", VA = "0x181808D20", Slot = "7")]
		internal override void InvokeCallback()
		{
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600016E RID: 366 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600016F RID: 367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		public event Action<AllAssetsHandle> Completed
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x1808E00", Offset = "0x1808200", VA = "0x181808E00")]
			add
			{
			}
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x1808F70", Offset = "0x1808370", VA = "0x181808F70")]
			remove
			{
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1808D70", Offset = "0x1808170", VA = "0x181808D70")]
		public void WaitForAsyncComplete()
		{
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1808CC0", Offset = "0x18080C0", VA = "0x181808CC0")]
		public void Release()
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1808CC0", Offset = "0x18080C0", VA = "0x181808CC0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000173 RID: 371 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000038")]
		public UnityEngine.Object[] AllAssetObjects
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x1808F30", Offset = "0x1808330", VA = "0x181808F30")]
			get
			{
				return null;
			}
		}
	}
}
