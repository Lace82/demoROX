using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000018")]
	[Serializable]
	public class VirtualFileMeta
	{
		// Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public VirtualFileMeta()
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x388B5E0", Offset = "0x388A9E0", VA = "0x18388B5E0")]
		public VirtualFileMeta(string name, long offset, long size)
		{
		}

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x18")]
		public long Offset;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x20")]
		public long Size;
	}
}
