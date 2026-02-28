using System;
using Il2CppDummyDll;
using XGameFramework.Fsm;

namespace XGameFramework.Flow
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	public abstract class FlowBase : FsmState<IFlowManager>
	{
		// Token: 0x060002F1 RID: 753 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x2B95B60", Offset = "0x2B94F60", VA = "0x182B95B60", Slot = "4")]
		protected internal override void OnInit(IFsm<IFlowManager> fsm)
		{
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x2B95B10", Offset = "0x2B94F10", VA = "0x182B95B10", Slot = "5")]
		protected internal override void OnEnter(IFsm<IFlowManager> fsm)
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x2B95C10", Offset = "0x2B95010", VA = "0x182B95C10", Slot = "6")]
		protected internal override void OnTick(IFsm<IFlowManager> fsm, double deltaTime)
		{
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x2B95BB0", Offset = "0x2B94FB0", VA = "0x182B95BB0", Slot = "7")]
		protected internal override void OnLeave(IFsm<IFlowManager> fsm, bool isShutDown)
		{
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x2B95AC0", Offset = "0x2B94EC0", VA = "0x182B95AC0", Slot = "8")]
		protected internal override void OnDestroy(IFsm<IFlowManager> fsm)
		{
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x2B95C70", Offset = "0x2B95070", VA = "0x182B95C70")]
		protected FlowBase()
		{
		}
	}
}
