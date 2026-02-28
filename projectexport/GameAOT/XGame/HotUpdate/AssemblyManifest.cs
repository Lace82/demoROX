using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XGame.Aot;

namespace XGame.HotUpdate
{
	// Token: 0x020000FC RID: 252
	[Token(Token = "0x20000CC")]
	[Serializable]
	public class AssemblyManifest
	{
		// Token: 0x06000931 RID: 2353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x388B510", Offset = "0x388A910", VA = "0x18388B510")]
		public AssemblyManifest()
		{
		}

		// Token: 0x04000467 RID: 1127
		[Token(Token = "0x4000394")]
		[FieldOffset(Offset = "0x10")]
		public List<AssemblyMetaData> AOTMetaDatas;

		// Token: 0x04000468 RID: 1128
		[Token(Token = "0x4000395")]
		[FieldOffset(Offset = "0x18")]
		public List<RawFileHash> DheAssembliesHashes;
	}
}
