using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x02000094 RID: 148
	[Token(Token = "0x2000069")]
	public struct GMECustomStreamFrame
	{
		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x0")]
		public ulong uin;

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x8")]
		public IntPtr data;

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x10")]
		public uint length;

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x18")]
		public ulong timestamp;
	}
}
