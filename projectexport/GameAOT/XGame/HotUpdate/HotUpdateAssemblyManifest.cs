using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XGame.Aot;

namespace XGame.HotUpdate
{
	// Token: 0x020000FE RID: 254
	[Token(Token = "0x20000CE")]
	[Serializable]
	public class HotUpdateAssemblyManifest
	{
		// Token: 0x06000935 RID: 2357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000841")]
		[Address(RVA = "0x388B640", Offset = "0x388AA40", VA = "0x18388B640")]
		public void Clear()
		{
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000842")]
		[Address(RVA = "0x388B6B0", Offset = "0x388AAB0", VA = "0x18388B6B0")]
		public HotUpdateAssemblyManifest()
		{
		}

		// Token: 0x0400046C RID: 1132
		[Token(Token = "0x4000399")]
		[FieldOffset(Offset = "0x10")]
		public List<string> AotMetaAssemblies;

		// Token: 0x0400046D RID: 1133
		[Token(Token = "0x400039A")]
		[FieldOffset(Offset = "0x18")]
		public List<string> HotUpdateAssemblies;

		// Token: 0x0400046E RID: 1134
		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x20")]
		public List<RawFileHash> DheUpdateAssemblies;
	}
}
