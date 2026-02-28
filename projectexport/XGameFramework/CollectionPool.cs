using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class CollectionPool<TCollection, TItem> where TCollection : class, ICollection<TItem>, new()
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000033")]
		public static TCollection Acquire()
		{
			return null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000034")]
		public static void Release(TCollection collection, bool recursive = false)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x6000035")]
		private static bool IsIReference()
		{
			return default(bool);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000036")]
		public CollectionPool()
		{
		}

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Stack<TCollection> _pool;
	}
}
