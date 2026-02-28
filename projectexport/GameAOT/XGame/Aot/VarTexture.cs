using System;
using Il2CppDummyDll;
using UnityEngine;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x02000180 RID: 384
	[Token(Token = "0x2000128")]
	public sealed class VarTexture : Variable<Texture>
	{
		// Token: 0x06000B21 RID: 2849 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009D6")]
		[Address(RVA = "0xEDAC80", Offset = "0xEDA080", VA = "0x180EDAC80")]
		public static implicit operator VarTexture(Texture value)
		{
			return null;
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009D7")]
		[Address(RVA = "0xEDAD00", Offset = "0xEDA100", VA = "0x180EDAD00")]
		public static implicit operator Texture(VarTexture value)
		{
			return null;
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D8")]
		[Address(RVA = "0xEDAC40", Offset = "0xEDA040", VA = "0x180EDAC40")]
		public VarTexture()
		{
		}
	}
}
