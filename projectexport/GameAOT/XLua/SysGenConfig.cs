using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000023")]
	public static class SysGenConfig
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000026")]
		[Attribute(Name = "GCOptimizeAttribute", RVA = "0x90BA0", Offset = "0x8FFA0")]
		private static List<Type> GCOptimize
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x3890730", Offset = "0x388FB30", VA = "0x183890730")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000027")]
		[AdditionalProperties]
		private static Dictionary<Type, List<string>> AdditionalProperties
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x3890530", Offset = "0x388F930", VA = "0x183890530")]
			get
			{
				return null;
			}
		}
	}
}
