using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	internal sealed class EventPool<T> where T : BaseEventArgs
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000044")]
		public EventPool()
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x17000015")]
		public int EventHandlerCount
		{
			[Token(Token = "0x6000045")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x17000016")]
		public int EventCount
		{
			[Token(Token = "0x6000046")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000047")]
		public void Tick()
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000048")]
		public void Dispose()
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000049")]
		public void Clear()
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x600004A")]
		public int Count(int id)
		{
			return 0;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x600004B")]
		public bool Check(int id, EventHandler<T> handler)
		{
			return default(bool);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004C")]
		public void Subscribe(int id, EventHandler<T> handler)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004D")]
		public void Subscribe(string evt, Action callback)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004E")]
		public void Subscribe<T1>(string evt, Action<T1> callback)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004F")]
		public void Subscribe<T1, T2>(string evt, Action<T1, T2> callback)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000050")]
		public void Subscribe<T1, T2, T3>(string evt, Action<T1, T2, T3> callback)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000051")]
		public void Subscribe<T1, T2, T3, T4>(string evt, Action<T1, T2, T3, T4> callback)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000052")]
		public void Subscribe<T1, T2, T3, T4, T5>(string evt, Action<T1, T2, T3, T4, T5> callback)
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000053")]
		public void Subscribe<T1, T2, T3, T4, T5, T6>(string evt, Action<T1, T2, T3, T4, T5, T6> callback)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000054")]
		public void Subscribe<T1, T2, T3, T4, T5, T6, T7>(string evt, Action<T1, T2, T3, T4, T5, T6, T7> callback)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000055")]
		public void Subscribe<T1, T2, T3, T4, T5, T6, T7, T8>(string evt, Action<T1, T2, T3, T4, T5, T6, T7, T8> callback)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000056")]
		public void Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string evt, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> callback)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000057")]
		private void AddDelegateListener(string evt, Delegate callback)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000058")]
		public void UnSubscribe(int id, EventHandler<T> handler)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000059")]
		public void UnSubscribe(string evt, Action callback)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005A")]
		public void UnSubscribe<T1>(string evt, Action<T1> callback)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005B")]
		public void UnSubscribe<T1, T2>(string evt, Action<T1, T2> callback)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005C")]
		public void UnSubscribe<T1, T2, T3>(string evt, Action<T1, T2, T3> callback)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005D")]
		public void UnSubscribe<T1, T2, T3, T4>(string evt, Action<T1, T2, T3, T4> callback)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005E")]
		public void UnSubscribe<T1, T2, T3, T4, T5>(string evt, Action<T1, T2, T3, T4, T5> callback)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005F")]
		public void UnSubscribe<T1, T2, T3, T4, T5, T6>(string evt, Action<T1, T2, T3, T4, T5, T6> callback)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000060")]
		public void UnSubscribe<T1, T2, T3, T4, T5, T6, T7>(string evt, Action<T1, T2, T3, T4, T5, T6, T7> callback)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000061")]
		public void UnSubscribe<T1, T2, T3, T4, T5, T6, T7, T8>(string evt, Action<T1, T2, T3, T4, T5, T6, T7, T8> callback)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000062")]
		public void UnSubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string evt, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> callback)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000063")]
		private void RemoveDelegateListener(string evt, Delegate callback)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000064")]
		public void DispatchSafe(object sender, T args)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000065")]
		public void Dispatch(object sender, T args)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000066")]
		public void Dispatch(string evt)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000067")]
		public void Dispatch<T1>(string evt, T1 arg)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000068")]
		public void Dispatch<T1, T2>(string evt, T1 arg1, T2 arg2)
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000069")]
		public void Dispatch<T1, T2, T3>(string evt, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006A")]
		public void Dispatch<T1, T2, T3, T4>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006B")]
		public void Dispatch<T1, T2, T3, T4, T5>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006C")]
		public void Dispatch<T1, T2, T3, T4, T5, T6>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006D")]
		public void Dispatch<T1, T2, T3, T4, T5, T6, T7>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006E")]
		public void Dispatch<T1, T2, T3, T4, T5, T6, T7, T8>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006F")]
		public void Dispatch<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000070")]
		private void HandleEvent(object sender, T args)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000071")]
		private void HandleEvent(string evt)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000072")]
		private void HandleEvent<T1>(string evt, T1 arg)
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000073")]
		private void HandleEvent<T1, T2>(string evt, T1 arg1, T2 arg2)
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000074")]
		private void HandleEvent<T1, T2, T3>(string evt, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000075")]
		private void HandleEvent<T1, T2, T3, T4>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000076")]
		private void HandleEvent<T1, T2, T3, T4, T5>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000077")]
		private void HandleEvent<T1, T2, T3, T4, T5, T6>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000078")]
		private void HandleEvent<T1, T2, T3, T4, T5, T6, T7>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000079")]
		private void HandleEvent<T1, T2, T3, T4, T5, T6, T7, T8>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007A")]
		private void HandleEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x0")]
		private readonly MultiValueDictionary<int, EventHandler<T>> _eventHandlers;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x0")]
		private readonly Queue<EventPool<T>.Event> _events;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x0")]
		private readonly Dictionary<object, LinkedListNode<EventHandler<T>>> _cacheNodes;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x0")]
		private readonly Dictionary<object, LinkedListNode<EventHandler<T>>> _tmpNodes;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x0")]
		private readonly Dictionary<string, DelegateEventArgs> _delegateHandler;

		// Token: 0x0200000D RID: 13
		[Token(Token = "0x200000D")]
		private sealed class Event : IReference
		{
			// Token: 0x0600007B RID: 123 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600007B")]
			public Event()
			{
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x0600007C RID: 124 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x0600007D RID: 125 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000017")]
			public object Sender
			{
				[Token(Token = "0x600007C")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600007D")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				private set
				{
				}
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x0600007E RID: 126 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x0600007F RID: 127 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000018")]
			public T EventArgs
			{
				[Token(Token = "0x600007E")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600007F")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				private set
				{
				}
			}

			// Token: 0x06000080 RID: 128 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000080")]
			public static EventPool<T>.Event Create(object sender, T args)
			{
				return null;
			}

			// Token: 0x06000081 RID: 129 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000081")]
			public void Clear()
			{
			}

			// Token: 0x04000033 RID: 51
			[Token(Token = "0x4000033")]
			[FieldOffset(Offset = "0x0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private object <Sender>k__BackingField;

			// Token: 0x04000034 RID: 52
			[Token(Token = "0x4000034")]
			[FieldOffset(Offset = "0x0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private T <EventArgs>k__BackingField;
		}
	}
}
