using System;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public abstract class BaseEventArgs : XGameFrameworkEventArgs
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000040 RID: 64
		[Token(Token = "0x17000014")]
		public abstract int Id { [Token(Token = "0x6000040")] get; }

		// Token: 0x06000041 RID: 65 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2B8D0D0", Offset = "0x2B8C4D0", VA = "0x182B8D0D0")]
		protected BaseEventArgs()
		{
		}
	}
}
