using System;
using Il2CppDummyDll;

namespace XGameFramework.Fsm
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	public interface IFsmManager : IModule
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000298 RID: 664
		[Token(Token = "0x17000067")]
		int Count { [Token(Token = "0x6000298")] get; }

		// Token: 0x06000299 RID: 665
		[Token(Token = "0x6000299")]
		bool HasFsm<T>() where T : class;

		// Token: 0x0600029A RID: 666
		[Token(Token = "0x600029A")]
		bool HasFsm(Type ownerType);

		// Token: 0x0600029B RID: 667
		[Token(Token = "0x600029B")]
		bool HasFsm<T>(string name) where T : class;

		// Token: 0x0600029C RID: 668
		[Token(Token = "0x600029C")]
		bool HasFsm(Type ownerType, string name);

		// Token: 0x0600029D RID: 669
		[Token(Token = "0x600029D")]
		IFsm<T> GetFsm<T>() where T : class;

		// Token: 0x0600029E RID: 670
		[Token(Token = "0x600029E")]
		IFsm<T> GetFsm<T>(string name) where T : class;

		// Token: 0x0600029F RID: 671
		[Token(Token = "0x600029F")]
		IFsm<T> CreateFsm<T>(T owner, params FsmState<T>[] states) where T : class;

		// Token: 0x060002A0 RID: 672
		[Token(Token = "0x60002A0")]
		IFsm<T> CreateFsm<T>(string name, T owner, params FsmState<T>[] states) where T : class;

		// Token: 0x060002A1 RID: 673
		[Token(Token = "0x60002A1")]
		bool DestroyFsm<T>() where T : class;

		// Token: 0x060002A2 RID: 674
		[Token(Token = "0x60002A2")]
		bool DestroyFsm(Type ownerType);

		// Token: 0x060002A3 RID: 675
		[Token(Token = "0x60002A3")]
		bool DestroyFsm<T>(string name) where T : class;

		// Token: 0x060002A4 RID: 676
		[Token(Token = "0x60002A4")]
		bool DestroyFsm(Type ownerType, string name);

		// Token: 0x060002A5 RID: 677
		[Token(Token = "0x60002A5")]
		bool DestroyFsm<T>(IFsm<T> fsm) where T : class;
	}
}
