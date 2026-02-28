using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x2000015")]
	[Serializable]
	public class ShaderInfo
	{
		// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public ShaderInfo()
		{
		}

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x10")]
		public string shaderName;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x18")]
		public string shaderPath;
	}
}
