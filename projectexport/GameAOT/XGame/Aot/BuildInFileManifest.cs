using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace XGame.Aot
{
	// Token: 0x02000112 RID: 274
	[Token(Token = "0x20000DD")]
	public class BuildInFileManifest : ScriptableObject
	{
		// Token: 0x06000974 RID: 2420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000877")]
		[Address(RVA = "0x13772C0", Offset = "0x13766C0", VA = "0x1813772C0")]
		public BuildInFileManifest()
		{
		}

		// Token: 0x0400050E RID: 1294
		[Token(Token = "0x4000426")]
		[FieldOffset(Offset = "0x18")]
		public List<BuildInFileManifest.Element> BuildinFiles;

		// Token: 0x02000113 RID: 275
		[Token(Token = "0x2000168")]
		[Serializable]
		public class Element
		{
			// Token: 0x06000975 RID: 2421 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B71")]
			[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
			public Element()
			{
			}

			// Token: 0x0400050F RID: 1295
			[Token(Token = "0x4000595")]
			[FieldOffset(Offset = "0x10")]
			public string PackageName;

			// Token: 0x04000510 RID: 1296
			[Token(Token = "0x4000596")]
			[FieldOffset(Offset = "0x18")]
			public string FileName;

			// Token: 0x04000511 RID: 1297
			[Token(Token = "0x4000597")]
			[FieldOffset(Offset = "0x20")]
			public string FileCRC32;
		}
	}
}
