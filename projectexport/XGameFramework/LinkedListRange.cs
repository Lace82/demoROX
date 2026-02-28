using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	[StructLayout(LayoutKind.Auto)]
	public struct LinkedListRange<T> : IEnumerable<T>, IEnumerable
	{
		// Token: 0x0600018A RID: 394 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018A")]
		public LinkedListRange(LinkedListNode<T> first, LinkedListNode<T> terminal)
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600018B RID: 395 RVA: 0x000027BC File Offset: 0x000009BC
		[Token(Token = "0x1700003E")]
		public bool IsValid
		{
			[Token(Token = "0x600018B")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700003F")]
		public LinkedListNode<T> First
		{
			[Token(Token = "0x600018C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000040")]
		public LinkedListNode<T> Terminal
		{
			[Token(Token = "0x600018D")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600018E RID: 398 RVA: 0x000027D4 File Offset: 0x000009D4
		[Token(Token = "0x17000041")]
		public int Count
		{
			[Token(Token = "0x600018E")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000027EC File Offset: 0x000009EC
		[Token(Token = "0x600018F")]
		public bool Contains(T value)
		{
			return default(bool);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002804 File Offset: 0x00000A04
		[Token(Token = "0x6000190")]
		public LinkedListRange<T>.Enumerator GetEnumerator()
		{
			return default(LinkedListRange<T>.Enumerator);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000191")]
		private IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000192")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private readonly LinkedListNode<T> <First>k__BackingField;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private readonly LinkedListNode<T> <Terminal>k__BackingField;

		// Token: 0x0200002B RID: 43
		[Token(Token = "0x200002B")]
		[StructLayout(LayoutKind.Auto)]
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			// Token: 0x06000193 RID: 403 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000193")]
			public Enumerator(LinkedListRange<T> range)
			{
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x06000194 RID: 404 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000042")]
			public T Current
			{
				[Token(Token = "0x6000194")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x06000195 RID: 405 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000043")]
			private object Current
			{
				[Token(Token = "0x6000195")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000196 RID: 406 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000196")]
			public void Dispose()
			{
			}

			// Token: 0x06000197 RID: 407 RVA: 0x0000281C File Offset: 0x00000A1C
			[Token(Token = "0x6000197")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06000198 RID: 408 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000198")]
			private void Reset()
			{
			}

			// Token: 0x0400006F RID: 111
			[Token(Token = "0x400006F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly LinkedListRange<T> _linkedListRange;

			// Token: 0x04000070 RID: 112
			[Token(Token = "0x4000070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private LinkedListNode<T> _current;

			// Token: 0x04000071 RID: 113
			[Token(Token = "0x4000071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T _currentValue;
		}
	}
}
