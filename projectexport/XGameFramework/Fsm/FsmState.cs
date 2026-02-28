using System;
using Il2CppDummyDll;

namespace XGameFramework.Fsm
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	public abstract class FsmState<T> where T : class
	{
		// Token: 0x060002D1 RID: 721 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D1")]
		protected internal virtual void OnInit(IFsm<T> fsm)
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D2")]
		protected internal virtual void OnEnter(IFsm<T> fsm)
		{
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D3")]
		protected internal virtual void OnTick(IFsm<T> fsm, double deltaTime)
		{
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D4")]
		protected internal virtual void OnLeave(IFsm<T> fsm, bool isShutDown)
		{
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D5")]
		protected internal virtual void OnDestroy(IFsm<T> fsm)
		{
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D6")]
		protected void ChangeState<TState>(IFsm<T> fsm) where TState : FsmState<T>
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D7")]
		protected void ChangeState(IFsm<T> fsm, Type stateType)
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D8")]
		protected FsmState()
		{
		}
	}
}
