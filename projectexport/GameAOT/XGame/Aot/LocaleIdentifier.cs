using System;
using Il2CppDummyDll;

namespace XGame.Aot
{
	// Token: 0x02000151 RID: 337
	[Token(Token = "0x2000101")]
	[Attribute(Name = "LuaCallCSharpAttribute", RVA = "0x90BA0", Offset = "0x8FFA0")]
	[Serializable]
	public class LocaleIdentifier
	{
		// Token: 0x06000A5E RID: 2654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092B")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public LocaleIdentifier()
		{
		}

		// Token: 0x040005F2 RID: 1522
		[Token(Token = "0x4000497")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x040005F3 RID: 1523
		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x040005F4 RID: 1524
		[Token(Token = "0x4000499")]
		[FieldOffset(Offset = "0x20")]
		public string displayName;

		// Token: 0x040005F5 RID: 1525
		[Token(Token = "0x400049A")]
		[FieldOffset(Offset = "0x28")]
		public string key;

		// Token: 0x040005F6 RID: 1526
		[Token(Token = "0x400049B")]
		[FieldOffset(Offset = "0x30")]
		public string prefix_config;

		// Token: 0x040005F7 RID: 1527
		[Token(Token = "0x400049C")]
		[FieldOffset(Offset = "0x38")]
		public string prefix_res;

		// Token: 0x040005F8 RID: 1528
		[Token(Token = "0x400049D")]
		[FieldOffset(Offset = "0x40")]
		public string icon;

		// Token: 0x040005F9 RID: 1529
		[Token(Token = "0x400049E")]
		[FieldOffset(Offset = "0x48")]
		public int dataType;

		// Token: 0x040005FA RID: 1530
		[Token(Token = "0x400049F")]
		[FieldOffset(Offset = "0x50")]
		public string tail;
	}
}
