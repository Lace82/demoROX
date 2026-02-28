using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000006")]
	internal enum EVerifyResult
	{
		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000B")]
		Exception = -7,
		// Token: 0x04000010 RID: 16
		[Token(Token = "0x400000C")]
		CacheNotFound,
		// Token: 0x04000011 RID: 17
		[Token(Token = "0x400000D")]
		InfoFileNotExisted,
		// Token: 0x04000012 RID: 18
		[Token(Token = "0x400000E")]
		DataFileNotExisted,
		// Token: 0x04000013 RID: 19
		[Token(Token = "0x400000F")]
		FileNotComplete,
		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000010")]
		FileOverflow,
		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000011")]
		FileCrcError,
		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000012")]
		None,
		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000013")]
		Succeed
	}
}
