using System;
using Il2CppDummyDll;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x0200017E RID: 382
	[Token(Token = "0x2000126")]
	public sealed class VarSingle : Variable<float>
	{
		// Token: 0x06000B1B RID: 2843 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0xEDAA90", Offset = "0xED9E90", VA = "0x180EDAA90")]
		public static implicit operator VarSingle(float value)
		{
			return null;
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00004860 File Offset: 0x00002A60
		[Token(Token = "0x60009D1")]
		[Address(RVA = "0xEDAB00", Offset = "0xED9F00", VA = "0x180EDAB00")]
		public static implicit operator float(VarSingle value)
		{
			return 0f;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D2")]
		[Address(RVA = "0xEDAA50", Offset = "0xED9E50", VA = "0x180EDAA50")]
		public VarSingle()
		{
		}
	}
}
