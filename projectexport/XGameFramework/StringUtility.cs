using System;
using System.Text;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	public static class StringUtility
	{
		// Token: 0x060001AF RID: 431 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2B9D830", Offset = "0x2B9CC30", VA = "0x182B9D830")]
		public static string Format(string format, object arg0)
		{
			return null;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2B9D920", Offset = "0x2B9CD20", VA = "0x182B9D920")]
		public static string Format(string format, object arg0, object arg1)
		{
			return null;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2B9DA20", Offset = "0x2B9CE20", VA = "0x182B9DA20")]
		public static string Format(string format, object arg0, object arg1, object arg2)
		{
			return null;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2B9D700", Offset = "0x2B9CB00", VA = "0x182B9D700")]
		public static string Format(string format, params object[] args)
		{
			return null;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2B9DB40", Offset = "0x2B9CF40", VA = "0x182B9DB40")]
		private static void LazyCreateStringBuilder()
		{
		}

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[ThreadStatic]
		private static StringBuilder _cachedStringBuilder;
	}
}
