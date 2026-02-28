using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000CA RID: 202
	[Token(Token = "0x2000095")]
	public struct DeliveryFileInfo
	{
		// Token: 0x04000343 RID: 835
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x0")]
		public string BundleName;

		// Token: 0x04000344 RID: 836
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x8")]
		public string FileLoadPath;

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x10")]
		public uint ConentCRC;

		// Token: 0x04000346 RID: 838
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x14")]
		public bool Encrypted;
	}
}
