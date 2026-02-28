using System;
using Il2CppDummyDll;
using UnityEngine;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x0200017B RID: 379
	[Token(Token = "0x2000123")]
	public sealed class VarQuaternion : Variable<Quaternion>
	{
		// Token: 0x06000B12 RID: 2834 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0xEDA5A0", Offset = "0xED99A0", VA = "0x180EDA5A0")]
		public static implicit operator VarQuaternion(Quaternion value)
		{
			return null;
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00004818 File Offset: 0x00002A18
		[Token(Token = "0x60009C8")]
		[Address(RVA = "0xEDA610", Offset = "0xED9A10", VA = "0x180EDA610")]
		public static implicit operator Quaternion(VarQuaternion value)
		{
			return default(Quaternion);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C9")]
		[Address(RVA = "0xEDA560", Offset = "0xED9960", VA = "0x180EDA560")]
		public VarQuaternion()
		{
		}
	}
}
