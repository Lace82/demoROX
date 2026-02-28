using System;
using Il2CppDummyDll;
using UnityEngine;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x02000170 RID: 368
	[Token(Token = "0x2000118")]
	public sealed class VarColor : Variable<Color>
	{
		// Token: 0x06000AF3 RID: 2803 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009A8")]
		[Address(RVA = "0xED9D00", Offset = "0xED9100", VA = "0x180ED9D00")]
		public static implicit operator VarColor(Color value)
		{
			return null;
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00004758 File Offset: 0x00002958
		[Token(Token = "0x60009A9")]
		[Address(RVA = "0xED9CB0", Offset = "0xED90B0", VA = "0x180ED9CB0")]
		public static implicit operator Color(VarColor value)
		{
			return default(Color);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AA")]
		[Address(RVA = "0xED9C70", Offset = "0xED9070", VA = "0x180ED9C70")]
		public VarColor()
		{
		}
	}
}
