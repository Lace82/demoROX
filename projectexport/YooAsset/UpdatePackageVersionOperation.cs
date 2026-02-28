using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x2000083")]
	public abstract class UpdatePackageVersionOperation : AsyncOperationBase
	{
		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600036F RID: 879 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600036E RID: 878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000085")]
		public string PackageVersion
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x105CEB0", Offset = "0x105C2B0", VA = "0x18105CEB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x105CEA0", Offset = "0x105C2A0", VA = "0x18105CEA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected set
			{
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000352")]
		[Address(RVA = "0xB9A0F0", Offset = "0xB994F0", VA = "0x180B9A0F0")]
		protected UpdatePackageVersionOperation()
		{
		}

		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <PackageVersion>k__BackingField;
	}
}
