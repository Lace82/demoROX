using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x200002B")]
	public class RequestHelper
	{
		// Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1BB1990", Offset = "0x1BB0D90", VA = "0x181BB1990")]
		public static void RecordRequestFailed(string packageName, string eventName)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1BB1860", Offset = "0x1BB0C60", VA = "0x181BB1860")]
		public static int GetRequestFailedCount(string packageName, string eventName)
		{
			return 0;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public RequestHelper()
		{
		}

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x4681834")]
		private static readonly Dictionary<string, int> _requestFailedRecorder;
	}
}
