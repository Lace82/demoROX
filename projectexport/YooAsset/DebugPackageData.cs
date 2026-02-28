using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XGameFramework;

namespace YooAsset
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x200001C")]
	[Serializable]
	internal class DebugPackageData : IReference
	{
		// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1812320", Offset = "0x1811720", VA = "0x181812320", Slot = "4")]
		public void Clear()
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1812460", Offset = "0x1811860", VA = "0x181812460")]
		public DebugPackageData()
		{
		}

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x10")]
		public string PackageName;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x18")]
		public List<DebugProviderInfo> ProviderInfos;
	}
}
