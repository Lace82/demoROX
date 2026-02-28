using System;
using Il2CppDummyDll;
using UnityEngine;

namespace XGame.Aot
{
	// Token: 0x02000152 RID: 338
	[Token(Token = "0x2000102")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0xDDEB0", Offset = "0xDD2B0")]
	public class LocalizationProfile : ScriptableObject
	{
		// Token: 0x06000A5F RID: 2655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092C")]
		[Address(RVA = "0xCBA660", Offset = "0xCB9A60", VA = "0x180CBA660")]
		public LocalizationProfile()
		{
		}

		// Token: 0x040005FB RID: 1531
		[Token(Token = "0x40004A0")]
		[FieldOffset(Offset = "0x18")]
		public LocaleIdentifier[] locales;
	}
}
