using System;
using Il2CppDummyDll;

namespace NLPC
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000031")]
	public struct SharingMem
	{
		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x0")]
		public bool installTransCallbackFlag;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x8")]
		public IntPtr installTransCallbacker;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x10")]
		public bool sendTransResultFlag;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x18")]
		public IntPtr sendTransResultCallbacker;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x20")]
		public bool accountFlag;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x28")]
		public IntPtr accountCallbacker;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x30")]
		public bool initAppFlag;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x38")]
		public IntPtr initAppCallbacker;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x40")]
		public bool configFlag;

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x48")]
		public IntPtr configCallbackS;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x50")]
		public bool ruleCrashFlag;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x58")]
		public IntPtr ruleCrashCallbackS;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x60")]
		public bool sdkFuncFlag;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x68")]
		public IntPtr sdkFuncFactory;
	}
}
