using System;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x2000021")]
	public class HotfixAttribute : Attribute
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x17000025")]
		public HotfixFlag Flag
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x8F5450", Offset = "0x8F4850", VA = "0x1808F5450")]
			get
			{
				return HotfixFlag.Stateless;
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x943510", Offset = "0x942910", VA = "0x180943510")]
		public HotfixAttribute(HotfixFlag e = HotfixFlag.Stateless)
		{
		}

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x10")]
		private readonly HotfixFlag flag;
	}
}
