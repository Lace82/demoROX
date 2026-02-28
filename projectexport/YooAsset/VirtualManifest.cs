using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000019")]
	[Serializable]
	public class VirtualManifest
	{
		// Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x38964E0", Offset = "0x38958E0", VA = "0x1838964E0")]
		public VirtualManifest()
		{
		}

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x10")]
		public List<VirtualFileMeta> MetaFiles;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x18")]
		public byte[] buffer;
	}
}
