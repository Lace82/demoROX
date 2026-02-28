using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	internal sealed class TaskPool<T> where T : TaskBase
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D6")]
		public TaskPool()
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000230C File Offset: 0x0000050C
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000028")]
		public bool Paused
		{
			[Token(Token = "0x60000D7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x17000029")]
		public int FreeAgentCount
		{
			[Token(Token = "0x60000D9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x1700002A")]
		public int RunningAgentCount
		{
			[Token(Token = "0x60000DA")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x1700002B")]
		public int WaitingTaskCount
		{
			[Token(Token = "0x60000DB")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x1700002C")]
		public int TotalAgentCount
		{
			[Token(Token = "0x60000DC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DD")]
		public void Tick(double deltaTime)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DE")]
		public void Dispose()
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DF")]
		public void AddAgent(ITaskAgent<T> agent)
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E0")]
		public void AddTask(T task)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x60000E1")]
		public bool RemoveTask(int taskId)
		{
			return default(bool);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000E2")]
		public TaskInfo[] GetAllTaskInfos()
		{
			return null;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E3")]
		private void ProcessRunningTasks(double deltaTime)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E4")]
		private void ProcessWaitingTasks()
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E5")]
		public void RemoveAllTasks()
		{
		}

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x0")]
		private readonly Stack<ITaskAgent<T>> _freeAgents;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x0")]
		private readonly LinkedListQueue<ITaskAgent<T>> _runningAgents;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x0")]
		private readonly LinkedListQueue<T> _waitingTasks;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private bool <Paused>k__BackingField;
	}
}
