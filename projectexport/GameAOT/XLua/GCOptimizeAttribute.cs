using System;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x200001C")]
	public class GCOptimizeAttribute : Attribute
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060002BC RID: 700 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x17000024")]
		public OptimizeFlag Flag
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x8F5450", Offset = "0x8F4850", VA = "0x1808F5450")]
			get
			{
				return OptimizeFlag.Default;
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x943510", Offset = "0x942910", VA = "0x180943510")]
		public GCOptimizeAttribute(OptimizeFlag flag = OptimizeFlag.Default)
		{
		}

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x10")]
		private readonly OptimizeFlag flag;
	}
}
