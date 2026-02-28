using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XGameFramework;

namespace YooAsset
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x200001E")]
	[Serializable]
	internal class DebugReport : IReference
	{
		// Token: 0x06000096 RID: 150 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1812780", Offset = "0x1811B80", VA = "0x181812780")]
		public static byte[] Serialize(DebugReport debugReport)
		{
			return null;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1812740", Offset = "0x1811B40", VA = "0x181812740")]
		public static DebugReport Deserialize(byte[] data)
		{
			return null;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1812610", Offset = "0x1811A10", VA = "0x181812610", Slot = "4")]
		public void Clear()
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x18127C0", Offset = "0x1811BC0", VA = "0x1818127C0")]
		public DebugReport()
		{
		}

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x10")]
		public int FrameCount;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x18")]
		public List<DebugPackageData> PackageDatas;
	}
}
