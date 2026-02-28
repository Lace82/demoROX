using System;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	public abstract class Variable : IReference
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000EE RID: 238
		[Token(Token = "0x1700002F")]
		public abstract Type Type { [Token(Token = "0x60000EE")] get; }

		// Token: 0x060000EF RID: 239
		[Token(Token = "0x60000EF")]
		public abstract object GetValue();

		// Token: 0x060000F0 RID: 240
		[Token(Token = "0x60000F0")]
		public abstract void SetValue(object value);

		// Token: 0x060000F1 RID: 241
		[Token(Token = "0x60000F1")]
		public abstract void Clear();

		// Token: 0x060000F2 RID: 242 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		protected Variable()
		{
		}
	}
}
