using System;
using Il2CppDummyDll;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x02000174 RID: 372
	[Token(Token = "0x200011C")]
	public sealed class VarDouble : Variable<double>
	{
		// Token: 0x06000AFF RID: 2815 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009B4")]
		[Address(RVA = "0xED9FE0", Offset = "0xED93E0", VA = "0x180ED9FE0")]
		public static implicit operator VarDouble(double value)
		{
			return null;
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x000047B8 File Offset: 0x000029B8
		[Token(Token = "0x60009B5")]
		[Address(RVA = "0xED9FA0", Offset = "0xED93A0", VA = "0x180ED9FA0")]
		public static implicit operator double(VarDouble value)
		{
			return 0.0;
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B6")]
		[Address(RVA = "0xED9F60", Offset = "0xED9360", VA = "0x180ED9F60")]
		public VarDouble()
		{
		}
	}
}
