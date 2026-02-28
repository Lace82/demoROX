using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200009C RID: 156
	[Token(Token = "0x2000073")]
	internal class QueryBuildinPackageVersionOperation : AsyncOperationBase
	{
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600031C RID: 796 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000080")]
		public string PackageVersion
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0xCB0750", Offset = "0xCAFB50", VA = "0x180CB0750")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0xB9D9F0", Offset = "0xB9CDF0", VA = "0x180B9D9F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x1BAA7F0", Offset = "0x1BA9BF0", VA = "0x181BAA7F0")]
		public QueryBuildinPackageVersionOperation(PersistentManager persistent)
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1BAF8F0", Offset = "0x1BAECF0", VA = "0x181BAF8F0", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1BAF900", Offset = "0x1BAED00", VA = "0x181BAF900", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x48")]
		private readonly PersistentManager _persistent;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x50")]
		private UnityWebDataRequester _downloader;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x58")]
		private QueryBuildinPackageVersionOperation.ESteps _steps;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <PackageVersion>k__BackingField;

		// Token: 0x0200009D RID: 157
		[Token(Token = "0x20000D3")]
		private enum ESteps
		{
			// Token: 0x04000284 RID: 644
			[Token(Token = "0x4000333")]
			None,
			// Token: 0x04000285 RID: 645
			[Token(Token = "0x4000334")]
			LoadBuildinPackageVersionFile,
			// Token: 0x04000286 RID: 646
			[Token(Token = "0x4000335")]
			Done
		}
	}
}
