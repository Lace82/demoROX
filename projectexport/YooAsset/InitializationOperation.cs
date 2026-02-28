using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000086 RID: 134
	[Token(Token = "0x2000067")]
	public abstract class InitializationOperation : AsyncOperationBase
	{
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060002EA RID: 746 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007A")]
		public string PackageVersion
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x105CEB0", Offset = "0x105C2B0", VA = "0x18105CEB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x105CEA0", Offset = "0x105C2A0", VA = "0x18105CEA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected set
			{
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xB9A0F0", Offset = "0xB994F0", VA = "0x180B9A0F0")]
		protected InitializationOperation()
		{
		}

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <PackageVersion>k__BackingField;
	}
}
