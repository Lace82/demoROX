using System;
using Il2CppDummyDll;
using UnityEngine;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x02000179 RID: 377
	[Token(Token = "0x2000121")]
	public sealed class VarMaterial : Variable<Material>
	{
		// Token: 0x06000B0E RID: 2830 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009C3")]
		[Address(RVA = "0xEDA460", Offset = "0xED9860", VA = "0x180EDA460")]
		public static implicit operator VarMaterial(Material value)
		{
			return null;
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009C4")]
		[Address(RVA = "0xEDA4E0", Offset = "0xED98E0", VA = "0x180EDA4E0")]
		public static implicit operator Material(VarMaterial value)
		{
			return null;
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C5")]
		[Address(RVA = "0xEDA420", Offset = "0xED9820", VA = "0x180EDA420")]
		public VarMaterial()
		{
		}
	}
}
