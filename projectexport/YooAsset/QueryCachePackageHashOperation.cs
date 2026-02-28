using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200009E RID: 158
	[Token(Token = "0x2000074")]
	internal class QueryCachePackageHashOperation : AsyncOperationBase
	{
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000321 RID: 801 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000320 RID: 800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000081")]
		public string PackageHash
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0xCB0750", Offset = "0xCAFB50", VA = "0x180CB0750")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000302")]
			[Address(RVA = "0xB9D9F0", Offset = "0xB9CDF0", VA = "0x180B9D9F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x1BA82D0", Offset = "0x1BA76D0", VA = "0x181BA82D0")]
		public QueryCachePackageHashOperation(PersistentManager persistent, string packageVersion)
		{
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1BAF8F0", Offset = "0x1BAECF0", VA = "0x181BAF8F0", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1BAFB50", Offset = "0x1BAEF50", VA = "0x181BAFB50", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x48")]
		private readonly PersistentManager _persistent;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x50")]
		private readonly string _packageVersion;

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x58")]
		private QueryCachePackageHashOperation.ESteps _steps;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <PackageHash>k__BackingField;

		// Token: 0x0200009F RID: 159
		[Token(Token = "0x20000D4")]
		private enum ESteps
		{
			// Token: 0x0400028C RID: 652
			[Token(Token = "0x4000337")]
			None,
			// Token: 0x0400028D RID: 653
			[Token(Token = "0x4000338")]
			LoadCachePackageHashFile,
			// Token: 0x0400028E RID: 654
			[Token(Token = "0x4000339")]
			Done
		}
	}
}
