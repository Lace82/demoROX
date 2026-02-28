using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000BC RID: 188
	[Token(Token = "0x2000088")]
	[Serializable]
	internal class PackageAsset
	{
		// Token: 0x0600037D RID: 893 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1BAB470", Offset = "0x1BAA870", VA = "0x181BAB470")]
		public bool HasTag(string[] tags)
		{
			return default(bool);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public PackageAsset()
		{
		}

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x10")]
		public string Address;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x18")]
		public string AssetPath;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x20")]
		public string AssetGUID;

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x28")]
		public string[] AssetTags;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x30")]
		public int BundleID;
	}
}
