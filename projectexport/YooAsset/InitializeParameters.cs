using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000038")]
	public abstract class InitializeParameters
	{
		// Token: 0x06000139 RID: 313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1BA7A80", Offset = "0x1BA6E80", VA = "0x181BA7A80")]
		protected InitializeParameters()
		{
		}

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x10")]
		public string BuildinRootDirectory;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x18")]
		public string SandboxRootDirectory;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x20")]
		public bool CacheFileAppendExtension;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x24")]
		public EVerifyLevel CacheBootVerifyLevel;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x28")]
		public bool AutoDestroyAssetProvider;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x2C")]
		public uint BreakpointResumeFileSize;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x30")]
		public IDecryptionServices DecryptionServices;
	}
}
