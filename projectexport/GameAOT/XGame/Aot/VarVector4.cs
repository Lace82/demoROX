using System;
using Il2CppDummyDll;
using UnityEngine;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x02000188 RID: 392
	[Token(Token = "0x2000130")]
	public sealed class VarVector4 : Variable<Vector4>
	{
		// Token: 0x06000B39 RID: 2873 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x3892BD0", Offset = "0x3891FD0", VA = "0x183892BD0")]
		public static implicit operator VarVector4(Vector4 value)
		{
			return null;
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x000048F0 File Offset: 0x00002AF0
		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x3892B80", Offset = "0x3891F80", VA = "0x183892B80")]
		public static implicit operator Vector4(VarVector4 value)
		{
			return default(Vector4);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x3892B40", Offset = "0x3891F40", VA = "0x183892B40")]
		public VarVector4()
		{
		}
	}
}
