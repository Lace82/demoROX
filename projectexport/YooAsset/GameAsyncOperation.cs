using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200003F")]
	public abstract class GameAsyncOperation : AsyncOperationBase
	{
		// Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x16EA8D0", Offset = "0x16E9CD0", VA = "0x1816EA8D0", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x181A570", Offset = "0x1819970", VA = "0x18181A570", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x181A550", Offset = "0x1819950", VA = "0x18181A550", Slot = "10")]
		internal override void InternalOnAbort()
		{
		}

		// Token: 0x0600015C RID: 348
		[Token(Token = "0x6000151")]
		protected abstract void OnStart();

		// Token: 0x0600015D RID: 349
		[Token(Token = "0x6000152")]
		protected abstract void OnUpdate();

		// Token: 0x0600015E RID: 350
		[Token(Token = "0x6000153")]
		protected abstract void OnAbort();

		// Token: 0x0600015F RID: 351 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x181A590", Offset = "0x1819990", VA = "0x18181A590")]
		protected bool IsBusy()
		{
			return default(bool);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		protected GameAsyncOperation()
		{
		}
	}
}
