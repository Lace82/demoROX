using System;
using Il2CppDummyDll;

namespace GCloud.UQM
{
	// Token: 0x020000E9 RID: 233
	[Token(Token = "0x20000BE")]
	public class UQM
	{
		// Token: 0x06000881 RID: 2177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x27767D0", Offset = "0x2775BD0", VA = "0x1827767D0")]
		public static void Init()
		{
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public UQM()
		{
		}

		// Token: 0x04000412 RID: 1042
		[Token(Token = "0x4000354")]
		public const string LibName = "__Internal";

		// Token: 0x04000413 RID: 1043
		[Token(Token = "0x4000355")]
		[FieldOffset(Offset = "0x0")]
		private static bool initialized;

		// Token: 0x04000414 RID: 1044
		[Token(Token = "0x4000356")]
		[FieldOffset(Offset = "0x1")]
		public static bool isDebug;
	}
}
