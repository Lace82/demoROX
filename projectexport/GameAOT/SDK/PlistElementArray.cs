using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace SDK
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000060")]
	public class PlistElementArray : PlistElement
	{
		// Token: 0x0600045D RID: 1117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1382920", Offset = "0x1381D20", VA = "0x181382920")]
		public PlistElementArray()
		{
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1382890", Offset = "0x1381C90", VA = "0x181382890")]
		public void AddString(string val)
		{
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1382810", Offset = "0x1381C10", VA = "0x181382810")]
		public void AddInteger(int val)
		{
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x13826D0", Offset = "0x1381AD0", VA = "0x1813826D0")]
		public void AddBoolean(bool val)
		{
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1382610", Offset = "0x1381A10", VA = "0x181382610")]
		public PlistElementArray AddArray()
		{
			return null;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1382750", Offset = "0x1381B50", VA = "0x181382750")]
		public PlistElementDict AddDict()
		{
			return null;
		}

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x10")]
		public List<PlistElement> values;
	}
}
