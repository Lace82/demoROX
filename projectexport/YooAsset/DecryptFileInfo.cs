using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000C8 RID: 200
	[Token(Token = "0x2000093")]
	public struct DecryptFileInfo
	{
		// Token: 0x04000340 RID: 832
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x0")]
		public string BundleName;

		// Token: 0x04000341 RID: 833
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x8")]
		public string FileLoadPath;

		// Token: 0x04000342 RID: 834
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x10")]
		public uint ConentCRC;
	}
}
