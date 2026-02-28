using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000017")]
	public class VirtualFileManager
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000012")]
		public static VirtualFileManager Instance
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x3896400", Offset = "0x3895800", VA = "0x183896400")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x3896060", Offset = "0x3895460", VA = "0x183896060")]
		public byte[] GetAssetData(string bundlePath, string assetPath)
		{
			return null;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x3896390", Offset = "0x3895790", VA = "0x183896390")]
		public VirtualFileManager()
		{
		}

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x0")]
		private static VirtualFileManager _instance;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, VirtualManifest> _manifests;
	}
}
