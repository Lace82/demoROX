using System;
using Il2CppDummyDll;

namespace XGameFramework.Fsm
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	public interface IFsm<T> where T : class
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060002D9 RID: 729
		[Token(Token = "0x17000075")]
		string Name { [Token(Token = "0x60002D9")] get; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060002DA RID: 730
		[Token(Token = "0x17000076")]
		string FullName { [Token(Token = "0x60002DA")] get; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060002DB RID: 731
		[Token(Token = "0x17000077")]
		T Owner { [Token(Token = "0x60002DB")] get; }

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060002DC RID: 732
		[Token(Token = "0x17000078")]
		int StateCount { [Token(Token = "0x60002DC")] get; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060002DD RID: 733
		[Token(Token = "0x17000079")]
		bool IsRunning { [Token(Token = "0x60002DD")] get; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060002DE RID: 734
		[Token(Token = "0x1700007A")]
		bool IsDestroyed { [Token(Token = "0x60002DE")] get; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060002DF RID: 735
		[Token(Token = "0x1700007B")]
		FsmState<T> CurrentState { [Token(Token = "0x60002DF")] get; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060002E0 RID: 736
		[Token(Token = "0x1700007C")]
		float ElapsedTime { [Token(Token = "0x60002E0")] get; }

		// Token: 0x060002E1 RID: 737
		[Token(Token = "0x60002E1")]
		void Start<TState>() where TState : FsmState<T>;

		// Token: 0x060002E2 RID: 738
		[Token(Token = "0x60002E2")]
		void Start(Type stateType);

		// Token: 0x060002E3 RID: 739
		[Token(Token = "0x60002E3")]
		bool HasState<TState>() where TState : FsmState<T>;

		// Token: 0x060002E4 RID: 740
		[Token(Token = "0x60002E4")]
		bool HasState(Type stateType);

		// Token: 0x060002E5 RID: 741
		[Token(Token = "0x60002E5")]
		bool AddState<TState>() where TState : FsmState<T>;

		// Token: 0x060002E6 RID: 742
		[Token(Token = "0x60002E6")]
		bool AddState(Type stateType);

		// Token: 0x060002E7 RID: 743
		[Token(Token = "0x60002E7")]
		TState GetState<TState>() where TState : FsmState<T>;

		// Token: 0x060002E8 RID: 744
		[Token(Token = "0x60002E8")]
		FsmState<T> GetState(Type stateType);

		// Token: 0x060002E9 RID: 745
		[Token(Token = "0x60002E9")]
		void ChangeState<TState>() where TState : FsmState<T>;

		// Token: 0x060002EA RID: 746
		[Token(Token = "0x60002EA")]
		void ChangeState(Type stateType);

		// Token: 0x060002EB RID: 747
		[Token(Token = "0x60002EB")]
		bool HasData(string name);

		// Token: 0x060002EC RID: 748
		[Token(Token = "0x60002EC")]
		TData GetData<TData>(string name) where TData : Variable;

		// Token: 0x060002ED RID: 749
		[Token(Token = "0x60002ED")]
		Variable GetData(string name);

		// Token: 0x060002EE RID: 750
		[Token(Token = "0x60002EE")]
		void SetData<TData>(string name, TData data) where TData : Variable;

		// Token: 0x060002EF RID: 751
		[Token(Token = "0x60002EF")]
		void SetData(string name, Variable data);

		// Token: 0x060002F0 RID: 752
		[Token(Token = "0x60002F0")]
		bool RemoveData(string name);
	}
}
