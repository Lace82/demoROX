using System;
using Il2CppDummyDll;
using UnityEngine;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x02000186 RID: 390
	[Token(Token = "0x200012E")]
	public sealed class VarVector2 : Variable<Vector2>
	{
		// Token: 0x06000B33 RID: 2867 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x38929B0", Offset = "0x3891DB0", VA = "0x1838929B0")]
		public static implicit operator VarVector2(Vector2 value)
		{
			return null;
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x000048C0 File Offset: 0x00002AC0
		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x3892960", Offset = "0x3891D60", VA = "0x183892960")]
		public static implicit operator Vector2(VarVector2 value)
		{
			return default(Vector2);
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x3892920", Offset = "0x3891D20", VA = "0x183892920")]
		public VarVector2()
		{
		}
	}
}
