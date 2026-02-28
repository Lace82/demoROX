using System;
using Il2CppDummyDll;
using UnityEngine;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x02000187 RID: 391
	[Token(Token = "0x200012F")]
	public sealed class VarVector3 : Variable<Vector3>
	{
		// Token: 0x06000B36 RID: 2870 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x3892A70", Offset = "0x3891E70", VA = "0x183892A70")]
		public static implicit operator VarVector3(Vector3 value)
		{
			return null;
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x000048D8 File Offset: 0x00002AD8
		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x3892AE0", Offset = "0x3891EE0", VA = "0x183892AE0")]
		public static implicit operator Vector3(VarVector3 value)
		{
			return default(Vector3);
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x3892A30", Offset = "0x3891E30", VA = "0x183892A30")]
		public VarVector3()
		{
		}
	}
}
