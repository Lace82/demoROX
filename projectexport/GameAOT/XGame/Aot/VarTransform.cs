using System;
using Il2CppDummyDll;
using UnityEngine;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x02000181 RID: 385
	[Token(Token = "0x2000129")]
	public sealed class VarTransform : Variable<Transform>
	{
		// Token: 0x06000B24 RID: 2852 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009D9")]
		[Address(RVA = "0xEDAD80", Offset = "0xEDA180", VA = "0x180EDAD80")]
		public static implicit operator VarTransform(Transform value)
		{
			return null;
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009DA")]
		[Address(RVA = "0xEDAE00", Offset = "0xEDA200", VA = "0x180EDAE00")]
		public static implicit operator Transform(VarTransform value)
		{
			return null;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009DB")]
		[Address(RVA = "0xEDAD40", Offset = "0xEDA140", VA = "0x180EDAD40")]
		public VarTransform()
		{
		}
	}
}
