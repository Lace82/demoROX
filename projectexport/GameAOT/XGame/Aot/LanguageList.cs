using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XGame.Aot
{
	// Token: 0x02000148 RID: 328
	[Token(Token = "0x20000FB")]
	public class LanguageList
	{
		// Token: 0x06000A27 RID: 2599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FB")]
		[Address(RVA = "0xEC1FD0", Offset = "0xEC13D0", VA = "0x180EC1FD0")]
		public LanguageList(int type)
		{
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FC")]
		[Address(RVA = "0xEC1F20", Offset = "0xEC1320", VA = "0x180EC1F20")]
		public void AddLang(string key, string value)
		{
		}

		// Token: 0x040005C3 RID: 1475
		[Token(Token = "0x400046E")]
		[FieldOffset(Offset = "0x10")]
		public int LangType;

		// Token: 0x040005C4 RID: 1476
		[Token(Token = "0x400046F")]
		[FieldOffset(Offset = "0x18")]
		public readonly List<LanguagePair> LanguageData;
	}
}
