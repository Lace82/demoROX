using System;
using Il2CppDummyDll;
using UnityEngine;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x02000185 RID: 389
	[Token(Token = "0x200012D")]
	public sealed class VarUnityObject : Variable<UnityEngine.Object>
	{
		// Token: 0x06000B30 RID: 2864 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x3892860", Offset = "0x3891C60", VA = "0x183892860")]
		public static implicit operator VarUnityObject(UnityEngine.Object value)
		{
			return null;
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x38928E0", Offset = "0x3891CE0", VA = "0x1838928E0")]
		public static implicit operator UnityEngine.Object(VarUnityObject value)
		{
			return null;
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x3892820", Offset = "0x3891C20", VA = "0x183892820")]
		public VarUnityObject()
		{
		}
	}
}
