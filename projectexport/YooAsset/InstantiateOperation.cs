using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YooAsset
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x200004E")]
	public sealed class InstantiateOperation : AsyncOperationBase
	{
		// Token: 0x060001F4 RID: 500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1BA7FC0", Offset = "0x1BA73C0", VA = "0x181BA7FC0")]
		internal InstantiateOperation(AssetHandle handle, bool setPositionAndRotation, Vector3 position, Quaternion rotation, Transform parent, bool worldPositionStays)
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x1BA7DB0", Offset = "0x1BA71B0", VA = "0x181BA7DB0", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x1BA7DC0", Offset = "0x1BA71C0", VA = "0x181BA7DC0", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x1BA7B00", Offset = "0x1BA6F00", VA = "0x181BA7B00")]
		public void Cancel()
		{
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x1BA7F70", Offset = "0x1BA7370", VA = "0x181BA7F70")]
		public void WaitForAsyncComplete()
		{
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x1BA7B60", Offset = "0x1BA6F60", VA = "0x181BA7B60")]
		internal static GameObject InstantiateInternal(UnityEngine.Object assetObject, bool setPositionAndRotation, Vector3 position, Quaternion rotation, Transform parent, bool worldPositionStays)
		{
			return null;
		}

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x48")]
		private readonly AssetHandle _handle;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x50")]
		private readonly bool _setPositionAndRotation;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x54")]
		private readonly Vector3 _position;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x60")]
		private readonly Quaternion _rotation;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x70")]
		private readonly Transform _parent;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x78")]
		private readonly bool _worldPositionStays;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x7C")]
		private InstantiateOperation.ESteps _steps;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x80")]
		public GameObject Result;

		// Token: 0x02000062 RID: 98
		[Token(Token = "0x20000BD")]
		private enum ESteps
		{
			// Token: 0x04000187 RID: 391
			[Token(Token = "0x40002CF")]
			None,
			// Token: 0x04000188 RID: 392
			[Token(Token = "0x40002D0")]
			Clone,
			// Token: 0x04000189 RID: 393
			[Token(Token = "0x40002D1")]
			Done
		}
	}
}
