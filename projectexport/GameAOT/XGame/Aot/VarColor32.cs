using System;
using Il2CppDummyDll;
using UnityEngine;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x02000171 RID: 369
	[Token(Token = "0x2000119")]
	public sealed class VarColor32 : Variable<Color32>
	{
		// Token: 0x06000AF6 RID: 2806 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009AB")]
		[Address(RVA = "0xED9C00", Offset = "0xED9000", VA = "0x180ED9C00")]
		public static implicit operator VarColor32(Color32 value)
		{
			return null;
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00004770 File Offset: 0x00002970
		[Token(Token = "0x60009AC")]
		[Address(RVA = "0xED9BC0", Offset = "0xED8FC0", VA = "0x180ED9BC0")]
		public static implicit operator Color32(VarColor32 value)
		{
			return default(Color32);
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AD")]
		[Address(RVA = "0xED9B80", Offset = "0xED8F80", VA = "0x180ED9B80")]
		public VarColor32()
		{
		}
	}
}
