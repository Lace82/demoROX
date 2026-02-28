using System;
using Il2CppDummyDll;
using UnityEngine;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x02000175 RID: 373
	[Token(Token = "0x200011D")]
	public sealed class VarGameObject : Variable<GameObject>
	{
		// Token: 0x06000B02 RID: 2818 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009B7")]
		[Address(RVA = "0xEDA0D0", Offset = "0xED94D0", VA = "0x180EDA0D0")]
		public static implicit operator VarGameObject(GameObject value)
		{
			return null;
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009B8")]
		[Address(RVA = "0xEDA090", Offset = "0xED9490", VA = "0x180EDA090")]
		public static implicit operator GameObject(VarGameObject value)
		{
			return null;
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B9")]
		[Address(RVA = "0xEDA050", Offset = "0xED9450", VA = "0x180EDA050")]
		public VarGameObject()
		{
		}
	}
}
