using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YooAsset
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x200004F")]
	public sealed class UnloadSceneOperation : AsyncOperationBase
	{
		// Token: 0x060001FA RID: 506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x12F84B0", Offset = "0x12F78B0", VA = "0x1812F84B0")]
		internal UnloadSceneOperation(string error)
		{
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1BBB320", Offset = "0x1BBA720", VA = "0x181BBB320")]
		internal UnloadSceneOperation(ProviderBase provider)
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1BBB0D0", Offset = "0x1BBA4D0", VA = "0x181BBB0D0", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1BBB0E0", Offset = "0x1BBA4E0", VA = "0x181BBB0E0", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x48")]
		private UnloadSceneOperation.ESteps _steps;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x50")]
		private readonly string _error;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x58")]
		private readonly ProviderBase _provider;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x60")]
		private AsyncOperation _asyncOp;

		// Token: 0x02000064 RID: 100
		[Token(Token = "0x20000BE")]
		private enum ESteps
		{
			// Token: 0x0400018F RID: 399
			[Token(Token = "0x40002D3")]
			None,
			// Token: 0x04000190 RID: 400
			[Token(Token = "0x40002D4")]
			CheckError,
			// Token: 0x04000191 RID: 401
			[Token(Token = "0x40002D5")]
			PrepareDone,
			// Token: 0x04000192 RID: 402
			[Token(Token = "0x40002D6")]
			UnLoadScene,
			// Token: 0x04000193 RID: 403
			[Token(Token = "0x40002D7")]
			Checking,
			// Token: 0x04000194 RID: 404
			[Token(Token = "0x40002D8")]
			Done
		}
	}
}
