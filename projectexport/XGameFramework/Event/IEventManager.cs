using System;
using Il2CppDummyDll;

namespace XGameFramework.Event
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	public interface IEventManager : IModule
	{
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600033B RID: 827
		[Token(Token = "0x17000083")]
		int EventHandleCount { [Token(Token = "0x600033B")] get; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600033C RID: 828
		[Token(Token = "0x17000084")]
		int EventCount { [Token(Token = "0x600033C")] get; }

		// Token: 0x0600033D RID: 829
		[Token(Token = "0x600033D")]
		int Count(int id);

		// Token: 0x0600033E RID: 830
		[Token(Token = "0x600033E")]
		bool Check(int id, EventHandler<BaseEventArgs> handler);

		// Token: 0x0600033F RID: 831
		[Token(Token = "0x600033F")]
		void Subscribe(int id, EventHandler<BaseEventArgs> handler);

		// Token: 0x06000340 RID: 832
		[Token(Token = "0x6000340")]
		void Subscribe(string evt, Action callback);

		// Token: 0x06000341 RID: 833
		[Token(Token = "0x6000341")]
		void Subscribe<T1>(string evt, Action<T1> callback);

		// Token: 0x06000342 RID: 834
		[Token(Token = "0x6000342")]
		void Subscribe<T1, T2>(string evt, Action<T1, T2> callback);

		// Token: 0x06000343 RID: 835
		[Token(Token = "0x6000343")]
		void Subscribe<T1, T2, T3>(string evt, Action<T1, T2, T3> callback);

		// Token: 0x06000344 RID: 836
		[Token(Token = "0x6000344")]
		void Subscribe<T1, T2, T3, T4>(string evt, Action<T1, T2, T3, T4> callback);

		// Token: 0x06000345 RID: 837
		[Token(Token = "0x6000345")]
		void Subscribe<T1, T2, T3, T4, T5>(string evt, Action<T1, T2, T3, T4, T5> callback);

		// Token: 0x06000346 RID: 838
		[Token(Token = "0x6000346")]
		void Subscribe<T1, T2, T3, T4, T5, T6>(string evt, Action<T1, T2, T3, T4, T5, T6> callback);

		// Token: 0x06000347 RID: 839
		[Token(Token = "0x6000347")]
		void Subscribe<T1, T2, T3, T4, T5, T6, T7>(string evt, Action<T1, T2, T3, T4, T5, T6, T7> callback);

		// Token: 0x06000348 RID: 840
		[Token(Token = "0x6000348")]
		void Subscribe<T1, T2, T3, T4, T5, T6, T7, T8>(string evt, Action<T1, T2, T3, T4, T5, T6, T7, T8> callback);

		// Token: 0x06000349 RID: 841
		[Token(Token = "0x6000349")]
		void Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string evt, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> callback);

		// Token: 0x0600034A RID: 842
		[Token(Token = "0x600034A")]
		void UnSubscribe(int id, EventHandler<BaseEventArgs> handler);

		// Token: 0x0600034B RID: 843
		[Token(Token = "0x600034B")]
		void UnSubscribe(string evt, Action callback);

		// Token: 0x0600034C RID: 844
		[Token(Token = "0x600034C")]
		void UnSubscribe<T1>(string evt, Action<T1> callback);

		// Token: 0x0600034D RID: 845
		[Token(Token = "0x600034D")]
		void UnSubscribe<T1, T2>(string evt, Action<T1, T2> callback);

		// Token: 0x0600034E RID: 846
		[Token(Token = "0x600034E")]
		void UnSubscribe<T1, T2, T3>(string evt, Action<T1, T2, T3> callback);

		// Token: 0x0600034F RID: 847
		[Token(Token = "0x600034F")]
		void UnSubscribe<T1, T2, T3, T4>(string evt, Action<T1, T2, T3, T4> callback);

		// Token: 0x06000350 RID: 848
		[Token(Token = "0x6000350")]
		void UnSubscribe<T1, T2, T3, T4, T5>(string evt, Action<T1, T2, T3, T4, T5> callback);

		// Token: 0x06000351 RID: 849
		[Token(Token = "0x6000351")]
		void UnSubscribe<T1, T2, T3, T4, T5, T6>(string evt, Action<T1, T2, T3, T4, T5, T6> callback);

		// Token: 0x06000352 RID: 850
		[Token(Token = "0x6000352")]
		void UnSubscribe<T1, T2, T3, T4, T5, T6, T7>(string evt, Action<T1, T2, T3, T4, T5, T6, T7> callback);

		// Token: 0x06000353 RID: 851
		[Token(Token = "0x6000353")]
		void UnSubscribe<T1, T2, T3, T4, T5, T6, T7, T8>(string evt, Action<T1, T2, T3, T4, T5, T6, T7, T8> callback);

		// Token: 0x06000354 RID: 852
		[Token(Token = "0x6000354")]
		void UnSubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string evt, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> callback);

		// Token: 0x06000355 RID: 853
		[Token(Token = "0x6000355")]
		void DispatchSafe(object sender, BaseEventArgs e);

		// Token: 0x06000356 RID: 854
		[Token(Token = "0x6000356")]
		void Dispatch(object sender, BaseEventArgs e);

		// Token: 0x06000357 RID: 855
		[Token(Token = "0x6000357")]
		void Dispatch(string evt);

		// Token: 0x06000358 RID: 856
		[Token(Token = "0x6000358")]
		void Dispatch<T>(string evt, T arg);

		// Token: 0x06000359 RID: 857
		[Token(Token = "0x6000359")]
		void Dispatch<T1, T2>(string evt, T1 arg1, T2 arg2);

		// Token: 0x0600035A RID: 858
		[Token(Token = "0x600035A")]
		void Dispatch<T1, T2, T3>(string evt, T1 arg1, T2 arg2, T3 arg3);

		// Token: 0x0600035B RID: 859
		[Token(Token = "0x600035B")]
		void Dispatch<T1, T2, T3, T4>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

		// Token: 0x0600035C RID: 860
		[Token(Token = "0x600035C")]
		void Dispatch<T1, T2, T3, T4, T5>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

		// Token: 0x0600035D RID: 861
		[Token(Token = "0x600035D")]
		void Dispatch<T1, T2, T3, T4, T5, T6>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);

		// Token: 0x0600035E RID: 862
		[Token(Token = "0x600035E")]
		void Dispatch<T1, T2, T3, T4, T5, T6, T7>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);

		// Token: 0x0600035F RID: 863
		[Token(Token = "0x600035F")]
		void Dispatch<T1, T2, T3, T4, T5, T6, T7, T8>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);

		// Token: 0x06000360 RID: 864
		[Token(Token = "0x6000360")]
		void Dispatch<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);
	}
}
