using System;
using Il2CppDummyDll;

namespace XGameFramework.Event
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	internal sealed class EventManager : ITick, IEventManager, IModule
	{
		// Token: 0x06000310 RID: 784 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x2B94070", Offset = "0x2B93470", VA = "0x182B94070", Slot = "44")]
		public void OnInit()
		{
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000311 RID: 785 RVA: 0x00002E34 File Offset: 0x00001034
		[Token(Token = "0x17000081")]
		public int EventHandleCount
		{
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x2B94380", Offset = "0x2B93780", VA = "0x182B94380", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000312 RID: 786 RVA: 0x00002E4C File Offset: 0x0000104C
		[Token(Token = "0x17000082")]
		public int EventCount
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x2B94330", Offset = "0x2B93730", VA = "0x182B94330", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00002E64 File Offset: 0x00001064
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x14C5D30", Offset = "0x14C5130", VA = "0x1814C5D30", Slot = "5")]
		public int GetPriority()
		{
			return 0;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x2B94200", Offset = "0x2B93600", VA = "0x182B94200", Slot = "4")]
		public void Tick(double deltaTime)
		{
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x2B940D0", Offset = "0x2B934D0", VA = "0x182B940D0", Slot = "45")]
		public void Shutdown()
		{
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00002E7C File Offset: 0x0000107C
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x2B93ED0", Offset = "0x2B932D0", VA = "0x182B93ED0", Slot = "8")]
		public int Count(int id)
		{
			return 0;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002E94 File Offset: 0x00001094
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x2B93E60", Offset = "0x2B93260", VA = "0x182B93E60", Slot = "9")]
		public bool Check(int id, EventHandler<BaseEventArgs> handler)
		{
			return default(bool);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x2B94120", Offset = "0x2B93520", VA = "0x182B94120", Slot = "10")]
		public void Subscribe(int id, EventHandler<BaseEventArgs> handler)
		{
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x2B94190", Offset = "0x2B93590", VA = "0x182B94190", Slot = "11")]
		public void Subscribe(string evt, Action callback)
		{
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600031A")]
		public void Subscribe<T1>(string evt, Action<T1> callback)
		{
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600031B")]
		public void Subscribe<T1, T2>(string evt, Action<T1, T2> callback)
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600031C")]
		public void Subscribe<T1, T2, T3>(string evt, Action<T1, T2, T3> callback)
		{
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600031D")]
		public void Subscribe<T1, T2, T3, T4>(string evt, Action<T1, T2, T3, T4> callback)
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600031E")]
		public void Subscribe<T1, T2, T3, T4, T5>(string evt, Action<T1, T2, T3, T4, T5> callback)
		{
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600031F")]
		public void Subscribe<T1, T2, T3, T4, T5, T6>(string evt, Action<T1, T2, T3, T4, T5, T6> callback)
		{
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000320")]
		public void Subscribe<T1, T2, T3, T4, T5, T6, T7>(string evt, Action<T1, T2, T3, T4, T5, T6, T7> callback)
		{
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000321")]
		public void Subscribe<T1, T2, T3, T4, T5, T6, T7, T8>(string evt, Action<T1, T2, T3, T4, T5, T6, T7, T8> callback)
		{
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000322")]
		public void Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string evt, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> callback)
		{
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x2B94250", Offset = "0x2B93650", VA = "0x182B94250", Slot = "21")]
		public void UnSubscribe(int id, EventHandler<BaseEventArgs> handler)
		{
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x2B942C0", Offset = "0x2B936C0", VA = "0x182B942C0", Slot = "22")]
		public void UnSubscribe(string evt, Action callback)
		{
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000325")]
		public void UnSubscribe<T1>(string evt, Action<T1> callback)
		{
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000326")]
		public void UnSubscribe<T1, T2>(string evt, Action<T1, T2> callback)
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000327")]
		public void UnSubscribe<T1, T2, T3>(string evt, Action<T1, T2, T3> callback)
		{
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000328")]
		public void UnSubscribe<T1, T2, T3, T4>(string evt, Action<T1, T2, T3, T4> callback)
		{
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000329")]
		public void UnSubscribe<T1, T2, T3, T4, T5>(string evt, Action<T1, T2, T3, T4, T5> callback)
		{
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600032A")]
		public void UnSubscribe<T1, T2, T3, T4, T5, T6>(string evt, Action<T1, T2, T3, T4, T5, T6> callback)
		{
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600032B")]
		public void UnSubscribe<T1, T2, T3, T4, T5, T6, T7>(string evt, Action<T1, T2, T3, T4, T5, T6, T7> callback)
		{
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600032C")]
		public void UnSubscribe<T1, T2, T3, T4, T5, T6, T7, T8>(string evt, Action<T1, T2, T3, T4, T5, T6, T7, T8> callback)
		{
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600032D")]
		public void UnSubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string evt, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> callback)
		{
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x2B93F30", Offset = "0x2B93330", VA = "0x182B93F30", Slot = "32")]
		public void DispatchSafe(object sender, BaseEventArgs e)
		{
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x2B94000", Offset = "0x2B93400", VA = "0x182B94000", Slot = "33")]
		public void Dispatch(object sender, BaseEventArgs e)
		{
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x2B93FA0", Offset = "0x2B933A0", VA = "0x182B93FA0", Slot = "34")]
		public void Dispatch(string evt)
		{
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000331")]
		public void Dispatch<T>(string evt, T arg)
		{
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000332")]
		public void Dispatch<T1, T2>(string evt, T1 arg1, T2 arg2)
		{
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000333")]
		public void Dispatch<T1, T2, T3>(string evt, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000334")]
		public void Dispatch<T1, T2, T3, T4>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000335")]
		public void Dispatch<T1, T2, T3, T4, T5>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000336")]
		public void Dispatch<T1, T2, T3, T4, T5, T6>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000337")]
		public void Dispatch<T1, T2, T3, T4, T5, T6, T7>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000338")]
		public void Dispatch<T1, T2, T3, T4, T5, T6, T7, T8>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000339")]
		public void Dispatch<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public EventManager()
		{
		}

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x10")]
		private EventPool<BaseEventArgs> _eventPool;
	}
}
