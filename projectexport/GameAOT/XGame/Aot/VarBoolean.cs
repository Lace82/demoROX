using System;
using Il2CppDummyDll;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x0200016B RID: 363
	[Token(Token = "0x2000113")]
	public sealed class VarBoolean : Variable<bool>
	{
		// Token: 0x06000AE4 RID: 2788 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000999")]
		[Address(RVA = "0xED9730", Offset = "0xED8B30", VA = "0x180ED9730")]
		public static implicit operator VarBoolean(bool value)
		{
			return null;
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00004710 File Offset: 0x00002910
		[Token(Token = "0x600099A")]
		[Address(RVA = "0xED96F0", Offset = "0xED8AF0", VA = "0x180ED96F0")]
		public static implicit operator bool(VarBoolean value)
		{
			return default(bool);
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600099B")]
		[Address(RVA = "0xED96B0", Offset = "0xED8AB0", VA = "0x180ED96B0")]
		public VarBoolean()
		{
		}
	}
}
