using System;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000018")]
	public class LuaCallCSharpAttribute : Attribute
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x17000023")]
		public GenFlag Flag
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x8F5450", Offset = "0x8F4850", VA = "0x1808F5450")]
			get
			{
				return GenFlag.No;
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x943510", Offset = "0x942910", VA = "0x180943510")]
		public LuaCallCSharpAttribute(GenFlag flag = GenFlag.No)
		{
		}

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x10")]
		private readonly GenFlag flag;
	}
}
