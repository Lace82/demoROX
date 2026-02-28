using System;
using Il2CppDummyDll;

namespace XGame.Aot
{
	// Token: 0x02000153 RID: 339
	[Token(Token = "0x2000103")]
	[Attribute(Name = "LuaCallCSharpAttribute", RVA = "0x90BA0", Offset = "0x8FFA0")]
	public class PlatformWrapperAOT
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000061")]
		public static string SdkType
		{
			[Token(Token = "0x600092D")]
			[Address(RVA = "0xECD4F0", Offset = "0xECC8F0", VA = "0x180ECD4F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600092E")]
			[Address(RVA = "0xECD530", Offset = "0xECC930", VA = "0x180ECD530")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092F")]
		[Address(RVA = "0xECD3F0", Offset = "0xECC7F0", VA = "0x180ECD3F0")]
		public static void CreatePlatform()
		{
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000930")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public PlatformWrapperAOT()
		{
		}

		// Token: 0x040005FC RID: 1532
		[Token(Token = "0x40004A1")]
		[FieldOffset(Offset = "0x50270")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private static string <SdkType>k__BackingField;
	}
}
