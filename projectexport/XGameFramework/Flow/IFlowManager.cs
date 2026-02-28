using System;
using Il2CppDummyDll;
using XGameFramework.Fsm;

namespace XGameFramework.Flow
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	public interface IFlowManager : IModule
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000305 RID: 773
		[Token(Token = "0x1700007F")]
		FlowBase CurrentFlow { [Token(Token = "0x6000305")] get; }

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000306 RID: 774
		[Token(Token = "0x17000080")]
		float CurrentFlowTime { [Token(Token = "0x6000306")] get; }

		// Token: 0x06000307 RID: 775
		[Token(Token = "0x6000307")]
		void Initialize(IFsmManager fsmManager, params FlowBase[] flows);

		// Token: 0x06000308 RID: 776
		[Token(Token = "0x6000308")]
		void StartFlow<T>() where T : FlowBase;

		// Token: 0x06000309 RID: 777
		[Token(Token = "0x6000309")]
		void StartFlow(Type flowType);

		// Token: 0x0600030A RID: 778
		[Token(Token = "0x600030A")]
		bool HasFlow<T>() where T : FlowBase;

		// Token: 0x0600030B RID: 779
		[Token(Token = "0x600030B")]
		bool HasFlow(Type flowType);

		// Token: 0x0600030C RID: 780
		[Token(Token = "0x600030C")]
		FlowBase GetFlow<T>() where T : FlowBase;

		// Token: 0x0600030D RID: 781
		[Token(Token = "0x600030D")]
		FlowBase GetFlow(Type flowType);

		// Token: 0x0600030E RID: 782
		[Token(Token = "0x600030E")]
		void ChangeFlow<T>() where T : FlowBase;

		// Token: 0x0600030F RID: 783
		[Token(Token = "0x600030F")]
		void ChangeFlow(Type flowType);
	}
}
