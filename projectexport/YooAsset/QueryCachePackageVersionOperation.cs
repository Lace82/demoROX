using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000A0 RID: 160
	[Token(Token = "0x2000075")]
	internal class QueryCachePackageVersionOperation : AsyncOperationBase
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000326 RID: 806 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000325 RID: 805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000082")]
		public string PackageVersion
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0xCB09B0", Offset = "0xCAFDB0", VA = "0x180CB09B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000307")]
			[Address(RVA = "0xCB1390", Offset = "0xCB0790", VA = "0x180CB1390")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1BAA7F0", Offset = "0x1BA9BF0", VA = "0x181BAA7F0")]
		public QueryCachePackageVersionOperation(PersistentManager persistent)
		{
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1BAFC70", Offset = "0x1BAF070", VA = "0x181BAFC70", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1BAFC80", Offset = "0x1BAF080", VA = "0x181BAFC80", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x48")]
		private readonly PersistentManager _persistent;

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x50")]
		private QueryCachePackageVersionOperation.ESteps _steps;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <PackageVersion>k__BackingField;

		// Token: 0x020000A1 RID: 161
		[Token(Token = "0x20000D5")]
		private enum ESteps
		{
			// Token: 0x04000293 RID: 659
			[Token(Token = "0x400033B")]
			None,
			// Token: 0x04000294 RID: 660
			[Token(Token = "0x400033C")]
			LoadCachePackageVersionFile,
			// Token: 0x04000295 RID: 661
			[Token(Token = "0x400033D")]
			Done
		}
	}
}
