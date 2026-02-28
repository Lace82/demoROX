using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000096 RID: 150
	[Token(Token = "0x2000070")]
	internal class LoadCacheManifestOperation : AsyncOperationBase
	{
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600030B RID: 779 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007D")]
		public PackageManifest Manifest
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x8EF970", Offset = "0x8EED70", VA = "0x1808EF970")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0xCD51C0", Offset = "0xCD45C0", VA = "0x180CD51C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1BA82D0", Offset = "0x1BA76D0", VA = "0x181BA82D0")]
		public LoadCacheManifestOperation(PersistentManager persistent, string packageVersion)
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1BA8410", Offset = "0x1BA7810", VA = "0x181BA8410", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1BA8420", Offset = "0x1BA7820", VA = "0x181BA8420", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1BA8320", Offset = "0x1BA7720", VA = "0x181BA8320")]
		private void ClearCacheFile()
		{
		}

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x48")]
		private readonly PersistentManager _persistent;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x50")]
		private readonly string _packageVersion;

		// Token: 0x04000257 RID: 599
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x58")]
		private QueryCachePackageHashOperation _queryCachePackageHashOp;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x60")]
		private DeserializeManifestOperation _deserializer;

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x68")]
		private string _manifestFilePath;

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x70")]
		private LoadCacheManifestOperation.ESteps _steps;

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private PackageManifest <Manifest>k__BackingField;

		// Token: 0x02000097 RID: 151
		[Token(Token = "0x20000D0")]
		private enum ESteps
		{
			// Token: 0x0400025D RID: 605
			[Token(Token = "0x4000320")]
			None,
			// Token: 0x0400025E RID: 606
			[Token(Token = "0x4000321")]
			QueryCachePackageHash,
			// Token: 0x0400025F RID: 607
			[Token(Token = "0x4000322")]
			VerifyFileHash,
			// Token: 0x04000260 RID: 608
			[Token(Token = "0x4000323")]
			LoadCacheManifest,
			// Token: 0x04000261 RID: 609
			[Token(Token = "0x4000324")]
			CheckDeserializeManifest,
			// Token: 0x04000262 RID: 610
			[Token(Token = "0x4000325")]
			Done
		}
	}
}
