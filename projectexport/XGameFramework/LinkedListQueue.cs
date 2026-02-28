using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	public class LinkedListQueue<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection
	{
		// Token: 0x0600016C RID: 364 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600016C")]
		public LinkedListQueue()
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00002714 File Offset: 0x00000914
		[Token(Token = "0x17000036")]
		public int Count
		{
			[Token(Token = "0x600016D")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000037")]
		public LinkedListNode<T> First
		{
			[Token(Token = "0x600016E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000038")]
		public LinkedListNode<T> Last
		{
			[Token(Token = "0x600016F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0000272C File Offset: 0x0000092C
		[Token(Token = "0x17000039")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000170")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700003A")]
		public object SyncRoot
		{
			[Token(Token = "0x6000171")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00002744 File Offset: 0x00000944
		[Token(Token = "0x1700003B")]
		public bool IsSynchronized
		{
			[Token(Token = "0x6000172")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000173")]
		public LinkedListNode<T> AddAfter(LinkedListNode<T> node, T value)
		{
			return null;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000174")]
		private LinkedListNode<T> AcquireNode(T value)
		{
			return null;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000175")]
		public LinkedListNode<T> AddBefore(LinkedListNode<T> node, T value)
		{
			return null;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000176")]
		public LinkedListNode<T> AddFirst(T value)
		{
			return null;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000177")]
		public LinkedListNode<T> AddLast(T value)
		{
			return null;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000178")]
		public void Clear()
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000179")]
		private void ReleaseNode(LinkedListNode<T> node)
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000275C File Offset: 0x0000095C
		[Token(Token = "0x600017A")]
		public bool Contains(T value)
		{
			return default(bool);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017B")]
		public void CopyTo(T[] array, int index)
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017C")]
		public void CopyTo(Array array, int index)
		{
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002774 File Offset: 0x00000974
		[Token(Token = "0x600017D")]
		public bool Remove(T value)
		{
			return default(bool);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017E")]
		public void Remove(LinkedListNode<T> node)
		{
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017F")]
		public void RemoveFirst()
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000278C File Offset: 0x0000098C
		[Token(Token = "0x6000180")]
		public LinkedListQueue<T>.Enumerator GetEnumerator()
		{
			return default(LinkedListQueue<T>.Enumerator);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000181")]
		private void Add(T value)
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000182")]
		private IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000183")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly LinkedList<T> _linkedList;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Queue<LinkedListNode<T>> _cachedNodes;

		// Token: 0x02000029 RID: 41
		[Token(Token = "0x2000029")]
		[StructLayout(LayoutKind.Auto)]
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			// Token: 0x06000184 RID: 388 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000184")]
			internal Enumerator(LinkedList<T> linkedList)
			{
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x06000185 RID: 389 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700003C")]
			public T Current
			{
				[Token(Token = "0x6000185")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x06000186 RID: 390 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700003D")]
			private object Current
			{
				[Token(Token = "0x6000186")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000187 RID: 391 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000187")]
			public void Dispose()
			{
			}

			// Token: 0x06000188 RID: 392 RVA: 0x000027A4 File Offset: 0x000009A4
			[Token(Token = "0x6000188")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06000189 RID: 393 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000189")]
			private void Reset()
			{
			}

			// Token: 0x0400006C RID: 108
			[Token(Token = "0x400006C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private LinkedList<T>.Enumerator _Enumerator;
		}
	}
}
