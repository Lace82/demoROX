using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x2000026")]
	public struct DownloadStatus
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x18152F0", Offset = "0x18146F0", VA = "0x1818152F0")]
		public static DownloadStatus CreateDefaultStatus()
		{
			return default(DownloadStatus);
		}

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x0")]
		public bool IsDone;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x4")]
		public float Progress;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x8")]
		public ulong TotalBytes;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x10")]
		public ulong DownloadedBytes;
	}
}
