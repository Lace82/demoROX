using System;
using Il2CppDummyDll;

namespace NLPC
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200002E")]
	internal class MyAtomic<T>
	{
		// Token: 0x060002FD RID: 765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025A")]
		public MyAtomic()
		{
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025B")]
		public MyAtomic(T value)
		{
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025C")]
		public void setValue(T value)
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600025D")]
		public T getValue()
		{
			return null;
		}

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x0")]
		private readonly object vlocker;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x0")]
		private T m_value;
	}
}
