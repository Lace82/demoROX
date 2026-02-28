using System;
using Il2CppDummyDll;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x02000169 RID: 361
	[Token(Token = "0x2000111")]
	public static class XLogFactory
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000069")]
		public static XGameFrameworkLog.ILogHelper DefaultLogHelper
		{
			[Token(Token = "0x6000994")]
			[Address(RVA = "0x38935D0", Offset = "0x38929D0", VA = "0x1838935D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400062C RID: 1580
		[Token(Token = "0x40004B7")]
		[FieldOffset(Offset = "0x50390")]
		private static readonly DefaultLog Default;
	}
}
