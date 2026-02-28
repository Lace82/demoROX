using System;
using System.Collections.Concurrent;
using System.Threading;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x2000032")]
	internal sealed class ThreadSyncContext : SynchronizationContext
	{
		// Token: 0x06000124 RID: 292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1BBA9E0", Offset = "0x1BB9DE0", VA = "0x181BBA9E0")]
		public void Update()
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1BBA910", Offset = "0x1BB9D10", VA = "0x181BBA910", Slot = "5")]
		public override void Post(SendOrPostCallback callback, object state)
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1BBAA60", Offset = "0x1BB9E60", VA = "0x181BBAA60")]
		public ThreadSyncContext()
		{
		}

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x18")]
		private readonly ConcurrentQueue<Action> _safeQueue;

		// Token: 0x0200003F RID: 63
		[Token(Token = "0x20000B6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06000127 RID: 295 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x06000128 RID: 296 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x1BBAAD0", Offset = "0x1BB9ED0", VA = "0x181BBAAD0")]
			internal void <Post>b__0()
			{
			}

			// Token: 0x04000100 RID: 256
			[Token(Token = "0x40002A4")]
			[FieldOffset(Offset = "0x10")]
			public SendOrPostCallback callback;

			// Token: 0x04000101 RID: 257
			[Token(Token = "0x40002A5")]
			[FieldOffset(Offset = "0x18")]
			public object state;
		}
	}
}
