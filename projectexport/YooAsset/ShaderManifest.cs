using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x2000016")]
	[Serializable]
	public class ShaderManifest
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public ShaderManifest()
		{
		}

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x10")]
		public ShaderInfo[] shaderInfos;
	}
}
