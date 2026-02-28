using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x8FFB0", Offset = "0x8F3B0")]
	public class MultiValueDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, LinkedListRange<TValue>>>, IEnumerable
	{
		// Token: 0x06000199 RID: 409 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000199")]
		public MultiValueDictionary()
		{
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00002834 File Offset: 0x00000A34
		[Token(Token = "0x17000044")]
		public int Count
		{
			[Token(Token = "0x600019A")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600019B RID: 411 RVA: 0x0000284C File Offset: 0x00000A4C
		[Token(Token = "0x17000045")]
		public LinkedListRange<TValue> Item
		{
			[Token(Token = "0x600019B")]
			get
			{
				return default(LinkedListRange<TValue>);
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002864 File Offset: 0x00000A64
		[Token(Token = "0x600019C")]
		public bool Contains(TKey key)
		{
			return default(bool);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000287C File Offset: 0x00000A7C
		[Token(Token = "0x600019D")]
		public bool Contains(TKey key, TValue value)
		{
			return default(bool);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002894 File Offset: 0x00000A94
		[Token(Token = "0x600019E")]
		public bool TryGetValue(TKey key, out LinkedListRange<TValue> range)
		{
			return default(bool);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019F")]
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000028AC File Offset: 0x00000AAC
		[Token(Token = "0x60001A0")]
		public bool Remove(TKey key, TValue value)
		{
			return default(bool);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000028C4 File Offset: 0x00000AC4
		[Token(Token = "0x60001A1")]
		public bool RemoveAll(TKey key)
		{
			return default(bool);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A2")]
		public void Clear()
		{
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000028DC File Offset: 0x00000ADC
		[Token(Token = "0x60001A3")]
		public MultiValueDictionary<TKey, TValue>.Enumerator GetEnumerator()
		{
			return default(MultiValueDictionary<TKey, TValue>.Enumerator);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001A4")]
		private IEnumerator<KeyValuePair<TKey, LinkedListRange<TValue>>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001A5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly LinkedListQueue<TValue> _linkedList;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Dictionary<TKey, LinkedListRange<TValue>> _dictionary;

		// Token: 0x0200002D RID: 45
		[Token(Token = "0x200002D")]
		[StructLayout(LayoutKind.Auto)]
		public struct Enumerator : IEnumerator<KeyValuePair<TKey, LinkedListRange<TValue>>>, IDisposable, IEnumerator
		{
			// Token: 0x060001A6 RID: 422 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001A6")]
			public Enumerator(Dictionary<TKey, LinkedListRange<TValue>> dictionary)
			{
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x060001A7 RID: 423 RVA: 0x000028F4 File Offset: 0x00000AF4
			[Token(Token = "0x17000046")]
			public KeyValuePair<TKey, LinkedListRange<TValue>> Current
			{
				[Token(Token = "0x60001A7")]
				get
				{
					return default(KeyValuePair<TKey, LinkedListRange<TValue>>);
				}
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x060001A8 RID: 424 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000047")]
			private object Current
			{
				[Token(Token = "0x60001A8")]
				get
				{
					return null;
				}
			}

			// Token: 0x060001A9 RID: 425 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001A9")]
			public void Dispose()
			{
			}

			// Token: 0x060001AA RID: 426 RVA: 0x0000290C File Offset: 0x00000B0C
			[Token(Token = "0x60001AA")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x060001AB RID: 427 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001AB")]
			private void Reset()
			{
			}

			// Token: 0x04000074 RID: 116
			[Token(Token = "0x4000074")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Dictionary<TKey, LinkedListRange<TValue>>.Enumerator _enumerator;
		}
	}
}
